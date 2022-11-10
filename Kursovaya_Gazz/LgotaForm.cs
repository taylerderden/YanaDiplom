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
        }
    }
}
