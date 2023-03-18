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
    public partial class LgotaForm : Form
    {
        public LgotaForm()
        {
            InitializeComponent();
        }

        private void LgotaForm_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Lgota", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dGVLgota.DataSource = table;

            dGVLgota.Columns[0].HeaderText = "код_Льготы";
            dGVLgota.Columns[1].HeaderText = "Название_Льготы";
            dGVLgota.Columns[2].HeaderText = "Коэффициент_Льготы";

            tBID.Text = "ID";                //подсказка
            tBID.ForeColor = Color.Purple;

            tBName.Text = "Название";                //подсказка
            tBName.ForeColor = Color.Purple;

            tBKoeff.Text = "Коэффициент";                //подсказка
            tBKoeff.ForeColor = Color.Purple;

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

        private void tBKoeff_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBKoeff.Text = null;
            tBKoeff.ForeColor = Color.Black;
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

        private void tBKoeff_Leave(object sender, EventArgs e) //происходит когда элемент перестаёт быть активным
        {
            if (tBKoeff.Text == "")
            {
                tBKoeff.Text = "Коэффициент";
                tBKoeff.ForeColor = Color.Purple;
            }
        }
        public Boolean isDataExists()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Lgota WHERE `Lgota_Name`= @Name AND `Lgota_Koefficent` = @Koeff ", db.GetConnection());
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBName.Text;
            command.Parameters.Add("@Koeff", MySqlDbType.VarChar).Value = tBKoeff.Text;

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

        private void btnIns_Click(object sender, EventArgs e)
        {
            if (tBName.Text == "" || tBName.Text == "Название" && tBKoeff.Text == "" || tBKoeff.Text == "Коэффициент")
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

                MySqlCommand command = new MySqlCommand("INSERT INTO `Lgota`(`Lgota_Name`,`Lgota_Koefficent`) VALUES(@Name, @Koeff);", db.GetConnection());
                command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBName.Text;
                command.Parameters.Add("@Koeff", MySqlDbType.VarChar).Value = tBKoeff.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные добавлены");

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Lgota", db.GetConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dGVLgota.DataSource = table;

                    dGVLgota.Columns[0].HeaderText = "код_Льготы";
                    dGVLgota.Columns[1].HeaderText = "Название_Льготы";
                    dGVLgota.Columns[2].HeaderText = "Коэффициент_Льготы";
                }
                else
                    MessageBox.Show("Ошибка!");

                db.closeConnection();
            }

        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (tBID.Text == "" || tBID.Text == "ID" || tBID.Text == null && tBName.Text == "" || tBName.Text == "Название" || tBName.Text == null && tBKoeff.Text == "" || tBKoeff.Text == "Коэффициент" | tBKoeff.Text == null)
            {
                MessageBox.Show("Введите данные для обновления!");
            }
            else
            {
                DataBase db = new DataBase();

                MySqlCommand command = new MySqlCommand("UPDATE `Lgota` SET `Lgota_Name`= @Name, `Lgota_Koefficent`= @Koeff WHERE `idLgota` = @ID;", db.GetConnection());
                command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBName.Text;
                command.Parameters.Add("@Koeff", MySqlDbType.VarChar).Value = tBKoeff.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBID.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные обновлены");
                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Lgota", db.GetConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dGVLgota.DataSource = table;

                    dGVLgota.Columns[0].HeaderText = "код_Льготы";
                    dGVLgota.Columns[1].HeaderText = "Название_Льготы";
                    dGVLgota.Columns[2].HeaderText = "Коэффициент_Льготы";
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

                    MySqlCommand command = new MySqlCommand("DELETE FROM `Lgota` WHERE `idLgota` = @ID;", db.GetConnection());
                    command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBID.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные удалены");
                        DataTable table = new DataTable();

                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand command1 = new MySqlCommand("SELECT * FROM Lgota", db.GetConnection());

                        adapter.SelectCommand = command1;
                        adapter.Fill(table);

                        dGVLgota.DataSource = table;

                        dGVLgota.Columns[0].HeaderText = "код_Льготы";
                        dGVLgota.Columns[1].HeaderText = "Название_Льготы";
                        dGVLgota.Columns[2].HeaderText = "Коэффициент_Льготы";
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

            MySqlCommand command = new MySqlCommand("SELECT * FROM Lgota WHERE CONCAT(`idLgota`, `Lgota_Name`, `Lgota_Koefficent`)like'%" + textBoxSearch.Text + "%';", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dGVLgota.DataSource = table;

            dGVLgota.Columns[0].HeaderText = "код_Льготы";
            dGVLgota.Columns[1].HeaderText = "Название_Льготы";
            dGVLgota.Columns[2].HeaderText = "Коэффициент_Льготы";
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
