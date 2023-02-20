using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

            Password.UseSystemPasswordChar = false;

            Login.MaxLength = 10;
            Password.MaxLength = 10;
        }
        private string GetHash(string input)    // хеширование
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String loginUser = GetHash(Login.Text);
            String passUser = GetHash(Password.Text);

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

            MySqlCommand command = new MySqlCommand("Select * from `Authorization` WHERE `Authorization_Login` = @uL AND `Authorization_Password` = @uP AND `Authorization_Category`= 'Admin' AND `Authorization_Verify` = '+'", db.GetConnection());
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
                MySqlCommand commandUser = new MySqlCommand("SELECT * FROM `Authorization` WHERE `Authorization_Login` = @uL AND `Authorization_Password` = @uP AND `Authorization_Verify` = '+'", db.GetConnection()); //авторизация пользователя
                commandUser.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                commandUser.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                adapter.SelectCommand = commandUser;
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DataTable tableID = new DataTable();

                    MySqlDataAdapter adapterID = new MySqlDataAdapter();

                    MySqlCommand commandID = new MySqlCommand("SELECT `Abonent_idAbonent` FROM `Authorization` WHERE `Authorization_Login` = @uL AND `Authorization_Password` = @uP", db.GetConnection()); //авторизация администратора
                    commandID.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                    commandID.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

                    adapterID.SelectCommand = commandID;
                    adapterID.Fill(tableID);

                    db.openConnection();

                    if (tableID.Rows.Count > 0) //поиск записей
                    {
                        string id = commandID.ExecuteScalar().ToString();   // извлекаем id
                        Global.GlobalVar = id;
                    }
                    else
                        MessageBox.Show("Failed!"); //иначе ошибка

                    db.closeConnection();

                    this.Hide();
                    UserForm userForm = new UserForm(); //если успешна то открытие формы для админа
                    userForm.Show();
                }
                else
                    MessageBox.Show("Вы не зарегистрированы!"); //иначе ошибкаЫ

            }
        }

        private void labelPass_Click(object sender, EventArgs e)
        {
            if (labelPass.Text == "🗙")
            {
                Password.UseSystemPasswordChar = true;
                labelPass.Text = "👁";
            }
            else
            {
                Password.UseSystemPasswordChar = false;
                labelPass.Text = "🗙";
            }
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            labelPass.Text = "🗙";
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelOpen_Click(object sender, EventArgs e)
        {

        }

        private void labelColla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lastPoint;

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void labelRegistration_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm rForm = new RegistrationForm(); //
            rForm.Show();
        }
    }
}
