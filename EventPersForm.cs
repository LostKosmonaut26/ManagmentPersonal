using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagmentPersonal
{
    public partial class EventPersForm : Form
    {
        public int UserId { get; set; }
        DataTable Table = new DataTable();
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        DataBase DataBase = new DataBase();
        public EventPersForm()
        {
            InitializeComponent();
        }

        private void EventPersForm_Load(object sender, EventArgs e)
        {
            BtnNow.Checked = true;
            BtnFuture.Checked = true;
         
            UpdateDataGrid();

            StartDate.CustomFormat = "yyyy-MM-dd";
            EndDate.CustomFormat = "yyyy-MM-dd";

        }
        private void UpdateDataGrid()
        {
            Table.Clear(); // Очищаем таблицу перед обновлением

            List<string> conditions = new List<string>();

            // Собираем условия от активных чекбоксов
            if (BtnLast.Checked)
                conditions.Add("GETDATE() > EndDate");
            if (BtnNow.Checked)
                conditions.Add("GETDATE() BETWEEN StartDate AND EndDate");
            if (BtnFuture.Checked)
                conditions.Add("GETDATE() < StartDate");

            if (conditions.Count == 0)
            {
                TableEvent.DataSource = null; // Если ничего не выбрано
                return;
            }

            // Объединяем условия через OR
            string whereClause = string.Join(" OR ", conditions);

            // Формируем SQL-запрос
            string query = $@"
                SELECT TOP (1000) 
                    Em.Id, 
                    Em.FullName, 
                    [StartDate], 
                    [EndDate], 
                    Ev.[Name], 
                    [AddInfo]
                FROM [Pushkarcki].[dbo].[CalendarEvent]
                JOIN Employees AS Em ON Em.Id = CalendarEvent.IdEmployees
                JOIN [Events] AS Ev ON CalendarEvent.TypeEvent = Ev.Id
                WHERE Em.Id = {UserId} 
                    AND ({whereClause})
                ORDER BY Ev.[Name]";

            // Используем параметризованный запрос для безопасности
            
            DataAdapter = new SqlDataAdapter(query,DataBase.GetConnection());
            DataAdapter.Fill(Table);
               

            TableEvent.DataSource = Table; // Обновляем DataGrid
        }

     

        private void BtnLast_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void BtnNow_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void BtnFuture_CheckedChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            DateTime firstDate = StartDate.Value.Date;
            DateTime secondDate = EndDate.Value.Date;
            int typeEvent = TypeBox.SelectedIndex;

            // Проверка корректности дат (начальная дата не может быть позже конечной)
            if (firstDate > secondDate)
            {
                MessageBox.Show("Начальная дата не может быть позже конечной.");
                return;
            }

            // Получаем все существующие события для данного пользователя
            var existingEvents = GetExistingEvents(UserId);

            foreach (var eventItem in existingEvents)
            {
                DateTime existingStartDate = eventItem.StartDate;
                DateTime existingEndDate = eventItem.EndDate;
                int existingType = eventItem.TypeEvent;

                // Проверяем пересечение дат
                if (IsDateOverlap(firstDate, secondDate, existingStartDate, existingEndDate))
                {
                    // Отпуск и отгул не могут пересекаться
                    if ((typeEvent == 0 && existingType == 1) || (typeEvent == 1 && existingType == 0))
                    {
                        MessageBox.Show("Отпуск и отгул не могут быть в одни даты.");
                        return;
                    }

                    // Отгул и обучение не могут пересекаться
                    if ((typeEvent == 1 && existingType == 2) || (typeEvent == 2 && existingType == 1))
                    {
                        MessageBox.Show("Отгул и обучение не могут быть в одни даты.");
                        return;
                    }

                    // Отгул не может быть в выходной день по производственному календарю
                    if (typeEvent == 1)
                    {
                        for (DateTime date = firstDate; date <= secondDate; date = date.AddDays(1))
                        {
                            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                            {
                                MessageBox.Show("Отгул не может быть в выходной день.");
                                return;
                            }
                        }
                    }
                }
            }

            // Если все проверки пройдены успешно, добавляем новое событие
            try
            {
                DataBase.OpenConnection();
                string query = $"INSERT INTO CalendarEvent ([IdEmployees], [StartDate], [EndDate], [TypeEvent], [AddInfo]) " +
                               $"VALUES ({UserId}, '{firstDate:yyyy-MM-dd}', '{secondDate:yyyy-MM-dd}', {typeEvent}, '{AddInfoBox.Text}')";
                SqlCommand command = new SqlCommand(query, DataBase.GetConnection());
                command.ExecuteNonQuery();
                DataBase.CloseConnection();
                MessageBox.Show("Запись добавлена");
                EventPersForm_Load(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при добавлении записи: {ex.Message}");
                DataBase.CloseConnection();
            }
        }

        // Метод для получения существующих событий пользователя
        private List<(DateTime StartDate, DateTime EndDate, int TypeEvent)> GetExistingEvents(int userId)
        {
            var events = new List<(DateTime StartDate, DateTime EndDate, int TypeEvent)>();

            string query = $"SELECT StartDate, EndDate, TypeEvent FROM CalendarEvent WHERE IdEmployees = {userId}";
            SqlCommand command = new SqlCommand(query, DataBase.GetConnection());

            DataBase.OpenConnection();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                events.Add((
                    StartDate: Convert.ToDateTime(reader["StartDate"]),
                    EndDate: Convert.ToDateTime(reader["EndDate"]),
                    TypeEvent: Convert.ToInt32(reader["TypeEvent"])
                ));
            }

            reader.Close();
            DataBase.CloseConnection();

            return events;
        }

        // Метод для проверки пересечения дат
        private bool IsDateOverlap(DateTime start1, DateTime end1, DateTime start2, DateTime end2)
        {
            return start1 <= end2 && start2 <= end1;
        }
    }
}