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
    public partial class AbonentForm : Form
    {
        private MySqlConnection sqlConnection = null;

        private MySqlCommandBuilder sqlBuilder = null;

        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        private DataSet dataSet = null;

        private bool newRowAdding = false;

        public AbonentForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataBase db = new DataBase();
            try
            {
                adapter = new MySqlDataAdapter("SELECT *, 'Delete' AS Действия FROM `Abonent`", db.GetConnection());

                sqlBuilder = new MySqlCommandBuilder(adapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                adapter.Fill(dataSet, "Abonent");

                dataGridView1.DataSource = dataSet.Tables["Abonent"];
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[8, i] = linkCell;
                }

            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReloadData()
        {
            DataBase db = new DataBase();
            try
            {
                dataSet.Tables["Abonent"].Clear();

                adapter.Fill(dataSet, "Abonent");

                dataGridView1.DataSource = dataSet.Tables["Abonent"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[8, i] = linkCell;
                }

            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AbonentForm_Load(object sender, EventArgs e)
        {
            LoadData();

            dataGridView1.Columns[0].HeaderText = "код_Абонента";
            dataGridView1.Columns[1].HeaderText = "Счет";
            dataGridView1.Columns[2].HeaderText = "ФИО";
            dataGridView1.Columns[3].HeaderText = "Адрес";
            dataGridView1.Columns[4].HeaderText = "Жилая площадь";
            dataGridView1.Columns[5].HeaderText = "Проживающие";
            dataGridView1.Columns[6].HeaderText = "код_Тарифа";
            dataGridView1.Columns[7].HeaderText = "код_Льготы";
        }

        private void tStBtnUpdate_Click(object sender, EventArgs e)
        {
            ReloadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;

                            dataGridView1.Rows.RemoveAt(rowIndex);
                            dataSet.Tables["Abonent"].Rows[rowIndex].Delete();

                            adapter.Update(dataSet, "Abonent");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;

                        DataRow row = dataSet.Tables["Abonent"].NewRow();

                        row["idAbonent"] = dataGridView1.Rows[rowIndex].Cells["idAbonent"].Value;
                        row["Abonent_Schet"] = dataGridView1.Rows[rowIndex].Cells["Abonent_Schet"].Value;
                        row["Abonent_FIO"] = dataGridView1.Rows[rowIndex].Cells["Abonent_FIO"].Value;
                        row["Abonent_Adress"] = dataGridView1.Rows[rowIndex].Cells["Abonent_Adress"].Value;
                        row["Abonent_Square"] = dataGridView1.Rows[rowIndex].Cells["Abonent_Square"].Value;
                        row["Abonent_People"] = dataGridView1.Rows[rowIndex].Cells["Abonent_People"].Value;
                        row["Tarif_idTarif"] = dataGridView1.Rows[rowIndex].Cells["Tarif_idTarif"].Value;
                        row["Lgota_idLgota"] = dataGridView1.Rows[rowIndex].Cells["Lgota_idLgota"].Value;

                        dataSet.Tables["Abonent"].Rows.Add(row);

                        dataSet.Tables["Abonent"].Rows.RemoveAt(dataSet.Tables["Abonent"].Rows.Count - 1);

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                        dataGridView1.Rows[e.RowIndex].Cells[8].Value = "Delete";

                        adapter.Update(dataSet, "Abonent");

                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        dataSet.Tables["Abonent"].Rows[r]["idAbonent"] = dataGridView1.Rows[r].Cells["idAbonent"].Value;
                        dataSet.Tables["Abonent"].Rows[r]["Abonent_Schet"] = dataGridView1.Rows[r].Cells["Abonent_Schet"].Value;
                        dataSet.Tables["Abonent"].Rows[r]["Abonent_FIO"] = dataGridView1.Rows[r].Cells["Abonent_FIO"].Value;
                        dataSet.Tables["Abonent"].Rows[r]["Abonent_Adress"] = dataGridView1.Rows[r].Cells["Abonent_Adress"].Value;
                        dataSet.Tables["Abonent"].Rows[r]["Abonent_Square"] = dataGridView1.Rows[r].Cells["Abonent_Square"].Value;
                        dataSet.Tables["Abonent"].Rows[r]["Abonent_People"] = dataGridView1.Rows[r].Cells["Abonent_People"].Value;
                        dataSet.Tables["Abonent"].Rows[r]["Tarif_idTarif"] = dataGridView1.Rows[r].Cells["Tarif_idTarif"].Value;
                        dataSet.Tables["Abonent"].Rows[r]["Lgota_idLgota"] = dataGridView1.Rows[r].Cells["Lgota_idLgota"].Value;

                        adapter.Update(dataSet, "Abonent");

                        dataGridView1.Rows[e.RowIndex].Cells[8].Value = "Delete";
                    }

                    ReloadData();
                }

            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;

                    int lastRow = dataGridView1.Rows.Count - 2;

                    DataGridViewRow row = dataGridView1.Rows[lastRow];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[8, lastRow] = linkCell;

                    row.Cells["Действия"].Value = "Insert";

                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = dataGridView1.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = dataGridView1.Rows[rowIndex];

                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[8, rowIndex] = linkCell;

                    editingRow.Cells["Действия"].Value = "Update";
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            if (dataGridView1.CurrentCell.ColumnIndex == 1)         //на месте _1_ ставим индекс колонки который валидируем
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }

            if (dataGridView1.CurrentCell.ColumnIndex == 6)         //на месте _6_ ставим индекс колонки который валидируем
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)        //метод на проверку можно ли в ячейку писать цифру(букву)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
