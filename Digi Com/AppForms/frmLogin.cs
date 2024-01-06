using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace Digi_Com.AppForms
{
    public partial class frmLogin : Form
    {
        DB _db = new DB();
        SerialPort port;
        SerialPortManager portManager;
        private static string _MessageFromDevice = null;
        private static int _userfpid = 0;
        public frmLogin()
        {
            InitializeComponent();
            Global.GlobalVar = "any string value";
            // Bind combobox to dictionary
            //Dictionary<string, string> test = new Dictionary<string, string>();
            //test.Add("3002", "3002");
            //test.Add("3003", "3003");
            //test.Add("3004", "3004");
            //test.Add("3005", "3005");
            //test.Add("3006", "3006");
            //test.Add("3007", "3007");
            ////test.Add("COM6", "COM6");


            //cmbcomPort.DataSource = new BindingSource(test, null);
            //cmbcomPort.DisplayMember = "Value";
            //cmbcomPort.ValueMember = "Key";

            //cmbTransPort.DataSource = new BindingSource(test, null);
            //cmbTransPort.DisplayMember = "Value";
            //cmbTransPort.ValueMember = "Key";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            getComPorts();


            //Thread.Sleep(5000);
            //port.Write("90");

            cmbStation.DisplayMember = "STATION_NAME";
            cmbStation.ValueMember = "STATION_CODE";
            cmbStation.DataSource = _db.getStationList();
            cmbStation.SelectedIndex = -1;
            MinimizeBox = true;
            MaximizeBox = true;
        }

        private void afterAuthSuccess(int FPID)
        {

            try
            {
                Global.User = _db.getUserInfoByFPID(FPID).Rows[0];
                _db.setLastLoginTime();
                Form _frmDashboard = new frmDashboard(this);
                Global.FPCOMPORT = cmbcomPort.SelectedItem.ToString();
                Global.MyStationID = cmbStation.SelectedValue.ToString();
                Global.TrnsComPort = cmbTransPort.SelectedItem.ToString();


                Global.personel_fingre_key_no = Global.User["PERSONEL_FINGRE_KEY_NO"].ToString();

                _db.writeLog("User " + Global.User["PERSONEL_NAME"].ToString() + " log in.");
                _frmDashboard.Show();

                this.Hide();
                //Global.User = _db.getUserInfoByFPID(FPID).Rows[0];
                //_db.setLastLoginTime();
                //Form _frmDashboard = new frmDashboard(this);
                //Global.FPCOMPORT = "3003".ToString();//cmbcomPort.SelectedItem.ToString();
                //Global.MyStationID = cmbStation.SelectedValue.ToString();
                //Global.TrnsComPort = "3005".ToString();//cmbTransPort.SelectedItem.ToString();
                //_db.writeLog("User " + Global.User["PERSONEL_NAME"].ToString() + " log in.");
                //_frmDashboard.Show();

                //this.Hide();
            }
            catch(Exception ex)
            {
                // MessageBox.Show("User Not Registred");
                MessageBox.Show(ex.Message);
            }

        }

        void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           
            string messageFromArduino = string.Empty;

            try
            {
                btnLogin.BeginInvoke(new Action(delegate () { this.btnLogin.Text = "Please Wait.."; }));
                messageFromArduino = port.ReadLine(); // read response from hardware
                // Console.Write(port.ReadLine());
                lblStatus.BeginInvoke(new Action(delegate () { this.lblStatus.Text = messageFromArduino; }));
                if (messageFromArduino.Trim() == "Found fingerprint sensor!")
                {
                   
                    port.Write("90");
                    btnLogin.BeginInvoke(new Action(delegate () { this.btnLogin.Text ="Place your finger!"; }));
                }

                string pattern = @"#\b\d+?\b#";
                string input = messageFromArduino;
                Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                if (m.Success)
                {
                     btnLogin.BeginInvoke(new Action(delegate () { this.btnLogin.Text ="Place your finger!"; }));
                 
                    this.BeginInvoke(new Action(delegate () {
                        port.Close();
                        afterAuthSuccess(_userfpid);

                    }));
                    _userfpid = Convert.ToInt32(m.Value.Replace("#", ""));
                    // afterAuthSuccess(Convert.ToInt32(m.Value.Replace("#", "")));

                    //MessageBox.Show("User Found: " + m.Value.Replace("#", ""));
                    
                }


                Console.WriteLine(messageFromArduino.Trim());
                //string pattern = @"\bF1\w*\b";
             
                // Console.Write(messageFromArduino);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.InnerException.Message);
            }


            _MessageFromDevice += messageFromArduino;


            //   textBoxIncoming.Dispatcher.BeginInvoke(new Action(delegate () { this.textBoxIncoming.Text += messageFromArduino; }));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (_userfpid != 0)
            {               
                afterAuthSuccess(_userfpid);
              
            }
         
        }

        private void getComPorts()
        {
            string[] portNames = SerialPort.GetPortNames();     //<-- Reads all available comPorts
            foreach (var portName in portNames)
            {
                cmbcomPort.Items.Add(portName);                  //<-- Adds Ports to combobox
                cmbTransPort.Items.Add(portName);                  //<-- Adds Ports to combobox
            }
            cmbcomPort.SelectedIndex = -1;
            cmbTransPort.SelectedIndex = -1;

        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
           
            try
            {
                if (cmbStation.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select your station", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbStation.Focus();
                    return;
                }

                if (cmbcomPort.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select Scanner port.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbcomPort.Focus();
                    return;
                }
                if (cmbTransPort.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select Transmitter port.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbTransPort.Focus();
                    return;
                }
                if (cmbTransPort.SelectedIndex == cmbcomPort.SelectedIndex)
                {
                    MessageBox.Show("Scanner Transmitter port can't be same!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbTransPort.Focus();
                    return;
                }
                btnLogin.Enabled = false;
                portManager = new SerialPortManager();
                port = portManager.OpenPort(cmbcomPort.SelectedItem.ToString());
                port.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);

                
                if (!port.IsOpen) port.Open();
                //btnLogin.Enabled = false;
                //portManager = new SerialPortManager();
                //port = portManager.OpenPort(cmbcomPort.SelectedItem.ToString());
                //port = portManager.OpenPort("3002".ToString());
                //port.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
                //if (!port.IsOpen) port.Open();

                //afterAuthSuccess(4);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,Application.ProductName,MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
