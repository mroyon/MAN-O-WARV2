using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digi_Com.AppForms
{
    public partial class frmAuth : Form
    {
        SerialPort comFP;
        SerialPortManager portManager;
        DB _db = new DB();

        public bool AuthPass { get; set; }

        public int Type { get; set; }
        public int Resposne { get; set; }


        public frmAuth()
        {
            InitializeComponent();
        }

        private void frmAuth_Load(object sender, EventArgs e)
        {
            ConnectFPComPort();

            if (Type == 1)
            {
                btnAccept.Visible = true;
                btnReject.Visible = true;
            }else
            {
                btnAccept.Visible = false;
                btnReject.Visible = false;
            }
        }


        private void ConnectFPComPort()
        {

            portManager = new SerialPortManager();
            comFP = portManager.OpenPort(Global.FPCOMPORT);
            comFP.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
            if (!comFP.IsOpen) comFP.Open();
        }


        void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string messageFromArduino = string.Empty;

            try
            {
             
                messageFromArduino = comFP.ReadLine();
                // Console.Write(port.ReadLine());
                lblMessage.BeginInvoke(new Action(delegate () { this.lblMessage.Text = messageFromArduino; }));
                if (messageFromArduino.Trim() == "Found fingerprint sensor!")
                {

                    comFP.Write("90");
                   
                }

                string pattern = @"#\b\d+?\b#";
                string input = messageFromArduino;
                Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                if (m.Success)
                {

                    comFP.Close();
                    afterAuthSuccess(Convert.ToInt32(m.Value.Replace("#", "")));

                
                    //afterAuthSuccess(Convert.ToInt32(m.Value.Replace("#", "")));

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


         



            //   textBoxIncoming.Dispatcher.BeginInvoke(new Action(delegate () { this.textBoxIncoming.Text += messageFromArduino; }));
        }


        private void afterAuthSuccess(int FPID)
        {

            try
            {
                Global.User = _db.getUserInfoByFPID(FPID).Rows[0];
                _db.setLastLoginTime();
               
                AuthPass = true;


                if (comFP.IsOpen) comFP.Close();
                this.BeginInvoke(new Action(delegate () {

                    if (Type == 1)
                    {
                        btnAccept.Enabled = true;
                        btnReject.Enabled = true;
                        lblMessage.Text = "Please Accept or Reject the call!";
                    }
                    else
                    {
                        this.Close();
                    }


                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("User Not Registred");
                AuthPass = false;
                return ;
            }

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Global.byteArrayList = new List<byte[]>();
            Resposne = 1;
            this.Close();
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            Resposne = 0;
            this.Close();
        }
    }
}
