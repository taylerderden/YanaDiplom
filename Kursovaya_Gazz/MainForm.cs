using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_Gazz
{
    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
        }

        AbonentForm abonentForm = new AbonentForm();
        TarifForm tarifForm = new TarifForm();
        LgotaForm lgotaForm = new LgotaForm();
        PokazanieForm pokazanieForm = new PokazanieForm();
        DolgForm dolgForm = new DolgForm();
        AuthorizationForm fForm = new AuthorizationForm();
        CalcForm calcForm = new CalcForm();

        private void tSBtnAbonent_Click(object sender, EventArgs e)
        {
            AbonentForm abonentForm = new AbonentForm();
            abonentForm.Show();
        }

        private void tSBtnTarif_Click(object sender, EventArgs e)
        {
            TarifForm tarifForm = new TarifForm();
            tarifForm.Show();
        }

        private void tSBtnLgota_Click(object sender, EventArgs e)
        {
            LgotaForm lgotaForm = new LgotaForm();
            lgotaForm.Show();
        }

        private void tSBtnPokazanie_Click(object sender, EventArgs e)
        {
            PokazanieForm pokazanieForm = new PokazanieForm();
            pokazanieForm.Show();
        }

        private void tSBtnDolg_Click(object sender, EventArgs e)
        {
            DolgForm dolgForm = new DolgForm();
            dolgForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            abonentForm.Hide();
            tarifForm.Hide();
            lgotaForm.Hide();
            pokazanieForm.Hide();
            dolgForm.Hide();
            fForm.Show();
        }
            
        private void toolStripBtnCalc_Click(object sender, EventArgs e)
        {
            CalcForm calcForm = new CalcForm();
            calcForm.Show();
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

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelOpen_Click(object sender, EventArgs e)
        {

        }

        private void labelColla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
