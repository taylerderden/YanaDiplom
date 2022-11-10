using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            AuthorizationForm fForm = new AuthorizationForm();
            fForm.Show();
        }
    }
}
