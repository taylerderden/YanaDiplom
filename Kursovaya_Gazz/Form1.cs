using MySql.Data.MySqlClient;
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

namespace Kursovaya_Gazz
{
    public partial class AuthorizationForm : Form
    {

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = Login.Text;
            String passUser = Password.Text;

            DataBase db = new DataBase();

            DataTable table = new DataTable();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("Select * from `Authorization` WHERE `Authorization_Login` = @uL AND `Authorization_Password` = @uP AND `Authorization_Category`= 'Admin'", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0) //поиск записей
            {
                this.Hide();
                MainForm mainForm = new MainForm(); //если успешна то открытие формы для админа
                mainForm.Show();
            }
            else //иначе ищет запись пользователя 
            {
                MySqlCommand commandUser = new MySqlCommand("SELECT * FROM `Authorization` WHERE `Authorization_Login` = @uL AND `Authorization_Password` = @uP", db.GetConnection()); //авторизация пользователя
                commandUser.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                commandUser.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = commandUser;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    UserForm userForm = new UserForm(); //если успешна то открытие формы для админа
                    userForm.Show();
                }
                else
                    MessageBox.Show("Failed!"); //иначе ошибка
            }
        }

        private void labelID_Click(object sender, EventArgs e)
        {
            String loginUser = Login.Text; // запись логина
            String passUser = Password.Text; // запись пароля

            if (Login.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (Password.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandID = new MySqlCommand("SELECT `Abonent_idAbonent` FROM `Authorization` WHERE `Authorization_Login` = @uL AND `Authorization_Password` = @uP", db.GetConnection()); //авторизация администратора
            commandID.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            commandID.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = commandID;
            adapter.Fill(table);

            db.openConnection();

            if (table.Rows.Count > 0) //поиск записей
            {
                string id = commandID.ExecuteScalar().ToString();   // извлекаем id
                labelID.Text = "ID:" + ' ' + id;
            }
            else
                MessageBox.Show("Failed!"); //иначе ошибка

            db.closeConnection();
        }
    }
}
