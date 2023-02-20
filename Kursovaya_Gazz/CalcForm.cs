using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya_Gazz
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }


        private void btnCalc_Click(object sender, EventArgs e)
        {
            DataBase db = new DataBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            String Tarif, Lgota, Abonent;

            MySqlCommand commandT = new MySqlCommand("SELECT `Tarif_idTarif` FROM `Abonent` WHERE `Abonent_FIO` = @AF;", db.GetConnection());
            commandT.Parameters.Add("@AF", MySqlDbType.VarChar).Value = textBoxFIO.Text;

            MySqlCommand commandL = new MySqlCommand("SELECT `Lgota_idLgota` FROM `Abonent` WHERE `Abonent_FIO` = @AF;", db.GetConnection());
            commandL.Parameters.Add("@AF", MySqlDbType.VarChar).Value = textBoxFIO.Text;

            MySqlCommand commandA = new MySqlCommand("SELECT `idAbonent` FROM `Abonent` WHERE `Abonent_FIO` = @AF;", db.GetConnection());
            commandA.Parameters.Add("@AF", MySqlDbType.VarChar).Value = textBoxFIO.Text;

            adapter.SelectCommand = commandT;
            adapter.Fill(table);

            db.openConnection();

            if (table.Rows.Count > 0) //поиск записей
            {
                Tarif = commandT.ExecuteScalar().ToString();  // извлекаем 
                Lgota = commandL.ExecuteScalar().ToString();
                Abonent = commandA.ExecuteScalar().ToString();

                MySqlCommand commandPL = new MySqlCommand("SELECT (`Pokazanie_Calc` * `Tarif_Price`) * `Lgota_Koefficent` AS `Platezh` FROM `Pokazanie`, `Tarif`, `Lgota`, `Abonent`  WHERE `Abonent_FIO` = @AF and `idTarif` = @Tid and `idLgota` = @Lid and `Abonent_idAbonent` = @Aid and `Pokazanie_Data` = @PD;", db.GetConnection());

                commandPL.Parameters.Add("@AF", MySqlDbType.VarChar).Value = textBoxFIO.Text;
                commandPL.Parameters.Add("@PD", MySqlDbType.VarChar).Value = dateTimePicker1.Text;
                commandPL.Parameters.Add("@Tid", MySqlDbType.VarChar).Value = Tarif;
                commandPL.Parameters.Add("@Lid", MySqlDbType.VarChar).Value = Lgota;
                commandPL.Parameters.Add("@Aid", MySqlDbType.VarChar).Value = Abonent;

                adapter.SelectCommand = commandPL;
                adapter.Fill(table);

                //db.openConnection();

                if (table.Rows.Count > 0) //поиск записей
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");// смена на точку

                    var bezDlg = commandPL.ExecuteScalar().ToString();
                    textBoxBezDolga.Text = bezDlg;

                    MySqlCommand commandS = new MySqlCommand("SELECT `Dolg_Summa` FROM Dolg WHERE `Abonent_idAbonent` = @Aid;", db.GetConnection());

                    commandS.Parameters.Add("@AF", MySqlDbType.VarChar).Value = textBoxFIO.Text;
                    commandS.Parameters.Add("@bDlg", MySqlDbType.VarChar).Value = textBoxBezDolga.Text;
                    commandS.Parameters.Add("@Aid", MySqlDbType.VarChar).Value = Abonent;

                    adapter.SelectCommand = commandS;
                    adapter.Fill(table);

                    //db.openConnection();

                    if (table.Rows.Count > 0) //поиск записей
                    {
                        var Dlg = commandS.ExecuteScalar().ToString();  // извлекаем 
                        textBoxDlg.Text = Dlg;
                        double res = double.Parse(textBoxDlg.Text) + double.Parse(textBoxBezDolga.Text);// конвертируем тбоксы в дабл
                        textBoxSDolgom.Text = Convert.ToString(res);
                    }
                    else
                        MessageBox.Show("Failed!"); //иначе ошибка

                }
                else
                    MessageBox.Show("Failed!"); //иначе ошибка

                //db.closeConnection();
            }
            else
                MessageBox.Show("Failed!"); //иначе ошибка

            db.closeConnection();
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
