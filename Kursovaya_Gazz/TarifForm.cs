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
        }

    }
}
