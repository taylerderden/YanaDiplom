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
            if (tBName.Text != "" && tBKoeff.Text != "")
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
            else
                MessageBox.Show("Введите данные!");

        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (tBID.Text != "" && tBName.Text != "" && tBKoeff.Text != "")
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
            else
                MessageBox.Show("Введите данные для обновления!");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tBID.Text != "" || tBName.Text != "" || tBKoeff.Text != "")
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
            else
                MessageBox.Show("Введите данные для удаления!");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tBID.Text != "" || tBName.Text != "" || tBKoeff.Text != "")
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM Lgota WHERE `idLgota` = @ID OR`Lgota_Name`= @Name OR `Lgota_Koefficent`= @Koeff;", db.GetConnection());
                command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = tBName.Text;
                command.Parameters.Add("@Koeff", MySqlDbType.VarChar).Value = tBKoeff.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBID.Text;

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dGVLgota.DataSource = table;

                dGVLgota.Columns[0].HeaderText = "код_Льготы";
                dGVLgota.Columns[1].HeaderText = "Название_Льготы";
                dGVLgota.Columns[2].HeaderText = "Коэффициент_Льготы";
            }
            else
                MessageBox.Show("Введите данные для поиска!");
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelOpen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Normal;
            }
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
    }
}
