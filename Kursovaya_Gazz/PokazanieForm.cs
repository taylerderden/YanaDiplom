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

            tBIDp.Text = "Код показаний";                //подсказка
            tBIDp.ForeColor = Color.Purple;

            tBPrev.Text = "Предыдущие показания";                //подсказка
            tBPrev.ForeColor = Color.Purple;

            tBCur.Text = "Текущие показания";                //подсказка
            tBCur.ForeColor = Color.Purple;

            tBData.Text = "Дата показаний";                //подсказка
            tBData.ForeColor = Color.Purple;

            tBSchN.Text = "Номер счётчика";                //подсказка
            tBSchN.ForeColor = Color.Purple;

            tBidAb.Text = "Код абонента";                //подсказка
            tBidAb.ForeColor = Color.Purple;

            tBCalc.Text = "Расчёт";                //подсказка
            tBCalc.ForeColor = Color.Purple;
        }

        private void tBIDp_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBIDp.Text = null;
            tBIDp.ForeColor = Color.Black;
        }

        private void tBPrev_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBPrev.Text = null;
            tBPrev.ForeColor = Color.Black;
        }

        private void tBCur_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBCur.Text = null;
            tBCur.ForeColor = Color.Black;
        }

        private void tBData_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBData.Text = null;
            tBData.ForeColor = Color.Black;
        }

        private void tBSchN_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBSchN.Text = null;
            tBSchN.ForeColor = Color.Black;
        }

        private void tBidAb_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBidAb.Text = null;
            tBidAb.ForeColor = Color.Black;
        }

        private void tBCalc_Enter(object sender, EventArgs e)//происходит когда элемент стает активным
        {
            tBCalc.Text = null;
            tBCalc.ForeColor = Color.Black;
        }

        private void tBIDp_Leave(object sender, EventArgs e) // происходит когда элемент перестаёт быть активным
        {
            if (tBIDp.Text == "")
            {
                tBIDp.Text = "Код показаний";
                tBIDp.ForeColor = Color.Purple;
            }
        }

        private void tBPrev_Leave(object sender, EventArgs e) //происходит когда элемент перестаёт быть активным
        {
            if (tBPrev.Text == "")
            {
                tBPrev.Text = "Предыдущие показания";
                tBPrev.ForeColor = Color.Purple;
            }
        }

        private void tBCur_Leave(object sender, EventArgs e) //происходит когда элемент перестаёт быть активным
        {
            if (tBCur.Text == "")
            {
                tBCur.Text = "Текущие показания";
                tBCur.ForeColor = Color.Purple;
            }
        }

        private void tBData_Leave(object sender, EventArgs e) // происходит когда элемент перестаёт быть активным
        {
            if (tBData.Text == "")
            {
                tBData.Text = "Дата показаний";
                tBData.ForeColor = Color.Purple;
            }
        }

        private void tBSchN_Leave(object sender, EventArgs e) //происходит когда элемент перестаёт быть активным
        {
            if (tBSchN.Text == "")
            {
                tBSchN.Text = "Номер счётчика";
                tBSchN.ForeColor = Color.Purple;
            }
        }

        private void tBidAb_Leave(object sender, EventArgs e) //происходит когда элемент перестаёт быть активным
        {
            if (tBidAb.Text == "")
            {
                tBidAb.Text = "Код абонента";
                tBidAb.ForeColor = Color.Purple;
            }
        }

        private void tBCalc_Leave(object sender, EventArgs e) //происходит когда элемент перестаёт быть активным
        {
            if (tBCalc.Text == "")
            {
                tBCalc.Text = "Расчёт";
                tBCalc.ForeColor = Color.Purple;
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (tBIDp.Text == "" || tBIDp.Text == "Код показаний" && tBPrev.Text == "" || tBPrev.Text == "Предыдущие показания" && tBCur.Text == "" || tBCur.Text == "Текущие показания" && tBData.Text == "" || tBData.Text == "Дата показаний" && tBSchN.Text == "" || tBSchN.Text == "Номер счётчика" && tBidAb.Text == "" || tBidAb.Text == "Код абонента" && tBCalc.Text == "" || tBCalc.Text == "Расчёт")
            {
                MessageBox.Show("Введите данные для обновления!");
            }
            else
            {
                DataBase db = new DataBase();

                MySqlCommand command = new MySqlCommand("UPDATE `Pokazanie` SET `Pokazanie_Previous`= @Pr, `Pokazanie_Current`= @Cr, `Pokazanie_Data`= @Data, `Pokazanie_SchetchikNomer`= @Sch, `Abonent_idAbonent`= @IDAb, `Pokazanie_Calc`= @Cal WHERE `idPokazanie` = @ID;", db.GetConnection());
                command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBIDp.Text;
                command.Parameters.Add("@Pr", MySqlDbType.VarChar).Value = tBPrev.Text;
                command.Parameters.Add("@Cr", MySqlDbType.VarChar).Value = tBCur.Text;
                command.Parameters.Add("@Data", MySqlDbType.VarChar).Value = tBData.Text;
                command.Parameters.Add("@Sch", MySqlDbType.VarChar).Value = tBSchN.Text;
                command.Parameters.Add("@IDAb", MySqlDbType.VarChar).Value = tBidAb.Text;
                command.Parameters.Add("@Cal", MySqlDbType.VarChar).Value = tBCalc.Text;
                db.openConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Данные обновлены");
                    DataTable table = new DataTable();

                    MySqlDataAdapter adapter = new MySqlDataAdapter();

                    MySqlCommand command1 = new MySqlCommand("SELECT * FROM Pokazanie", db.GetConnection());

                    adapter.SelectCommand = command1;
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
                    MessageBox.Show("Ошибка!");

                db.closeConnection();
            }    
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tBIDp.Text == "" || tBIDp.Text == "Код показаний")
            {
                MessageBox.Show("Введите ID показаний для удаления!");
            }
            else
            {
                try
                {
                    DataBase db = new DataBase();

                    MySqlCommand command = new MySqlCommand("DELETE FROM `Pokazanie` WHERE `idPokazanie` = @ID;", db.GetConnection());
                    command.Parameters.Add("@ID", MySqlDbType.VarChar).Value = tBIDp.Text;

                    db.openConnection();

                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Данные удалены");
                        DataTable table = new DataTable();

                        MySqlDataAdapter adapter = new MySqlDataAdapter();

                        MySqlCommand command1 = new MySqlCommand("SELECT * FROM Pokazanie", db.GetConnection());

                        adapter.SelectCommand = command1;
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
                        MessageBox.Show("Ошибка!");

                    db.closeConnection();
                }
                catch (Exception exep)
                {
                    MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
                
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

        private void tBidAb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void tBIDp_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
