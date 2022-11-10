using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Kursovaya_Gazz
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("Server=cfif31.ru;User ID=ISPr23-35_RogozhnikovaYO;Password=ISPr23-35_RogozhnikovaYO;Character Set=utf8; Port=3306; DataBase=ISPr23-35_RogozhnikovaYO_uchet_gaza");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }



    }
}
