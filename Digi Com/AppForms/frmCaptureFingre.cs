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
    public partial class frmCaptureFingre : Form
    {

        DB _db = new DB();
        SerialPort port;
        SerialPortManager portManager;
        private string _newFPID = null;
        private static string _MessageFromDevice = null;

        public static string  _UserID ;


        public frmCaptureFingre(string USERID)
        {
            InitializeComponent();
           _UserID = USERID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (port.IsOpen)
            {
                port.Close();
            }
            this.Close();
        }

        void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string messageFromArduino = string.Empty;

            try
            {
                messageFromArduino = port.ReadLine();
                // Console.Write(port.ReadLine());
                lblStatus.BeginInvoke(new Action(delegate () { this.lblStatus.Text = messageFromArduino; }));
                if (messageFromArduino.Trim() == "Found fingerprint sensor!")
                {

                    port.Write("1");
                    Thread.Sleep(2000);
                    _newFPID = GetUserFPID().ToString();
                    port.Write(_newFPID);
                  
                }

                string pattern = @"#\b\d+?\b#";
                string input = messageFromArduino;
                Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                if (m.Success)
                {


                    //this.BeginInvoke(new Action(delegate ()
                    //{
                    //    port.Close();
                    //    afterAuthSuccess(_userfpid);

                    //}));
                    int code  = Convert.ToInt32(m.Value.Replace("#", ""));

                    _newFPID = _db.getEmptyFingreSlot().ToString();

                    if (code == 404)
                    {
                        MessageBox.Show("Fingre not matched");
                        port.Write("1");
                        Thread.Sleep(2000);
                       
                        port.Write(_newFPID);

                    }
                    if (code == 200)
                    {
                  
                        _db.UpdateUserFPIndex(Convert.ToInt32(_newFPID),Convert.ToInt32(_UserID));
                        MessageBox.Show("Fingre Stored");
                        pbFinger.BeginInvoke(new Action(delegate () { this.pbFinger.Visible = false; }));

                        port.Close();
                        this.Invoke((MethodInvoker)delegate
                        {
                            // close the form on the forms thread
                            this.Close();
                        });

                     


                    }
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


            _MessageFromDevice += messageFromArduino;



            //   textBoxIncoming.Dispatcher.BeginInvoke(new Action(delegate () { this.textBoxIncoming.Text += messageFromArduino; }));
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            portManager = new SerialPortManager();
            port = portManager.OpenPort(Global.FPCOMPORT);
            port.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);

            if (!port.IsOpen) port.Open();
            btnCapture.Enabled = false;
        }


        private int  GetUserFPID()
        {


            string _ExistFPID = _db.getUserFPIndexByUserID(Convert.ToInt32(_UserID));
             if (!string.IsNullOrEmpty(_ExistFPID))
            {
               return  Convert.ToInt32(_ExistFPID);
            }else
            {
                _newFPID = _db.getEmptyFingreSlot().ToString();
                return Convert.ToInt32(_newFPID);
            }
                
           
        }

    }
}
