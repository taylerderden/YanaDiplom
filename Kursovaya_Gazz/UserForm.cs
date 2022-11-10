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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovaya_Gazz
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            MySqlCommand command = new MySqlCommand("INSERT INTO `Pokazanie` (`Pokazanie_Previous`,`Pokazanie_Current`, `Pokazanie_Data`, `Pokazanie_SchetchikNomer`) VALUES(@PP, @PC, @PD, @PSN); ", db.GetConnection());

            command.Parameters.Add("@PP", MySqlDbType.VarChar).Value = tBPrevious.Text;
            command.Parameters.Add("@PC", MySqlDbType.VarChar).Value = tBCurrent.Text;
            command.Parameters.Add("@PD", MySqlDbType.VarChar).Value = tBDate.Text;
            command.Parameters.Add("@PSN", MySqlDbType.VarChar).Value = tBSchetchik.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Данные добавлены!");
            else
                MessageBox.Show("Ошибка!");
            
            db.closeConnection();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthorizationForm fForm = new AuthorizationForm();
            fForm.Show();
        }
    }
}
