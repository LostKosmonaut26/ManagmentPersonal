using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagmentPersonal
{
    internal class DataBase
    {
        SqlConnection StringConnect = new SqlConnection(@"Data Source=tcp:84.54.228.191,49172;Initial Catalog=Pushkarcki;User ID=Pushkarcki;Password=3kVJPI3h;");

        public void OpenConnection()
        {
            if (StringConnect.State == System.Data.ConnectionState.Closed)
                StringConnect.Open();
        }
        public void CloseConnection()
        {
            if (StringConnect.State == System.Data.ConnectionState.Open)
                StringConnect.Close();
        }
        public SqlConnection GetConnection()
        {
            return StringConnect;
        }
    }
}
