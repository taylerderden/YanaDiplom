using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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
            MySqlCommand command = new MySqlCommand("INSERT INTO `Pokazanie` (`Pokazanie_Previous`,`Pokazanie_Current`, `Pokazanie_Data`, `Pokazanie_SchetchikNomer`, `Abonent_idAbonent`, `Pokazanie_Calc`) VALUES(@PP, @PC, @PD, @PSN, @AA, (`Pokazanie_Current`-`Pokazanie_Previous`)); ", db.GetConnection());

            command.Parameters.Add("@PP", MySqlDbType.VarChar).Value = tBPrevious.Text;
            command.Parameters.Add("@PC", MySqlDbType.VarChar).Value = tBCurrent.Text;
            command.Parameters.Add("@PD", MySqlDbType.VarChar).Value = tbDate.Text;
            command.Parameters.Add("@PSN", MySqlDbType.VarChar).Value = tBSchetchik.Text;
            command.Parameters.Add("@AA", MySqlDbType.VarChar).Value = tBid.Text;

            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Данные добавлены!");
            else
                MessageBox.Show("Ошибка!");
            
            db.closeConnection();           
        }
        public static DateTime GetNetworkTime()  //получение времени из сети
        {
            const string ntpServer = "time.windows.com";
            var ntpData = new byte[48];
            ntpData[0] = 0x1B;

            var addresses = Dns.GetHostEntry(ntpServer).AddressList;
            var ipEndPoint = new IPEndPoint(addresses[0], 123);

            using (var socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
            {
                socket.Connect(ipEndPoint);
                socket.Send(ntpData);
                socket.Receive(ntpData);
                socket.Close();
            }

            var intPart = (ulong)ntpData[40] << 24 | (ulong)ntpData[41] << 16 | (ulong)ntpData[42] << 8 | ntpData[43];
            var fractPart = (ulong)ntpData[44] << 24 | (ulong)ntpData[45] << 16 | (ulong)ntpData[46] << 8 | ntpData[47];

            var milliseconds = (intPart * 1000) + ((fractPart * 1000) / 0x100000000L);
            var networkDateTime = (new DateTime(1900, 1, 1, 0, 0, 0, DateTimeKind.Utc)).AddMilliseconds((long)milliseconds);

            return networkDateTime.ToLocalTime();
        }
        private void UserForm_Load(object sender, EventArgs e)
        {
            //tBid.Text = Global.GlobalVar;

            tbDate.Text = Convert.ToString(GetNetworkTime().ToShortDateString());

            DataBase db = new DataBase();
            DataTable tablePP = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand commandPP = new MySqlCommand("SELECT max(Pokazanie_Current) FROM Pokazanie WHERE Abonent_idAbonent = @ID", db.GetConnection());
            commandPP.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = commandPP;
            adapter.Fill(tablePP);

            db.openConnection();
            if (tablePP.Rows.Count > 0) //поиск записей
            {
                tBPrevious.Text = commandPP.ExecuteScalar().ToString();
            }
            db.closeConnection();

            DataTable tableS = new DataTable();
            MySqlDataAdapter adapterS = new MySqlDataAdapter();

            MySqlCommand commandS = new MySqlCommand("SELECT Pokazanie_SchetchikNomer FROM Pokazanie WHERE Abonent_idAbonent = @ID", db.GetConnection());
            commandS.Parameters.Add("@ID", MySqlDbType.VarChar).Value = Global.GlobalVar;

            adapter.SelectCommand = commandS;
            adapter.Fill(tableS);

            db.openConnection();
            if (tableS.Rows.Count > 0) //поиск записей
            {
                tBSchetchik.Text = commandS.ExecuteScalar().ToString();
            }
            db.closeConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthorizationForm fForm = new AuthorizationForm();
            fForm.Show();
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
