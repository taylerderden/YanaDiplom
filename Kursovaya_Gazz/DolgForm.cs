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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovaya_Gazz
{
    public partial class DolgForm : Form
    {
        public DolgForm()
        {
            InitializeComponent();
        }

        private void DolgForm_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Dolg", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dGVDolg.DataSource = table;

            dGVDolg.Columns[0].HeaderText = "код_Долга";
            dGVDolg.Columns[1].HeaderText = "Сумма_Долга";
            dGVDolg.Columns[2].HeaderText = "код_Абонента";

            tBID.Text = "ID";                //подсказка
            tBID.ForeColor = Color.Purple;

            tBSumma.Text = "Сумма долга";                //подсказка
            tBSumma.ForeColor = Color.Purple;

            tBidAb.Text = "ID Абонента";                //подсказка
            tBidAb.ForeColor = Color.Purple;

        }

        private void tbID_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBID.Text = null;
            tBID.ForeColor = Color.Black;
        }

        private void tbSumma_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBSumma.Text = null;
            tBSumma.ForeColor = Color.Black;
        }

        private void tbidAb_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBidAb.Text = null;
            tBidAb.ForeColor = Color.Black;
        }

        private void tbID_Leave(object sender, EventArgs e) //происходит когда элемент перестаёт быть активным
        {
            if (tBID.Text == "")
            {
                tBID.Text = "ID";
                tBID.ForeColor = Color.Purple;
            }
        }

        private void tbSumma_Leave(object sender, EventArgs e) //происходит когда элемент перестаёт быть активным
        {
            if (tBSumma.Text == "")
            {
                tBSumma.Text = "Сумма долга";
                tBSumma.ForeColor = Color.Purple;
            }
        }

        private void tbidAb_Leave(object sender, EventArgs e) //происходит когда элемент перестаёт быть активным
        {
            if (tBidAb.Text == "")
            {
                tBidAb.Text = "ID Абонента";
                tBidAb.ForeColor = Color.Purple;
            }
        }


        public Boolean isDataExists()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Dolg WHERE `Dolg_Summa`= @Summa ", db.GetConnection());
            command.Parameters.Add("@Summa", MySqlDbType.VarChar).Value = tBSumma.Text;

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
            if (tBSumma.Text != "" && tBidAb.Text != "")
            {

                if (isDataExists())
                {
                    return;
                }
                DataBase db = new DataBase();

                MySqlCommand command = new MySqlCommand("INSERT INTO `Dolg`(`Dolg_Summa`,`Abonent_idAbonent`) VALUES(@Summa, @idAb);", db.GetConnection());
                command.Parameters.Add("@Summa", MySqlDbType.VarChar).Value = tBSumma.Text;
                command.Parameters.Add("@idAb", MySqlDbType.VarChar).Value = tBidAb.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные добавлены");

                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Dolg", db.GetConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dGVDolg.DataSource = table;

                    dGVDolg.Columns[0].HeaderText = "код_Долга";
                    dGVDolg.Columns[1].HeaderText = "Сумма_Долга";
                    dGVDolg.Columns[2].HeaderText = "код_Абонента";
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
            if (tBID.Text != "" && tBSumma.Text != "" && tBidAb.Text != "")
            {
                DataBase db = new DataBase();

                MySqlCommand command = new MySqlCommand("UPDATE `Dolg` SET `Dolg_Summa`= @Summa, `Abonent_idAbonent`= @idAb WHERE `idDolg` = @ID;", db.GetConnection());
                command.Parameters.Add("@Summa", MySqlDbType.VarChar).Value = tBSumma.Text;
                command.Parameters.Add("@idAb", MySqlDbType.VarChar).Value = tBidAb.Text;
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBID.Text;

                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные обновлены");
                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Dolg", db.GetConnection());

                    adapter.SelectCommand = command1;
                    adapter.Fill(table);

                    dGVDolg.DataSource = table;

                    dGVDolg.Columns[0].HeaderText = "код_Долга";
                    dGVDolg.Columns[1].HeaderText = "Сумма_Долга";
                    dGVDolg.Columns[2].HeaderText = "код_Абонента";
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
            if (tBID.Text != "" || tBSumma.Text != "" || tBidAb.Text != "")
            {
                try
                {
                    DataBase db = new DataBase();

                    MySqlCommand command = new MySqlCommand("DELETE FROM `Dolg` WHERE `idDolg` = @ID;", db.GetConnection());
                    command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBID.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные удалены");
                        DataTable table = new DataTable();

                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand command1 = new MySqlCommand("SELECT * FROM Dolg", db.GetConnection());

                        adapter.SelectCommand = command1;
                        adapter.Fill(table);

                        dGVDolg.DataSource = table;

                        dGVDolg.Columns[0].HeaderText = "код_Долга";
                        dGVDolg.Columns[1].HeaderText = "Сумма_Долга";
                        dGVDolg.Columns[2].HeaderText = "код_Абонента";
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
            
            
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Dolg WHERE CONCAT(`idDolg`, `Dolg_Summa`, `Abonent_idAbonent`)like'%" + textBoxSearch.Text + "%';", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dGVDolg.DataSource = table;

            dGVDolg.Columns[0].HeaderText = "код_Долга";
            dGVDolg.Columns[1].HeaderText = "Сумма_Долга";
            dGVDolg.Columns[2].HeaderText = "код_Абонента";
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

    }
}
