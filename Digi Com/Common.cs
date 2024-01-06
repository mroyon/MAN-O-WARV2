using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace Digi_Com
{
    class Common
    {
        public static string SelectInputFile()
        {
            var ofd = new OpenFileDialog();
            ofd.Filter = "Audio Files|*.mp3;*.wav;*.aiff;*.wma;*.txt";
            ofd.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic), "DGCOM Recordings");


            if (ofd.ShowDialog() == DialogResult.OK)
            {
                return ofd.FileName;
            }

            return null;
        }

        public static string FormatTimeSpan(TimeSpan ts)
        {
            return string.Format("{0:D2}:{1:D2}", (int)ts.TotalMinutes, ts.Seconds);
        }

        //public static DataTable AutodetectArduinoPort()
        //{
        //    ManagementScope connectionScope = new ManagementScope();
        //    SelectQuery serialQuery = new SelectQuery("SELECT * FROM Win32_SerialPort");
        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher(connectionScope, serialQuery);
        //    searcher.fil
        //    try
        //    {

        //        DataTable dt = new DataTable();

        //        DataSet ds = new DataSet();

        //        foreach (ManagementObject item in searcher.Get())
        //        {
        //            //string desc = item["Description"].ToString();
        //            string deviceId = item["DeviceID"].ToString();
                  
        //            dt.Columns.Add("DeviceID", typeof(string));
        //        }
        //        return dt.Tables[];
        //    }
        //    catch (ManagementException e)
        //    {
        //        /* Do Nothing */
        //    }

        //    return null;
        //}

        //public DataTable getComPorts()
        //{
        //    ComboBox cmb = new ComboBox();
        //    var con = new SQLiteConnection(cs);
        //    try
        //    {


        //        con.Open();
        //        string query = "select ROLE_NAME, ROLE_ID from roles";
        //        SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);

        //        DataSet ds = new DataSet();
        //        da.Fill(ds, "Roles");

        //        return ds.Tables["Roles"];
        //    }
        //    catch (Exception ex)
        //    {

        //        return null;
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //}
    }
}
