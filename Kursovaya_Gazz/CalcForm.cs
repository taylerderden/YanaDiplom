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
using Word = Microsoft.Office.Interop.Word;

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
            textBoxBezDolga.Text = null;
            textBoxDlg.Text = null;
            textBoxSDolgom.Text = null;

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

                //поиск даты показаний
                DataTable tableD = new DataTable();
                MySqlCommand commandD = new MySqlCommand("SELECT `Pokazanie_Data` FROM `Pokazanie` " +
                    "WHERE `Abonent_idAbonent` = @ID AND `Pokazanie_Current` = (SELECT MAX(Pokazanie_Current) FROM `Pokazanie` WHERE `Abonent_idAbonent` = @ID); ", db.GetConnection());
                commandD.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Abonent;

                adapter.SelectCommand = commandD;
                adapter.Fill(tableD);

                if (tableD.Rows.Count > 0) //поиск записей
                {
                    textBoxDate.Text = commandD.ExecuteScalar().ToString();
                }
                else
                    MessageBox.Show("Данные по дате показаний не найдены, введите их вручную!");

                //расчет оплаты
                DataTable tablePL = new DataTable();
                MySqlCommand commandPL = new MySqlCommand("SELECT (`Pokazanie_Calc` * `Tarif_Price`) * `Lgota_Koefficent` AS `Platezh` FROM `Pokazanie`, `Tarif`, `Lgota`, `Abonent`" +
                    " WHERE `Abonent_FIO` = @AF and `idTarif` = @Tid and `idLgota` = @Lid and `Abonent_idAbonent` = @Aid and `Pokazanie_Data` = @PD;", db.GetConnection());

                commandPL.Parameters.Add("@AF", MySqlDbType.VarChar).Value = textBoxFIO.Text;
                commandPL.Parameters.Add("@PD", MySqlDbType.VarChar).Value = textBoxDate.Text;
                commandPL.Parameters.Add("@Tid", MySqlDbType.VarChar).Value = Tarif;
                commandPL.Parameters.Add("@Lid", MySqlDbType.VarChar).Value = Lgota;
                commandPL.Parameters.Add("@Aid", MySqlDbType.VarChar).Value = Abonent;

                adapter.SelectCommand = commandPL;
                adapter.Fill(tablePL);

                if (tablePL.Rows.Count > 0) //поиск записей
                {
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");// смена на точку                      
                    
                    var bezDlg = commandPL.ExecuteScalar().ToString();                  
                    textBoxBezDolga.Text = Convert.ToString(Math.Round((Convert.ToDouble(bezDlg)),2));

                    DataTable tableS = new DataTable();

                    MySqlCommand commandS = new MySqlCommand("SELECT `Dolg_Summa` FROM Dolg WHERE `Abonent_idAbonent` = @Aid;", db.GetConnection());

                    commandS.Parameters.Add("@AF", MySqlDbType.VarChar).Value = textBoxFIO.Text;
                    commandS.Parameters.Add("@bDlg", MySqlDbType.VarChar).Value = textBoxBezDolga.Text;
                    commandS.Parameters.Add("@Aid", MySqlDbType.VarChar).Value = Abonent;

                    adapter.SelectCommand = commandS;
                    adapter.Fill(tableS);

                    if (tableS.Rows.Count > 0) //поиск записей
                    {
                        var Dlg = commandS.ExecuteScalar().ToString();  // извлекаем 
                        textBoxDlg.Text = Dlg;
                        double res = double.Parse(textBoxDlg.Text) + double.Parse(textBoxBezDolga.Text);// конвертируем тбоксы в дабл
                        textBoxSDolgom.Text = Convert.ToString(res);
                    }
                    else
                        MessageBox.Show("Данные по долгу не найдены!"); //иначе ошибка                                             
                }
                else
                    MessageBox.Show("Выбранная дата показаний не найдена, введите корректную дату!"); //иначе ошибка                              
            }
            else
                MessageBox.Show("Клиент не найден!"); //иначе ошибка

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

        private readonly string TemplateFileName = @"C:\Users\1\Desktop\primer.docx";
        private void btnWord_Click(object sender, EventArgs e)
        {
            var FIO = textBoxFIO.Text;
            var Date = textBoxDate.Text;
            var BezD = textBoxBezDolga.Text;
            var Dlg = textBoxDlg.Text;
            var Sdlg = textBoxSDolgom.Text;

            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                /*
                 *  ST00012|Name= ЗЛОБИН ДАНИИЛ СЕРГЕЕВИЧ|
                    PersonalAcc=40817810795010005796|
                    BankName=Газпромбанк|
                    BIC=046577903|
                    CorrespAcc=30101810200000000903|
                    KPP=000001001|
                    PayeelNN=666001947022|
                    Purpose=За газ|Sum=1
                 */
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{FIO}", FIO, wordDocument);
                ReplaceWordStub("{Date}", Date, wordDocument);
                ReplaceWordStub("{BezD}", BezD, wordDocument);
                ReplaceWordStub("{Dlg}", Dlg, wordDocument);
                ReplaceWordStub("{Sdlg}", Sdlg, wordDocument);
                
                wordDocument.SaveAs(@"C:\Users\1\Desktop\kvitok.docx");
                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Ошибка экспорта в Word!");
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value.ToShortDateString();
        }
    }
    
}
