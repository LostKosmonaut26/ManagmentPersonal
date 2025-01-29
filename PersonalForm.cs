using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace ManagmentPersonal
{
    public partial class PersonalForm : Form
    {
        DataBase dataBase = new DataBase();
        public PersonalForm()
        {
            this.ShowIcon = false;
            InitializeComponent();
        }



        private void TreeDepartment_AfterSelect(object sender, TreeViewEventArgs e)
        {
            

            
        }

        private void TablePersonal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable Table= new DataTable();
            if (e.RowIndex>=0)
            {
                var User = TablePersonal.Rows[e.RowIndex];
                int UserId = Convert.ToInt32(User.Cells["Id"].Value);
                InfoPersonForm InfoPersonForm = new InfoPersonForm();
                InfoPersonForm.UserId=UserId;
                InfoPersonForm.ShowDialog();
                
                //SqlDataAdapter Adapter = new SqlDataAdapter($"select * from Employees where Id={UserId}", dataBase.GetConnection());
                //Table.Clear();
                //Adapter.Fill(Table);
                //TablePersonal.DataSource = Table;
            }
        }

        private void TreeDepartment_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            DataTable Table = new DataTable();
            TreeNode  Tree= e.Node;
            string Branch=Tree.Text;
            string QueryString = "SELECT TOP (1000) Employees.Id,[FullName],D.NameDepartment,P.NamePosition,[WorkPhone],[Email],C.[Name],Employees.IsWorking,  CE.StartDate " +
                        "FROM [Pushkarcki].[dbo].[Employees]" +
                        "  join Positions as P on P.Id=Employees.IdPosition" +
                        " join Departaments as D on D.Id=P.IdDepartment" +
                        "  join Organization as Org on Org.Id=D.IdOrganization" +
                        "  join Cabinets as C on C.Id=Employees.Cabinet " +
                        "LEFT JOIN calendarEvent AS CE ON CE.IdEmployees = Employees.Id AND CE.TypeEvent = 4 " +
                        $"WHERE Org.[Name] = '{Branch}' " +
                        "AND (Employees.IsWorking = 1 OR CE.StartDate > DATEADD(day, -30, GETDATE()))";
            if (Tree.Nodes.Count == 0)
            {
                try
                {
                    SqlDataAdapter Adapter = new SqlDataAdapter(QueryString, dataBase.GetConnection());
                    Table.Clear();
                    Adapter.Fill(Table);
                    TablePersonal.DataSource = Table;
                    foreach (DataRow row in Table.Rows)
                    {
                        // Проверяем значение IsWorking
                        if (row["IsWorking"] != DBNull.Value && (bool)row["IsWorking"] == false)
                        {
                            // Находим соответствующую строку в DataGridView
                            int rowIndex = Table.Rows.IndexOf(row);
                            TablePersonal.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                        }
                    }
                }
                catch (Exception ex)
                { MessageBox.Show($"Ошибка загрузка данных.\nОшибка:{ex}"); }
                
            }
            
        }
    }
}
