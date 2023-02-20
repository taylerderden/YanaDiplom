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

        private void tBID_TextChanged(object sender, EventArgs e)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM Pokazanie WHERE CONCAT(`idPokazanie`, `Pokazanie_Previous`, `Pokazanie_Current`, `Pokazanie_Data`, `Abonent_idAbonent`, `Pokazanie_Calc`)like'%" + tBID.Text + "%';", db.GetConnection());

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
    }
}
