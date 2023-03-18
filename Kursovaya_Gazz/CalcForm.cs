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
using Microsoft.Reporting.WinForms;
using QRCoder;
using System.IO;
using System.Drawing.Imaging;

namespace Kursovaya_Gazz
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        String Adress;
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

                //лиц счет
                MySqlCommand commandSch = new MySqlCommand("SELECT `Abonent_Schet` FROM `Abonent` WHERE `Abonent_FIO` = @AF;", db.GetConnection());
                commandSch.Parameters.Add("@AF", MySqlDbType.VarChar).Value = textBoxFIO.Text;
                DataTable tableSch = new DataTable();

                adapter.SelectCommand = commandSch;
                adapter.Fill(tableSch);

                if (tableSch.Rows.Count > 0) //поиск записей по счету
                {
                    tBSchet.Text = commandSch.ExecuteScalar().ToString();
                }
                else
                    MessageBox.Show("Данные по счету не найдены!");

                //адрес
                MySqlCommand commandAdr = new MySqlCommand("SELECT `Abonent_Adress` FROM `Abonent` WHERE `Abonent_FIO` = @AF;", db.GetConnection());
                commandAdr.Parameters.Add("@AF", MySqlDbType.VarChar).Value = textBoxFIO.Text;
                DataTable tableAdr = new DataTable();

                adapter.SelectCommand = commandAdr;
                adapter.Fill(tableAdr);

                if (tableAdr.Rows.Count > 0) //поиск записей по адресу
                {
                    Adress = commandAdr.ExecuteScalar().ToString();
                }
                else
                    MessageBox.Show("Данные по адресу не найдены!");

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
                    {
                        textBoxDlg.Text = "0";
                        textBoxSDolgom.Text = textBoxBezDolga.Text;
                        MessageBox.Show("Данные по долгу не найдены!"); //иначе ошибка
                    }    
                                                                     
                }
                else
                    MessageBox.Show("Выбранная дата показаний не найдена, введите корректную дату!"); //иначе ошибка                              
            }
            else
                MessageBox.Show("Введите данные действующего клиента!"); //иначе ошибка

            db.closeConnection();
        }
     
        private void btnWord_Click(object sender, EventArgs e)
        {
            /*ST00012|Name= ФИО|
              PersonalAcc=40817810795010005796|
              BankName=Газпромбанк|
              BIC=046577903|
              CorrespAcc=30101810200000000903|
              KPP=000001001|
              PayeelNN=666001947022|
              Purpose=За газ|Sum=1                               
            */
            if (textBoxFIO.Text == ""  || textBoxDate.Text == "" || textBoxBezDolga.Text == ""
                || textBoxDlg.Text == "" || textBoxSDolgom.Text == "" || tBSchet.Text == "")
            {
                MessageBox.Show("Введите данные действующего клиента!");
            }
            else
            {
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("pFIO", textBoxFIO.Text));
                reportParameters.Add(new ReportParameter("pDatePokazanie", textBoxDate.Text));
                reportParameters.Add(new ReportParameter("pBezDolga", textBoxBezDolga.Text));
                reportParameters.Add(new ReportParameter("pDolg", textBoxDlg.Text));
                reportParameters.Add(new ReportParameter("pItogo", textBoxSDolgom.Text));
                reportParameters.Add(new ReportParameter("pSchet", tBSchet.Text));
                reportParameters.Add(new ReportParameter("pAdress", Adress));

                KvitokForm kvitokForm = new KvitokForm();
                double itogo = Convert.ToDouble(textBoxSDolgom.Text) * 100;
                string qr = $"ST00012|Name= РОГОЖНИКОВА ЯНА ОЛЕГОВНА|PersonalAcc = 40817810795010005796 |BankName = Газпромбанк |BIC = 046577903 |CorrespAcc = 30101810200000000903 |KPP = 000001001 |PayeelNN = 666001947022 |Purpose = За газ | Sum = {itogo}";
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(qr, QRCodeGenerator.ECCLevel.Q);
                QRCode qRCode = new QRCode(qRCodeData);
                Bitmap bmp = qRCode.GetGraphic(50);
                using (MemoryStream ms = new MemoryStream())
                {
                    bmp.Save(ms, ImageFormat.Bmp);
                    DataQR dataQR = new DataQR();
                    DataQR.QRCodeRow qRCodeRow = dataQR.QRCode.NewQRCodeRow();
                    qRCodeRow.Image = ms.ToArray();
                    dataQR.QRCode.AddQRCodeRow(qRCodeRow);

                    ReportDataSource reportDataSource = new ReportDataSource();
                    reportDataSource.Name = "DataQR";
                    reportDataSource.Value = dataQR.QRCode;

                    kvitokForm.reportViewer1.LocalReport.DataSources.Clear();
                    kvitokForm.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                    kvitokForm.reportViewer1.RefreshReport();
                }

                kvitokForm.Show();
                kvitokForm.reportViewer1.LocalReport.SetParameters(reportParameters);
                kvitokForm.reportViewer1.RefreshReport();
            }          
        }
        private void CalcForm_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}
