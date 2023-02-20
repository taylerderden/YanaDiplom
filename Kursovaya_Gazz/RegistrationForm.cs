using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_Gazz
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        public Boolean isUserExists()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `Abonent` WHERE `Abonent_Schet` = @S", db.GetConnection()); //проверка введенного пользов-м и указываем БД к которой подключ-ся 
            command.Parameters.Add("@S", MySqlDbType.VarChar).Value = tbSchet.Text;


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)   //проверка занятости данных, поиск записей в табл
            {
                MessageBox.Show("Данные уже существуют!");
                return true;
            }
            else
                return false;
        }
        String Lgota, Tarif;
        private void btnCreateAbonent_Click(object sender, EventArgs e)
        {
            if (tbFIO.Text == "") //проверка заполненности
            {
                MessageBox.Show("Введите ФИО!");
                return;
            }
            if (tbSchet.Text == "") //проверка заполненности
            {
                MessageBox.Show("Введите номер счета!");
                return;
            }
            if (tbAdress.Text == "") //проверка заполненности
            {
                MessageBox.Show("Введите адрес!");
                return;
            }
            if (tbPeople.Text == "") //проверка заполненности
            {
                MessageBox.Show("Введите жильцов!");
                return;
            }
            if (tbSquare.Text == "") //проверка заполненности
            {
                MessageBox.Show("Введите площадь!");
                return;
            }

            if (cbLgota.Text != "")
            {
                DataBase db0 = new DataBase();

                DataTable tableL = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command0 = new MySqlCommand("SELECT `idLgota` FROM `Lgota` WHERE `Lgota_Name` = @L", db0.GetConnection());
                command0.Parameters.Add("@L", MySqlDbType.VarChar).Value = cbLgota.Text;

                adapter.SelectCommand = command0;
                adapter.Fill(tableL);

                db0.openConnection();
                if (tableL.Rows.Count > 0)
                {
                    Lgota = command0.ExecuteScalar().ToString();   // извлекаем id
                }
                else
                    MessageBox.Show("Ошибка выбора льготы!");
                db0.closeConnection();
            }
            else
                MessageBox.Show("Выберите льготу!");

            if (cbTarif.Text != "")
            {
                DataBase db0 = new DataBase();

                DataTable tableT = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command0 = new MySqlCommand("SELECT `idTarif` FROM `Tarif` WHERE `Tarif_Name` = @T", db0.GetConnection());
                command0.Parameters.Add("@T", MySqlDbType.VarChar).Value = cbTarif.Text;

                adapter.SelectCommand = command0;
                adapter.Fill(tableT);

                db0.openConnection();
                if (tableT.Rows.Count > 0)
                {
                    Tarif = command0.ExecuteScalar().ToString();   // извлекаем id
                }
                else
                    MessageBox.Show("Ошибка выбора тарифа!");
                db0.closeConnection();
            }
            else
                MessageBox.Show("Выберите тариф!");

            if (isUserExists()) //проверка занятости данных
            {
                return;
            }

            if (cbLgota.Text != "" && cbTarif.Text != "")
            {
                DataBase db = new DataBase();
                MySqlCommand command = new MySqlCommand("INSERT INTO `Abonent` (`Abonent_Schet`, `Abonent_FIO`, `Abonent_Adress`, `Abonent_Square`, `Abonent_People`, `Tarif_idTarif`, `Lgota_idLgota`)" +
                    " VALUES (@Sch, @FIO, @A, @Sq, @P, @T, @L);", db.GetConnection());

                command.Parameters.Add("@Sch", MySqlDbType.VarChar).Value = tbSchet.Text;
                command.Parameters.Add("@FIO", MySqlDbType.VarChar).Value = tbFIO.Text;
                command.Parameters.Add("@A", MySqlDbType.VarChar).Value = tbAdress.Text;
                command.Parameters.Add("@Sq", MySqlDbType.VarChar).Value = tbSquare.Text;
                command.Parameters.Add("@P", MySqlDbType.VarChar).Value = tbPeople.Text;
                command.Parameters.Add("@T", MySqlDbType.VarChar).Value = Tarif;
                command.Parameters.Add("@L", MySqlDbType.VarChar).Value = Lgota;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные успешно внесены");

                    DataTable tableID = new DataTable();
                    MySqlDataAdapter adapterID = new MySqlDataAdapter();

                    MySqlCommand commandID = new MySqlCommand("SELECT `idAbonent` FROM `Abonent` WHERE `Abonent_Schet` = @Sch", db.GetConnection()); //
                    commandID.Parameters.Add("@Sch", MySqlDbType.VarChar).Value = tbSchet.Text;

                    adapterID.SelectCommand = commandID;
                    adapterID.Fill(tableID);

                    if (tableID.Rows.Count > 0) //поиск записей
                    {
                        string id = commandID.ExecuteScalar().ToString();   // извлекаем id
                        Global.GlobalVar = id;
                    }
                    else
                        MessageBox.Show("Ошибка ID!"); //иначе ошибка

                    this.Hide();
                    LogPassForm lpForm = new LogPassForm(); //если успешна то открытие формы для админа
                    lpForm.Show();
                }
                else
                    MessageBox.Show("Ошибка внесения данных!");

                db.closeConnection();
            }
            else
                MessageBox.Show("Заполните поля!");
        }
    }
}
