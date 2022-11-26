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
    public partial class PokazanieForm : Form
    {
        public PokazanieForm()
        {
            InitializeComponent();
        }

        private void PokazanieForm_Load(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Pokazanie", db.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dGVPokazanie.DataSource = table;

            dGVPokazanie.Columns[0].HeaderText = "код_Показаний";
            dGVPokazanie.Columns[1].HeaderText = "Предыдущие_показания";
            dGVPokazanie.Columns[2].HeaderText = "Текущие_показания";
            dGVPokazanie.Columns[3].HeaderText = "Дата_показаний";
            dGVPokazanie.Columns[4].HeaderText = "Номер_счётчика";
            dGVPokazanie.Columns[5].HeaderText = "код_Абонента";
            dGVPokazanie.Columns[6].HeaderText = "Расчёт";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tBID.Text != "" || tBPrev.Text != "" || tBCur.Text != "" || tBDate.Text != "" || tBSch.Text != "" || tBidAb.Text != "" || tBCalc.Text != "")
            {
                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                MySqlCommand command = new MySqlCommand("SELECT * FROM Pokazanie WHERE `idPokazanie` = @ID OR`Pokazanie_Previous`= @PP OR `Pokazanie_Current`= @PC OR `Pokazanie_Data`= @PD OR `Abonent_idAbonent`= @idAb OR `Pokazanie_Calc`= @Calc;", db.GetConnection());
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBID.Text;
                command.Parameters.Add("@PP", MySqlDbType.VarChar).Value = tBPrev.Text;
                command.Parameters.Add("@PC", MySqlDbType.VarChar).Value = tBCur.Text;
                command.Parameters.Add("@PD", MySqlDbType.VarChar).Value = tBDate.Text;
                command.Parameters.Add("@PSN", MySqlDbType.VarChar).Value = tBSch.Text;
                command.Parameters.Add("@idAb", MySqlDbType.VarChar).Value = tBidAb.Text;
                command.Parameters.Add("@Calc", MySqlDbType.VarChar).Value = tBCalc.Text;               

                adapter.SelectCommand = command;
                adapter.Fill(table);

                dGVPokazanie.DataSource = table;

                dGVPokazanie.Columns[0].HeaderText = "код_Показаний";
                dGVPokazanie.Columns[1].HeaderText = "Предыдущие_показания";
                dGVPokazanie.Columns[2].HeaderText = "Текущие_показания";
                dGVPokazanie.Columns[3].HeaderText = "Дата_показаний";
                dGVPokazanie.Columns[4].HeaderText = "Номер_счётчика";
                dGVPokazanie.Columns[5].HeaderText = "код_Абонента";
                dGVPokazanie.Columns[6].HeaderText = "Расчёт";
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
