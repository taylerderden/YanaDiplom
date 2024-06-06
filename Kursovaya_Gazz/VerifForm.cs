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
    public partial class VerifForm : Form
    {

        private MySqlCommandBuilder sqlBuilder = null;

        private MySqlDataAdapter adapter = new MySqlDataAdapter();

        private DataSet dataSet = null;

        private bool newRowAdding = false;

        public VerifForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            DataBase db = new DataBase();
            try
            {
                adapter = new MySqlDataAdapter("SELECT *, 'Delete' AS Действия FROM `Authorization`", db.GetConnection());

                sqlBuilder = new MySqlCommandBuilder(adapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                adapter.Fill(dataSet, "Authorization");

                dataGridView1.DataSource = dataSet.Tables["Authorization"];
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, i] = linkCell;
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
                dataSet.Tables["Authorization"].Clear();

                adapter.Fill(dataSet, "Authorization");

                dataGridView1.DataSource = dataSet.Tables["Authorization"];

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();

                    dataGridView1[7, i] = linkCell;
                }

            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VerifForm_Load(object sender, EventArgs e)
        {
            LoadData();

            dataGridView1.Columns[0].HeaderText = "код_Авторизации";
            dataGridView1.Columns[1].HeaderText = "Логин";
            dataGridView1.Columns[2].HeaderText = "Пароль";
            dataGridView1.Columns[3].HeaderText = "Категория";
            dataGridView1.Columns[4].HeaderText = "код_Абонента";
            dataGridView1.Columns[5].HeaderText = "Верификация";
            dataGridView1.Columns[6].HeaderText = "Почта";

            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;
            dataGridView1.Columns[5].ReadOnly = false;
            dataGridView1.Columns[6].ReadOnly = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    string task = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

                    if (task == "Delete")
                    {
                        try
                        {
                            if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                int rowIndex = e.RowIndex;

                                dataGridView1.Rows.RemoveAt(rowIndex);
                                dataSet.Tables["Authorization"].Rows[rowIndex].Delete();

                                adapter.Update(dataSet, "Authorization");
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Удалите данные из дочерних таблиц!");
                        }
                    }
                    else if (task == "Insert")
                    {
                        int rowIndex = dataGridView1.Rows.Count - 2;

                        DataRow row = dataSet.Tables["Authorization"].NewRow();

                        row["idAuthorization"] = dataGridView1.Rows[rowIndex].Cells["idAuthorization"].Value;
                        row["Authorization_Login"] = dataGridView1.Rows[rowIndex].Cells["Authorization_Login"].Value;
                        row["Authorization_Password"] = dataGridView1.Rows[rowIndex].Cells["Authorization_Password"].Value;
                        row["Authorization_Category"] = dataGridView1.Rows[rowIndex].Cells["Authorization_Category"].Value;
                        row["Abonent_idAbonent"] = dataGridView1.Rows[rowIndex].Cells["Abonent_idAbonent"].Value;
                        row["Authorization_Verify"] = dataGridView1.Rows[rowIndex].Cells["Authorization_Verify"].Value;
                        row["Authorization_Email"] = dataGridView1.Rows[rowIndex].Cells["Authorization_Verify"].Value;

                        dataSet.Tables["Authorization"].Rows.Add(row);

                        dataSet.Tables["Authorization"].Rows.RemoveAt(dataSet.Tables["Authorization"].Rows.Count - 1);

                        dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);

                        dataGridView1.Rows[e.RowIndex].Cells[7].Value = "Delete";

                        adapter.Update(dataSet, "Authorization");

                        newRowAdding = false;
                    }
                    else if (task == "Update")
                    {
                        int r = e.RowIndex;

                        dataSet.Tables["Authorization"].Rows[r]["idAuthorization"] = dataGridView1.Rows[r].Cells["idAuthorization"].Value;
                        dataSet.Tables["Authorization"].Rows[r]["Authorization_Login"] = dataGridView1.Rows[r].Cells["Authorization_Login"].Value;
                        dataSet.Tables["Authorization"].Rows[r]["Authorization_Password"] = dataGridView1.Rows[r].Cells["Authorization_Password"].Value;
                        dataSet.Tables["Authorization"].Rows[r]["Authorization_Category"] = dataGridView1.Rows[r].Cells["Authorization_Category"].Value;
                        dataSet.Tables["Authorization"].Rows[r]["Abonent_idAbonent"] = dataGridView1.Rows[r].Cells["Abonent_idAbonent"].Value;
                        dataSet.Tables["Authorization"].Rows[r]["Authorization_Verify"] = dataGridView1.Rows[r].Cells["Authorization_Verify"].Value;
                        dataSet.Tables["Authorization"].Rows[r]["Authorization_Email"] = dataGridView1.Rows[r].Cells["Authorization_Email"].Value;

                        adapter.Update(dataSet, "Authorization");

                        dataGridView1.Rows[e.RowIndex].Cells[7].Value = "Delete";
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

                    dataGridView1[7, lastRow] = linkCell;

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

                    dataGridView1[7, rowIndex] = linkCell;

                    editingRow.Cells["Действия"].Value = "Update";
                }
            }
            catch (Exception exep)
            {
                MessageBox.Show(exep.Message, "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)        //метод чтоб можно было писать только +
        {
            if (e.KeyChar != '+' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            if (dataGridView1.CurrentCell.ColumnIndex == 5)         //на месте _5_ ставим индекс колонки который валидируем
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                    textBox.MaxLength = 1;
                }
            }
        }
    }
}
