using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ManagmentPersonal
{
    public partial class InfoPersonForm : Form
    {
        public int UserId { get; set; }

        DataBase DataBase = new DataBase();
        public InfoPersonForm()
        {
            InitializeComponent();
        }
        SqlDataAdapter DataAdapter = new SqlDataAdapter();
        DataTable DataTable = new DataTable();
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string QueryString = $"Select * From Employees where Id={UserId}";

            DataAdapter.SelectCommand = new SqlCommand(QueryString, DataBase.GetConnection());

            SqlCommandBuilder builder = new SqlCommandBuilder(DataAdapter);
            DataAdapter.Update(DataTable);
            OnLoad(e);
            MessageBox.Show($"Сохранение прошло успешно", "Сохранение данных");
            TablePerson.ReadOnly = true;

        }

        private void InfoPersonForm_Load(object sender, EventArgs e)
        {
            string query = $"Select * From Employees where Id={UserId}";
            DataAdapter = new SqlDataAdapter(query, DataBase.GetConnection());
            DataAdapter.Fill(DataTable);
            TablePerson.DataSource = DataTable;
            TablePerson.ReadOnly = true;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            TablePerson.ReadOnly = false;
            MessageBox.Show("Включен режим редактирования");

        }

        private void BtnDismiss_Click(object sender, EventArgs e)
        {
            DataTable DataTable = new DataTable();
            string Query = $"SELECT [Id]\r\n      ,[IdEmployees]\r\n      ,[StartDate]\r\n      ,[EndDate]\r\n      ,[TypeEvent]\r\n      ,[AddInfo]\r\n  FROM [Pushkarcki].[dbo].[CalendarEvent]\r\nwhere IdEmployees={UserId} and TypeEvent=1 and CAST(StartDate as DATE)>CAST(GETDATE() as DATE)";
            SqlDataAdapter Adapter = new SqlDataAdapter(Query, DataBase.GetConnection());
            Adapter.Fill(DataTable);

            if (DataTable.Rows.Count > 0)
            {
                MessageBox.Show("Вы не можете уволить сотрудника тк у него предстоит обучение");
            }
            else
            {
                if (MessageBox.Show("Вы действительно хотите уволить сотрудника?", "Уволить сотрудника", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataBase.OpenConnection();
                    SqlCommand Command = new SqlCommand();
                    Query = $"update Employees\r\n  set IsWorking=0\r\n  where Id={UserId}";
                    Command = new SqlCommand(Query, DataBase.GetConnection());
                    Command.ExecuteNonQuery();
                    Query = $" delete from CalendarEvent\r\n where IdEmployees={UserId} and CAST(StartDate as date)>CAST(GETDATE() as date)";
                    Command = new SqlCommand(Query, DataBase.GetConnection());
                    Command.ExecuteNonQuery();
                    Query = $"INSERT INTO [dbo].[CalendarEvent] (IdEmployees, StartDate, EndDate, TypeEvent, AddInfo)\r\nVALUES\r\n({UserId}, CAST(GETDATE() as date), CAST(GETDATE() as date), 4, NULL)";
                    Command = new SqlCommand(Query, DataBase.GetConnection());
                    Command.ExecuteNonQuery();
                    DataBase.CloseConnection();
                    MessageBox.Show("Сотрудник уволен");
                }
                else
                { return; }
            }
            
        }

        private void BtnEvents_Click(object sender, EventArgs e)
        {
            EventPersForm Form = new EventPersForm();
            Form.UserId = UserId;
            Form.ShowDialog();
        }
    }
}