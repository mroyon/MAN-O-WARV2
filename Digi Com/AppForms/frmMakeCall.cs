using NAudio.CoreAudioApi;
using NAudio.Wave;
using NAudio.Wave.Compression;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Digi_Com.AppForms
{
    public partial class frmMakeCall : Form
    {
        private string browseFileName;
        private SoundPlayer Sound;
        private DB _db = new DB();
        private Common _common = new Common();
        private IWavePlayer wavePlayer;
        private IWaveIn captureDevice;
        private AudioFileReader audioFileReader;
        private WaveFileWriter writer;
        private SerialPort comFP, comTR;
        private string DestinationStation = null;
        private string outputFilename;
        private readonly string outputFolder;
        string StationName;
        private string fileName;

        public frmMakeCall(SerialPort comFP, SerialPort comTR)
        {
            InitializeComponent();

            this.comTR = comTR;
            this.comFP = comFP;
            outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "DGCOM Recordings");

            Directory.CreateDirectory(outputFolder);
        }
        public class ListBoxItem
        {
            public string Text { get; set; }
            public object Tag { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }
        private void LoadStationList()
        {


            int i = 0;

            foreach (DataRow row in _db.getStationList().Rows)
            {

                ListBoxItem item = new ListBoxItem();
                item.Tag = row["STATION_CODE"].ToString();
                item.Text = row["STATION_NAME"].ToString();
                chkListStations.Items.Add(item);


                i++;
            }

         


        }

        private void frmMakeCall_Load(object sender, EventArgs e)
        {
            EnableButtons(false);
            LoadStationList();
            LoadWaveInDevicesCombo();
            LoadWasapiDevicesCombo();

        
           
        }


        private void LoadWaveInDevicesCombo()
        {
            var devices = Enumerable.Range(-1, WaveIn.DeviceCount + 1).Select(n => WaveIn.GetCapabilities(n)).ToArray();

            comboWaveInDevice.DataSource = devices;
            comboWaveInDevice.DisplayMember = "ProductName";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            fileName = Common.SelectInputFile();
            Global.filename = fileName;
            if (fileName != null)
            {
                btnPlay.Enabled = true;
                btnPlay.Text = "Play";
                btnSendFile.Enabled = true;
                btnSendFile.Text = "Call And Send File";

            }
            else
            {
                btnSendFile.Enabled = false;
                btnSendFile.Text = "Busy....";
                MessageBox.Show("You must select a file & a Station");
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (fileName != null && btnPlay.Text == "Play")
            {
                btnPlay.Text = "Stop";
                BeginPlayback(fileName);
            }
            else
            {
                btnPlay.Text = "Play";
                wavePlayer.Stop();
            }

        }


        private void BeginPlayback(string filename)
        {

            wavePlayer = new WaveOut();
            audioFileReader = new AudioFileReader(filename);
            audioFileReader.Volume = volumeSlider1.Volume;
            wavePlayer.Init(audioFileReader);
            wavePlayer.PlaybackStopped += OnPlaybackStopped;
            wavePlayer.Play();
            EnableButtons(true);
            timer1.Enabled = true; // timer for updating current time label
        }

        private void volumeSlider1_VolumeChanged(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                audioFileReader.Volume = volumeSlider1.Volume;
            }
        }

        void OnPlaybackStopped(object sender, StoppedEventArgs e)
        {
            // we want to be always on the GUI thread and be able to change GUI components
            Debug.Assert(!InvokeRequired, "PlaybackStopped on wrong thread");

            EnableButtons(false);
            timer1.Enabled = false;
            labelNowTime.Text = "00:00";
            btnPlay.Text = "Play";
            if (e.Exception != null)
            {
                MessageBox.Show(String.Format("Playback Stopped due to an error {0}", e.Exception.Message));
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (audioFileReader != null)
            {
                labelNowTime.Text = Common.FormatTimeSpan(audioFileReader.CurrentTime);
                int Tsecond = audioFileReader.TotalTime.Seconds;
                int Rsecond = audioFileReader.CurrentTime.Seconds;

                int Tmin = (int)audioFileReader.TotalTime.TotalMinutes;
                int Cmin = (int)audioFileReader.CurrentTime.TotalMinutes;
                int second = Tsecond - Rsecond;
                int min = Tmin - Cmin;


                labelTotalTime.Text = Common.FormatTimeSpan(audioFileReader.TotalTime);
            }
        }

        private void CleanUp()
        {
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            if (wavePlayer != null)
            {
                wavePlayer.Dispose();
                wavePlayer = null;
            }
        }

        private void EnableButtons(bool playing)
        {
            btnBrowse.Enabled = !playing;
            if (playing)
            {
                btnPlay.Text = "Stop";

            }
            else
            {
                btnPlay.Text = "Play";
            }

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            fileName = Common.SelectInputFile();
            if (fileName != null)
            {
                btnPlay.Enabled = true;
                wavePlayer.Stop();
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (fileName == null) fileName = Common.SelectInputFile();
            if (fileName != null)
            {
                BeginPlayback(fileName);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            wavePlayer.Stop();
        }

        private void btnRecordAudio_Click(object sender, EventArgs e)
        {





            if (captureDevice == null)
            {
                captureDevice = CreateWaveInDevice();
            }
            // Forcibly turn on the microphone (some programs (Skype) turn it off).
            var device = (MMDevice)comboWasapiDevices.SelectedItem;
            device.AudioEndpointVolume.Mute = false;

            outputFilename = GetFileName();
            writer = new WaveFileWriter(Path.Combine(outputFolder, outputFilename), captureDevice.WaveFormat);
            captureDevice.StartRecording();

            btnRecordAudio.Enabled = false;
            btnStopRecording.Enabled = true;


            //string text = "Hello World!";

            //using (var bob = new DiffieHellman())
            //{
            //    using (var alice = new DiffieHellman())
            //    {
            //        // Bob uses Alice's public key to encrypt his message.
            //        byte[] secretMessage = bob.Encrypt(alice.PublicKey, text);

            //        // Alice uses Bob's public key and IV to decrypt the secret message.
            //        string decryptedMessage = alice.Decrypt(bob.PublicKey, secretMessage, bob.IV);
            //    }
            //}
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            if (wavePlayer != null)
            {
                wavePlayer.Stop();
            }
            this.Close();
        }

        private IWaveIn CreateWaveInDevice()
        {
            IWaveIn newWaveIn;
            if (radioButtonWaveIn.Checked)
            {
                var deviceNumber = comboWaveInDevice.SelectedIndex - 1;

                newWaveIn = new WaveIn() { DeviceNumber = deviceNumber };

                var sampleRate = 8000;
                var channels = 1;
                newWaveIn.WaveFormat = new WaveFormat(sampleRate, channels);
            }
            else
            {
                // can't set WaveFormat as WASAPI doesn't support SRC
                var device = (MMDevice)comboWasapiLoopbackDevices.SelectedItem;
                newWaveIn = new WasapiLoopbackCapture(device);
            }
            newWaveIn.DataAvailable += OnDataAvailable;
            newWaveIn.RecordingStopped += OnRecordingStopped;
            return newWaveIn;

        }
        private void LoadWasapiDevicesCombo()
        {
            var deviceEnum = new MMDeviceEnumerator();
            var devices = deviceEnum.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active).ToList();

            comboWasapiDevices.DataSource = devices;
            comboWasapiDevices.DisplayMember = "FriendlyName";

            var renderDevices = deviceEnum.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToList();
            comboWasapiLoopbackDevices.DataSource = renderDevices;
            comboWasapiLoopbackDevices.DisplayMember = "FriendlyName";

        }
        private string GetFileName()
        {
            var deviceName = captureDevice.GetType().Name;
            var sampleRate = $"{captureDevice.WaveFormat.SampleRate / 1000}kHz";
            var channels = captureDevice.WaveFormat.Channels == 1 ? "mono" : "stereo";

            return $"{deviceName} {sampleRate} {channels} {DateTime.Now:yyy-MM-dd HH-mm-ss}.wav";
        }

        void OnRecordingStopped(object sender, StoppedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<StoppedEventArgs>(OnRecordingStopped), sender, e);
            }
            else
            {
                FinalizeWaveFile();
                progressBar1.Value = 0;
                if (e.Exception != null)
                {
                    MessageBox.Show(String.Format("A problem was encountered during recording {0}",
                                                  e.Exception.Message));
                }

                fileName = outputFolder+"\\"+outputFilename;
                EncodeAudioFile();
             


                //int newItemIndex = listBoxRecordings.Items.Add(outputFilename);
                //listBoxRecordings.SelectedIndex = newItemIndex;
                // SetControlStates(false);
            }
        }

        void OnDataAvailable(object sender, WaveInEventArgs e)
        {
            if (InvokeRequired)
            {
                //Debug.WriteLine("Data Available");
                BeginInvoke(new EventHandler<WaveInEventArgs>(OnDataAvailable), sender, e);
            }
            else
            {
                //Debug.WriteLine("Flushing Data Available");
                writer.Write(e.Buffer, 0, e.BytesRecorded);
                int secondsRecorded = (int)(writer.Length / writer.WaveFormat.AverageBytesPerSecond);
                if (secondsRecorded >= 30)
                {
                    StopRecording();
                }
                else
                {
                    progressBar1.Value = secondsRecorded;
                }
            }
        }
        void StopRecording()
        {
            Debug.WriteLine("StopRecording");
            captureDevice?.StopRecording();
            btnStopRecording.Enabled = false;
            btnRecordAudio.Enabled = true;
        }

        private void FinalizeWaveFile()
        {
            writer?.Dispose();
            writer = null;
        }

        private void btnStopRecording_Click(object sender, EventArgs e)
        {
            StopRecording();
        }

        private void EncodeAudioFile()
        {
            try
            {
                string inputFileName = fileName;
                if (inputFileName == null)
                    return;
                using (var reader = new WaveFileReader(inputFileName))
                {
                    if (reader.WaveFormat.Encoding != WaveFormatEncoding.Pcm)
                    {
                        MessageBox.Show("Please select a PCM WAV file to encode");
                        return;
                    }

                    WaveFormat targetFormat = GetTargetFormat(reader.WaveFormat);
                    if (targetFormat == null)
                    {
                        return;
                    }
                    string outputFileName = outputFolder + "\\Conv_" + outputFilename;
                    if (outputFileName == null)
                    {
                        return;
                    }
                    using (WaveStream convertedStream = new WaveFormatConversionStream(targetFormat, reader))
                    {
                        WaveFileWriter.CreateWaveFile(outputFileName, convertedStream);

                        fileName = outputFileName;
                        Global.filename = outputFileName;
                        btnPlay.Enabled = true;
                        btnSendFile.Enabled = true;
                        btnSendFile.Text = "Call And Send File";
                    }
                   
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Encoding", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private WaveFormat GetTargetFormat(WaveFormat inputFormat)
        {
            WaveFormat outputFormat;
            string formatDescription;
            string formatTagDescription;
            AcmDriver.ShowFormatChooseDialog(
                Handle,
                "Select Compressed Format:",
                AcmFormatEnumFlags.Convert,
                inputFormat,
                out outputFormat,
                out formatDescription,
                out formatTagDescription);
            return outputFormat;
        }

        private void pbMakeCall_Click(object sender, EventArgs e)
        {
           

           
        }

        private void chkListStations_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (int ix = 0; ix < chkListStations.Items.Count; ++ix)
                if (ix != e.Index) chkListStations.SetItemChecked(ix, false);


            if(chkListStations.SelectedItems.Count > 0)
            {
            

                DestinationStation = ((ListBoxItem)chkListStations.SelectedItems[0]).Tag.ToString();
                StationName= ((ListBoxItem)chkListStations.SelectedItems[0]).Text;
            }
            else
            {
                DestinationStation = null;
            }

           
            if (DestinationStation != null)
            {
                btnPlay.Enabled = true;
            
                btnSendFile.Enabled = true;
                btnSendFile.Text = "Call And Send File";

            }
            else
            {
                btnSendFile.Enabled = false;
                MessageBox.Show("You must select a file & a Station");
            }


        }

        private void timerResponse_Tick(object sender, EventArgs e)
        {
            btnSendFile.Enabled = true;
            btnSendFile.Text = "Call And Send File";
            if (!Global.isCallReceived)
            {
                MessageBox.Show("No response from Receipent!");
                _db.writeLog("No response from " + StationName + " Station");
            }
          
            timerResponse.Stop();
            
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            //Send Write File to COM Port

            if (fileName != null && DestinationStation != null)
            {
                Global.isCallReceived = false;
                btnSendFile.Enabled = false;
                btnSendFile.Text = "Busy...";
                timerResponse.Start();
                _db.writeLog("Outgoing Call To Station " +StationName);
                comTR.WriteLine("101#" + Global.MyStationID+ DestinationStation);
                Global.isCaller = true;
            }
            {
                if (fileName == null)
                {
                    MessageBox.Show("You must select a file");
                }
                if (DestinationStation == null)
                {
                    MessageBox.Show("You Must select a Destination Station");
                }
            }

             

        }
    }
}
