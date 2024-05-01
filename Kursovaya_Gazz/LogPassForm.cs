using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_Gazz
{
    public partial class LogPassForm : Form
    {
        public LogPassForm()
        {
            InitializeComponent();
        }

        private string GetHash(string input)    // хеширование
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            String loginUser = GetHash(tbLogin.Text); // запись логина
            String passUser = GetHash(tbPassword.Text); // запись пароля

            if (tbLogin.Text == "")
            {
                MessageBox.Show("Введите логин!");
                return;
            }
            if (tbPassword.Text == "")
            {
                MessageBox.Show("Введите пароль!");
                return;
            }

            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandCheckData = new MySqlCommand("SELECT * FROM `Authorization` WHERE `Authorization_Login` = @uL AND `Authorization_Password` = @uP", db.GetConnection()); //проверка занятости лог и пароля
            commandCheckData.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            commandCheckData.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = commandCheckData;
            adapter.Fill(table);

            if (table.Rows.Count == 0) //если не обнаружено совпадений то ниже запрос
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `Authorization` (`Authorization_Login`, `Authorization_Password`, `Abonent_idAbonent`, `Authorization_Email`) VALUES (@uL, @uP, @ID, @AE);", db.GetConnection());

                command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
                command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;
                command.Parameters.Add("@AE", MySqlDbType.VarChar).Value = textBoxEmail.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Ваши данные внесены, ожидайте подтверждения учетной записи!");
                    this.Hide();
                    AuthorizationForm aForm = new AuthorizationForm(); //открытие формы авторизации
                    aForm.Show();
                }
                else
                    MessageBox.Show("Ошибка внесения данных!");

                db.closeConnection();
            }
            else
                MessageBox.Show("Данные уже существуют!"); //иначе предупреждение о том что данные уже существуют
        }
    }
}

