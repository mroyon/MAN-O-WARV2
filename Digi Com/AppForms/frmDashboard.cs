
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using WMPLib;

namespace Digi_Com.AppForms
{
    public partial class frmDashboard : Form
    {
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);
        DB _db = new DB();
        FileStream FS;
        SerialPort Scport;
        SerialPort Trport;
        SerialPortManager portManager;
        WindowsMediaPlayer wplayer;
        Cryptography security = new Cryptography();
        bool blockOtherSession = false;
        string curentOnGoingStation = null;
        string newIncoingStation = null;
        private readonly string outputFolder;

        Form login = null;

        private string outputFilename;

        byte[] receivedByte = null;

        double receivedLength;
        bool _isReceiving = false;
        bool isCaller = false;
        public frmDashboard(Form frmlogin)
        {
            InitializeComponent();
            outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "DGCOM Recordings/");
            login = frmlogin;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            _db.writeLog("User " + Global.User["PERSONEL_NAME"].ToString() + " log out.");

            //if (!Scport.IsOpen)
            //{
            //    Scport.Open();
            //    Thread.Sleep(1000);
            //    Scport.WriteLine("90");
            //    Scport.Close();

            //}
            Application.ExitThread();




        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

            setStaticValues();
            AssignAdminRole();
            _db.loadTodaysFreqAndSecret();

            dtFromDate.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            dtToDate.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));

            lblTodayFreq.Text = Global.TodaysFrequency;
            _loadLogs();

            wplayer = new WindowsMediaPlayer();



            portManager = new SerialPortManager();

            //Scanner Port
            Scport = portManager.OpenPort(Global.FPCOMPORT);
            Scport.DataReceived += new SerialDataReceivedEventHandler(ScPort_DataReceived);

            //Tr POrt
            Trport = portManager.OpenPort(Global.TrnsComPort);
            Trport.DataReceived += new SerialDataReceivedEventHandler(TrPort_DataReceived);
            if (!Trport.IsOpen) Trport.Open();

        }

        private void btnScheduleManager_Click(object sender, EventArgs e)
        {
            Form _frmScheduleManager = new AppForms.frmScheduleManager();
            _frmScheduleManager.ShowDialog();
        }

        private void btnStationManager_Click(object sender, EventArgs e)
        {
            Form _frmStationManager = new AppForms.frmStationManager();
            _frmStationManager.ShowDialog();
        }

        private void btnUserManager_Click(object sender, EventArgs e)
        {
            Form _frmUserManager = new AppForms.frmUserManager();
            _frmUserManager.ShowDialog();
        }

        private void getStationCount()
        {
            lblTotalStation.Text = _db.getStationCount().ToString();
        }

        private void setStaticValues()
        {
            lblLastLogin.Text = Global.User["PERSONEL_LAST_LOGIN"].ToString();
            lblUsername.Text = "Welcome " + Global.User["PERSONEL_NAME"].ToString();

            lblUsername.Text += " | " + _db.getStationByStationCode(Global.MyStationID);
            getStationCount();
        }

        private void btnMakeCall_Click(object sender, EventArgs e)
        {
            frmAuth authfrm = new frmAuth();
            authfrm.Type = 2;
            authfrm.ShowDialog();
            if (authfrm.AuthPass)
            {
                Form _frmMakeCall = new frmMakeCall(Scport, Trport);
                _frmMakeCall.ShowDialog();



            }
            else
            {
                MessageBox.Show("You are not Authorized!");
            }


        }

        private void AssignAdminRole()
        {
            if (Convert.ToInt32(Global.User["PERSONEL_USER_ROLE_ID"].ToString()) == 1)
            {
                btnScheduleManager.Enabled = true;
                btnStationManager.Enabled = true;
                btnUserManager.Enabled = true;
            }
            else
            {
                btnScheduleManager.Enabled = false;
                btnStationManager.Enabled = false;
                btnUserManager.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void ScPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            //    string messageFromArduino = string.Empty;

            //    try
            //    {
            //        btnLogin.BeginInvoke(new Action(delegate () { this.btnLogin.Text = "Please Wait.."; }));
            //        messageFromArduino = port.ReadLine();
            //        // Console.Write(port.ReadLine());
            //        lblStatus.BeginInvoke(new Action(delegate () { this.lblStatus.Text = messageFromArduino; }));
            //        if (messageFromArduino.Trim() == "Found fingerprint sensor!")
            //        {

            //            port.Write("90");
            //            btnLogin.BeginInvoke(new Action(delegate () { this.btnLogin.Text = "Place your finger!"; }));
            //        }

            //        string pattern = @"#\b\d+?\b#";
            //        string input = messageFromArduino;
            //        Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
            //        if (m.Success)
            //        {
            //            btnLogin.BeginInvoke(new Action(delegate () { this.btnLogin.Text = "Place your finger!"; }));

            //            this.BeginInvoke(new Action(delegate () {
            //                port.Close();
            //                afterAuthSuccess(_userfpid);

            //            }));
            //            _userfpid = Convert.ToInt32(m.Value.Replace("#", ""));
            //            //afterAuthSuccess(Convert.ToInt32(m.Value.Replace("#", "")));

            //            //MessageBox.Show("User Found: " + m.Value.Replace("#", ""));

            //        }


            //        Console.WriteLine(messageFromArduino.Trim());
            //        //string pattern = @"\bF1\w*\b";

            //        // Console.Write(messageFromArduino);
            //    }
            //    catch (Exception exc)
            //    {
            //        MessageBox.Show(exc.InnerException.Message);
            //    }


            //    _MessageFromDevice += messageFromArduino;



            //   textBoxIncoming.Dispatcher.BeginInvoke(new Action(delegate () { this.textBoxIncoming.Text += messageFromArduino; }));
        }

        void TrPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string messageFromArduino = string.Empty;

            try
            {
                if (!_isReceiving)
                {
                    messageFromArduino = Trport.ReadLine();
                    Console.Write(messageFromArduino);
                }




                #region Pattern 000#00
                string pattern = @"^\d{3}#\d{4}#\d+#.+#\d+";
                //string pattern = @"\d{3}#\d{4}#\d+#\[.*\]";
                string input = messageFromArduino;
                Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);


                if (m.Success)
                {

                    string str = m.Value;
                    string[] tokens = str.Split('#');

                    string code = tokens[0]; //Response Code
                    string SecondPart = tokens[1];
                    string CallerID = SecondPart.Substring(0, 2); // Caller ID
                    string Receiver = SecondPart.Substring(2, 2);


                    string caller_personel_fingre_key_no = tokens[2];
                    string GenKey = tokens[3];

                    Global.GenKey = GenKey;
                    Global.callerFingerID = caller_personel_fingre_key_no;

                    Global.fileByteLength = long.Parse(tokens[4]);

                    Console.WriteLine("Response Code: " + code);
                    Console.WriteLine("Response Caller ID: " + CallerID);


                    #region Code 101 When There is an Incoming Call
                    if (Convert.ToInt32(code) == 101 && Receiver == Global.MyStationID)
                    {

                        _db.writeLog("Incoming call from " + _db.getStationByStationCode(CallerID.ToString()));
                        _db.writeLog("Incoming Secrate Key " + Global.GenKey);
                        //Invoke Main Thread and Update Info to UI
                        //Verify Receiver
                        this.BeginInvoke(new Action(delegate ()
                        {
                            //Incoming Call
                            wplayer.URL = "ringtone.mp3";
                            wplayer.controls.play();
                            wplayer.settings.setMode("loop", true);


                            txtDisplay.Visible = true;
                            txtDisplay.Text = "Incoming call from " + _db.getStationByStationCode(CallerID.ToString());
                            //Verification Completed
                            frmAuth authfrm = new frmAuth();
                            authfrm.Type = 1;
                            authfrm.ShowDialog();
                            if (authfrm.AuthPass)
                            {
                                wplayer.controls.stop();

                                if (authfrm.Resposne == 1)
                                {
                                    //When Call Accepted
                                    wplayer.URL = "accept.mp3";
                                    wplayer.controls.play();
                                    wplayer.settings.setMode("loop", false);


                                    //Send Call Accepted Resoonse to the Caller
                                    Trport.WriteLine("300#" + Global.MyStationID + "00" + "#" + Global.callerFingerID + "#" + Global.GenKey + "#" + Global.fileByteLength.ToString());
                                    txtDisplay.Text = "Creating Session.......";
                                    Global.isCaller = false;
                                }
                                else
                                {
                                    //Call Rejected
                                    wplayer.URL = "CallDrop.mp3";
                                    wplayer.controls.play();
                                    wplayer.settings.setMode("loop", false);
                                    //Send Call Rejected Code to Caller
                                    Trport.WriteLine("100#" + Global.MyStationID + "00" + "#" + Global.callerFingerID + "#" + Global.GenKey + "#" + Global.fileByteLength.ToString());

                                }

                            }

                        }));//Invoke Main Thread End


                    }

                    #endregion

                    #region Code 100 | When Call Rejected By Ohter Party

                    //When Call Rejected by Other Party
                    if (Convert.ToInt32(code) == 100)
                    {
                        Global.isCallReceived = true;

                        //  this.BeginInvoke(new Action(delegate () { _db.PlayRingTone(false); }));
                        _db.writeLog("Call rejected by  " + _db.getStationByStationCode(CallerID.ToString()));
                        wplayer.controls.stop();
                        wplayer.URL = "CallDrop.mp3";
                        wplayer.controls.play();
                        wplayer.settings.setMode("loop", false);

                        this.BeginInvoke(new Action(delegate ()
                        {
                            txtDisplay.Text = "Call rejected by  " + _db.getStationByStationCode(CallerID.ToString());
                        }
                        ));


                    }
                    #endregion

                    #region Code 300 | When Other Party Accept Call
                    if (Convert.ToInt32(code) == 300)
                    {

                        Global.isCallReceived = true;
                        Global.ReceivedCallerID = CallerID.ToString();
                        _db.writeLog("Call accepted by  " + CallerID.ToString());
                        this.BeginInvoke(new Action(delegate ()
                        {
                            txtDisplay.Text = "Recipient Accepted Your Call";
                            txtDisplay.Text = "\r\nCreating Session.....";
                        }));

                        //Now Generate Value of P & G to Recipient

                        //Now I will send my Public Key to the Recipient
                        Trport.WriteLine(String.Format("303#" + Global.MyStationID + "00" + "#" + Global.callerFingerID + "#" + Global.GenKey + "#" + Global.fileByteLength.ToString())); //Sending My Public Key


                    }
                    #endregion

                    #region Code 304 | Ready To Receive/Send File
                    if (Convert.ToInt32(code) == 304)
                    {
                        this.BeginInvoke(new Action(delegate ()
                        {
                            if (Global.isCaller)
                            {
                                txtDisplay.Text += "\r\nReady Send File";
                                txtDisplay.ScrollToCaret();
                                Thread.Sleep(500);
                                Trport.WriteLine("305#" + Global.MyStationID + "00" + "#" + Global.callerFingerID + "#" + Global.GenKey);
                            }
                        }
                        ));
                    }
                    #endregion

                    #region Code 305 | Ready To Reveive
                    if (Convert.ToInt32(code) == 305)
                    {
                        this.BeginInvoke(new Action(delegate ()
                        {
                            txtDisplay.Text = "\r\nReady To Receive File";
                            txtDisplay.ScrollToCaret();
                            //File Me File
                            Trport.WriteLine("306#" + Global.MyStationID + "00" + "#" + Global.callerFingerID + "#" + Global.GenKey);
                        }
                        ));
                    }
                    #endregion

                    #region Code 306 | Sending Files
                    if (Convert.ToInt32(code) == 306)
                    {
                        //Write File Send Code Here
                        if (Global.filename != null)
                        {
                            //Trport.WriteLine("307#10");
                            Thread.Sleep(2000);

                            //ronty clean up
                            string newEncFileName = security.FileEncrypt(Global.filename, Global.GenKey);
                            // To increase the security of the encryption, delete the given password from the memory !
                            Thread.Sleep(1000);
                            //byte[] bytes = File.ReadAllBytes(Global.filename + ".aes");
                            byte[] bytes = File.ReadAllBytes(newEncFileName);

                            Global.fileByteLength = bytes.Length;
                            Thread.Sleep(1000);
                            Trport.WriteLine("500#" + Global.MyStationID + "00" + "#" + Global.callerFingerID + "#" + Global.GenKey);
                            Thread.Sleep(100);
                            byte[] b2 = new byte[2048];
                            //Array.Copy(bytes, bytes.Length / 2, b1, 0, b1.Length);
                            int i;

                            // Console.WriteLine(bytes.Length/2);
                            //for (i = 0; i < bytes.Length; i = i + 2048)
                            for (i = 0; i < bytes.Length; i = i + 18432) // 18KB
                            {
                                int d = bytes.Length - i;
                                if (d < 2046)
                                {
                                    Array.Copy(bytes, i, b2, 0, d);
                                    Trport.Write(b2, 0, d);

                                }
                                else
                                {
                                    Array.Copy(bytes, i, b2, 0, b2.Length);
                                    Trport.Write(b2, 0, b2.Length);
                                    Thread.Sleep(100);
                                }

                                //serialPort1.Write(b1, 0, b1.Length);
                            }

                            this.BeginInvoke(new Action(delegate ()
                            {
                                if (Global.isCaller)
                                {
                                    txtDisplay.Text = "File send successfully!";
                                    txtDisplay.ScrollToCaret();

                                }



                            }
                       ));
                        }


                    }
                    #endregion

                    #region Code 307 | Sending Completed
                    if (Convert.ToInt32(code) == 307)
                    {

                        _isReceiving = true;


                    }
                    #endregion

                }


                #endregion

                #region Pattern 000#00#000000
                //Pattern for Match XXX#XX#XXXXXXn
                string patternFor3Hash = @"^\d{3}#\d{4}#\d+#.+#\d+";

                //string patternFor3Hash = @"^\d{3}#\d{4}#\d+#.+";
                //string patternFor3Hash = @"\d{3}#\d{4}#\d*";
                Match m3 = Regex.Match(input, patternFor3Hash, RegexOptions.IgnoreCase);

                if (m3.Success)
                {

                    string[] tokens = m3.Value.Split('#');

                    string code = tokens[0];

                    string SecondPart = tokens[1];
                    string CallerID = SecondPart.Substring(0, 2); // Caller ID
                    string Receiver = SecondPart.Substring(2, 2);

                    string Response = tokens[2];



                    #region Code 303 | Store Bob's Key & Generate Secret Key
                    if (Convert.ToInt32(code) == 303)
                    {

                        this.BeginInvoke(new Action(delegate ()
                        {
                            txtDisplay.Text = "Session Created.";
                            txtDisplay.Text += "\r\nSecret Key: " + Global.GenKey;
                            txtDisplay.ScrollToCaret();

                            Trport.WriteLine("304#" + Global.MyStationID + "00" + "#" + Global.callerFingerID + "#" + Global.GenKey);
                        }
                        ));
                    }
                    #endregion

                    #region Code 500 | Get Length
                    if (Convert.ToInt32(code) == 500)
                    {
                        //Store Value for P
                        //fulllength = Convert.ToDouble(Global.fileByteLength);
                        Console.WriteLine("Full Length: " + Global.fileByteLength.ToString());

                        _isReceiving = true;

                        this.BeginInvoke(new Action(delegate ()
                        {
                            txtDisplay.Text = "Receiving.........";
                            txtDisplay.ScrollToCaret();
                            wplayer.URL = "downloading.mp3";
                            wplayer.controls.play();
                            wplayer.settings.setMode("loop", true);
                        }
                  ));

                        outputFilename = outputFolder + $"Receive {DateTime.Now:yyy-MM-dd HH-mm-ss}.wav";

                    }

                    #endregion

                }
                Thread.Sleep(3000);
                #endregion
                if (_isReceiving)
                {
                    Thread.Sleep(2000);
                    int bytes = Trport.BytesToRead;
                    byte[] byte_buffer = new byte[bytes];
                    Trport.Read(byte_buffer, 0, bytes);
                    Display(byte_buffer);


                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.InnerException.Message);
            }

        }
        public void Display(byte[] inputData)
        {
            Thread.Sleep(3000);

            // textBox1.Invoke(new DelegateDispla,y(showdata), inputData);

            try
            {

                Global.byteArrayList.Add(inputData);



                using (FS = new FileStream(outputFilename + ".aes", FileMode.Append, FileAccess.Write))
                {
                    receivedLength = receivedLength + inputData.Length;

                    FS.Write(inputData, 0, inputData.Length);


                    if (receivedLength == Global.fileByteLength)
                    {
                        FS.Close();

                        // Decrypt the file
                        //ronty
                        security.FileDecrypt(outputFilename + ".aes", outputFilename);


                        _isReceiving = false;
                        receivedLength = 0;
                        Global.fileByteLength = 0;
                        _db.writeLog("FIle Received.");
                        this.BeginInvoke(new Action(delegate ()
                        {
                            txtDisplay.Text = "File Received!";
                            txtDisplay.ScrollToCaret();
                            // btnPlayMessage.Enabled = true;
                            wplayer.controls.stop();
                            wplayer.settings.setMode("loop", false);
                            //When Call Accepted
                            wplayer.URL = "fileReceived.mp3";
                            wplayer.controls.play();
                            wplayer.settings.setMode("loop", false);
                        }
                       ));
                    }

                    // return true;
                }
                playAudio();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception caught in process: {0}", ex);
                //  return false;
            }
        }

        private void frmDashboard_Activated(object sender, EventArgs e)
        {
            _db.loadTodaysFreqAndSecret();
            _loadLogs();
            lblTodayFreq.Text = Global.TodaysFrequency;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (dtFromDate.Value > dtToDate.Value)
            {
                MessageBox.Show("Invalid Export Date Range!");
            }
            else
            {
                _db.exportLog(dtFromDate.Value.ToString("yyyy-MM-dd"), dtToDate.Value.ToString("yyyy-MM-dd"));
            }
        }

        private void bunifuSwitch1_Click(object sender, EventArgs e)
        {
            if (bunifuSwitch1.Value)
            {
                if (!Trport.IsOpen) Trport.Open();
                lblTrMessage.Visible = false;
            }
            else
            {
                if (Trport.IsOpen) Trport.Close();
                lblTrMessage.Visible = true;
            }
        }

        private void btnPlayMessage_Click(object sender, EventArgs e)
        {
            playAudio();
        }
        // Play Audio
        public void playAudio()
        {
            outputFilename = outputFilename.TrimEnd(outputFilename.Last());
            if (File.Exists(outputFilename))
            {
                wplayer.URL = outputFilename;
                wplayer.controls.play();
                wplayer.settings.setMode("loop", false);

            }
            else
            {
                btnPlayMessage.Enabled = false;
            }
        }

        private void panelTopbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _loadLogs()
        {



            lvLogs.BeginUpdate();
            lvLogs.Items.Clear();
            try
            {
                DataTable _data = _db.getLogs();
                foreach (DataRow row in _data.Rows)
                {

                    ListViewItem item = new ListViewItem();
                    item.Text = row["logid"].ToString();
                    item.SubItems.Add(row["logtime"].ToString());
                    item.SubItems.Add(row["logtext"].ToString());
                    lvLogs.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lvLogs.EndUpdate();
                lvLogs.Refresh();
            }

        }

    }
}

