using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.IO;

namespace Kursovaya_Gazz
{
    public partial class MissPassForm : Form
    {
        int randomNumber;
        public MissPassForm()
        {
            InitializeComponent();
        }

        private void btnSendKod_Click(object sender, EventArgs e)
        {
            try
            {
                MailAddress fromAddress = new MailAddress("danizlobin_2004@mail.ru", "Gaz"); // почта и имя от кого отправить yana.rogozhnikova.04@mail.ru
                MailAddress toAddress = new MailAddress(textBoxEmail.Text); // почта и имя кому отправить
                MailMessage message = new MailMessage(fromAddress, toAddress);               
                message.Subject = "Код для восстановления пароля";

                Random random = new Random();
                randomNumber = random.Next(1000, 9999);
                message.Body = Convert.ToString(randomNumber);

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.mail.ru";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("danizlobin_2004@mail.ru", "T2WArS0RkFAGQ1V9StC7"); // логин пароль от почты с которой отправить

                smtpClient.Send(message);
                MessageBox.Show("Код отправлен");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Почты не найдено!");
            }
        }

        private void textBoxKod_TextChanged(object sender, EventArgs e)
        {
            if (textBoxKod.Text == Convert.ToString(randomNumber))
            {
                labelYes.Text = "+";
                labelNewPass.Visible = true;
                tbNewPass.Visible = true;
                labelNewPass2.Visible = true;
                tbNewPass2.Visible = true;
                btnUpdate.Visible = true;
            }          
            
            

        }
        private string GetHash(string input)    // хеширование
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbNewPass.Text == "" || tbNewPass2.Text == "" || tbNewPass.Text == null || tbNewPass2.Text == null || tbNewPass.Text != tbNewPass2.Text)
            {
                MessageBox.Show("Пароли не совпадают!");
            }
            else
            {
                String passUser = GetHash(tbNewPass2.Text); // запись пароля

                DataBase db = new DataBase();

                MySqlCommand command = new MySqlCommand("UPDATE `Authorization` SET `Authorization_Password`= @NewPass WHERE `Authorization_Email` = @Email;", db.GetConnection());
                command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = textBoxEmail.Text;
                command.Parameters.Add("@NewPass", MySqlDbType.VarChar).Value = passUser;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные обновлены");                    
                }
                else
                    MessageBox.Show("Ошибка!");

                db.closeConnection();
            }
        }
    }
}
