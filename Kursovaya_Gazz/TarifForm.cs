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
using System.Xml.Linq;

namespace Kursovaya_Gazz
{
    public partial class TarifForm : Form
    {
        public TarifForm()
        {
            InitializeComponent();
        }

        private void TarifForm_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Tarif", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dGVTarif.DataSource = table;

            dGVTarif.Columns[0].HeaderText = "код_Тарифа";
            dGVTarif.Columns[1].HeaderText = "Название_Тарифа";
            dGVTarif.Columns[2].HeaderText = "Прайс_Тарифа";

            tBID.Text = "ID";                //подсказка
            tBID.ForeColor = Color.Purple;

            tBName.Text = "Название";                //подсказка
            tBName.ForeColor = Color.Purple;

            tBPrice.Text = "Стоимость";                //подсказка
            tBPrice.ForeColor = Color.Purple;
        }

        private void tbID_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBID.Text = null;
            tBID.ForeColor = Color.Black;
        }

        private void tbName_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBName.Text = null;
            tBName.ForeColor = Color.Black;
        }

        private void tbPrice_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBPrice.Text = null;
            tBPrice.ForeColor = Color.Black;
        }

        private void tbID_Leave(object sender, EventArgs e) // происходит когда элемент перестаёт быть активным
        {
            if (tBID.Text == "")
            {
                tBID.Text = "ID";
                tBID.ForeColor = Color.Purple;
            }
        }

        private void tbName_Leave(object sender, EventArgs e) //происходит когда элемент перестаёт быть активным
        {
            if (tBName.Text == "")
            {
                tBName.Text = "Название";
                tBName.ForeColor = Color.Purple;
            }
        }

        private void tbPrice_Leave(object sender, EventArgs e) //происходит когда элемент перестаёт быть активным
        {
            if (tBPrice.Text == "")
            {
                tBPrice.Text = "Стоимость";
                tBPrice.ForeColor = Color.Purple;
            }
        }
        
        private void btnIns_Click(object sender, EventArgs e)
        {
            if (tBName.Text == "" || tBName.Text == "Название" && tBPrice.Text == "" || tBPrice.Text == "Стоимость")
            {
                MessageBox.Show("Введите данные!");
            }
            else
            {
                if (isDataExists())
                {
                    return;
                }
                DataBase db = new DataBase();

                MySqlCommand command = new MySqlCommand("INSERT INTO `Tarif`(`Tarif_Name`,`Tarif_Price`) VALUES(@Name, @Price);", db.GetConnection());
                command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBName.Text;
                command.Parameters.Add("@Price", MySqlDbType.VarChar).Value = tBPrice.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные добавлены");

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Tarif", db.GetConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dGVTarif.DataSource = table;

                    dGVTarif.Columns[0].HeaderText = "код_Тарифа";
                    dGVTarif.Columns[1].HeaderText = "Название_Тарифа";
                    dGVTarif.Columns[2].HeaderText = "Прайс_Тарифа";
                }
                else
                    MessageBox.Show("Ошибка!");

                db.closeConnection();
            }
        }

        public Boolean isDataExists()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Tarif WHERE `Tarif_Name`= @Name AND `Tarif_Price` = @Price ", db.GetConnection());
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBName.Text;
            command.Parameters.Add("@Price", MySqlDbType.VarChar).Value = tBPrice.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)   //проверка схожести данных
            {
                MessageBox.Show("Данные уже введены!");
                return true;
            }
            else
                return false;
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (tBID.Text == "" || tBID.Text == "ID" || tBID.Text == null && tBName.Text == "" || tBName.Text == "Название" || tBName.Text == null && tBPrice.Text == "" || tBPrice.Text == "Стоимость" | tBPrice.Text == null)
            {
                MessageBox.Show("Введите данные для обновления!");
            }
            else
            {
                DataBase db = new DataBase();

                MySqlCommand command = new MySqlCommand("UPDATE `Tarif` SET `Tarif_Name`= @Name, `Tarif_Price`= @Price WHERE `idTarif` = @ID;", db.GetConnection());
                command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBName.Text;
                command.Parameters.Add("@Price", MySqlDbType.VarChar).Value = tBPrice.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBID.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные обновлены");
                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Tarif", db.GetConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dGVTarif.DataSource = table;

                    dGVTarif.Columns[0].HeaderText = "код_Тарифа";
                    dGVTarif.Columns[1].HeaderText = "Название_Тарифа";
                    dGVTarif.Columns[2].HeaderText = "Прайс_Тарифа";
                }
                else
                    MessageBox.Show("Ошибка!");

                db.closeConnection();
            }
                    
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tBID.Text == "" || tBID.Text == "ID")
            {
                MessageBox.Show("Введите данные для удаления!");
            }
            else
            {
                try
                {
                    DataBase db = new DataBase();

                    MySqlCommand command = new MySqlCommand("DELETE FROM `Tarif` WHERE `idTarif` = @ID;", db.GetConnection());
                    command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBID.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные удалены");
                        DataTable table = new DataTable();

                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand command1 = new MySqlCommand("SELECT * FROM Tarif", db.GetConnection());

                        adapter.SelectCommand = command1;
                        adapter.Fill(table);

                        dGVTarif.DataSource = table;

                        dGVTarif.Columns[0].HeaderText = "код_Тарифа";
                        dGVTarif.Columns[1].HeaderText = "Название_Тарифа";
                        dGVTarif.Columns[2].HeaderText = "Прайс_Тарифа";
                    }
                    else
                        MessageBox.Show("Ошибка!");

                    db.closeConnection();
                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Tarif WHERE CONCAT(`idTarif`, `Tarif_Name`, `Tarif_Price`)like'%" + textBoxSearch.Text + "%';", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dGVTarif.DataSource = table;

            dGVTarif.Columns[0].HeaderText = "код_Тарифа";
            dGVTarif.Columns[1].HeaderText = "Название_Тарифа";
            dGVTarif.Columns[2].HeaderText = "Прайс_Тарифа";
        }

        private void labelUpdate_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Tarif", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dGVTarif.DataSource = table;

            dGVTarif.Columns[0].HeaderText = "код_Тарифа";
            dGVTarif.Columns[1].HeaderText = "Название_Тарифа";
            dGVTarif.Columns[2].HeaderText = "Прайс_Тарифа";
        }

        private void tBID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
    }



