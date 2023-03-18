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

        public void LoadForm(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
            f.Show();
        }

        AuthorizationForm autForm = new AuthorizationForm();
        private void tSBtnAbonent_Click(object sender, EventArgs e)
        {
            LoadForm(new AbonentForm());
        }

        private void tSBtnTarif_Click(object sender, EventArgs e)
        {
            LoadForm(new TarifForm());
        }

        private void tSBtnLgota_Click(object sender, EventArgs e)
        {
            LoadForm(new LgotaForm());
        }

        private void tSBtnPokazanie_Click(object sender, EventArgs e)
        {
            LoadForm(new PokazanieForm());
        }

        private void tSBtnDolg_Click(object sender, EventArgs e)
        {
            LoadForm(new DolgForm());
        }
            
        private void toolStripBtnCalc_Click(object sender, EventArgs e)
        {
            LoadForm(new CalcForm());
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
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            labelOpen.Visible = false;
            labelNormal.Visible = true;
        }

        private void labelColla_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tSBtnPodtv_Click(object sender, EventArgs e)
        {
            LoadForm(new VerifForm());
        }

        private void tsBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            autForm.Show();
        }

        private void labelNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            labelOpen.Visible = true;
            labelNormal.Visible = false;
        }
    }
}
