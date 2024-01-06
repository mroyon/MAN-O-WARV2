using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digi_Com
{

    public  class SerialPortManager
    {

        private SerialPort comPort;
        private static string _MessageFromDevice=null;

        public SerialPort OpenPort(string PortName, int rate=9600)
        {
            comPort = new SerialPort(PortName, 9600, Parity.None, 8, StopBits.One);
            comPort.DtrEnable = true;
            return comPort;
            //comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);
           
            
        }

        public void EnableVerifyMode()
        {
            if (!comPort.IsOpen) comPort.Open();

            Thread.Sleep(2000);
                comPort.Write("90");
            
           
        }
        void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (!comPort.IsOpen) comPort.Open();
            string messageFromArduino = string.Empty;

            try
            {
                messageFromArduino = comPort.ReadExisting();
                Console.Write(messageFromArduino);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.InnerException.Message);
            }


            _MessageFromDevice += messageFromArduino;
            

            //   textBoxIncoming.Dispatcher.BeginInvoke(new Action(delegate () { this.textBoxIncoming.Text += messageFromArduino; }));
        }

    }
}