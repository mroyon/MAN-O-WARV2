using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Digi_Com
{
    using System;
    using System.Data;
    using System.Data.SQLite;
    using System.IO;
    using System.Numerics;
    using System.Windows.Forms;
    using WMPLib;
    //fekri
    public class DB
    {

        private string cs = String.Format(@"URI=file:{0}dgcom.dll", AppDomain.CurrentDomain.BaseDirectory);

        public bool setLastLoginTime()
        {
            var con = new SQLiteConnection(cs);
            try
            {

                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = String.Format(@"UPDATE personels SET PERSONEL_LAST_LOGIN='{0}' WHERE PERSONEL_ID={1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Global.User["PERSONEL_ID"],ToString());
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    MessageBox.Show("Station already exist for the given date", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }
            finally
            {
                con.Close();
            }

        }

        public void Insert(List<KeyValuePair<string, string>> list)
        {


            foreach (var element in list)
            {
                Console.WriteLine(element.Key);
            }
            //var dictionary = new Dictionary<string, object>();




            //var con = new SQLiteConnection(cs);
            //con.Open();

            //var cmd = new SQLiteCommand(con);


            //cmd.CommandText = @"INSERT INTO ranks(RANK_ID,RANK_NAME) VALUES(1,'A')";
            //cmd.ExecuteNonQuery();



            //Console.WriteLine("Table cars created");
        }

        //Get Rank List From Database
        public DataTable getRankList()
        {
            ComboBox cmb = new ComboBox();
            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();
                string query = "select RANK_NAME, RANK_ID from ranks";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Ranks");

                return ds.Tables["Ranks"];
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable getAllStationList()
        {

            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();
                string query = String.Format(@"select STATION_ID,STATION_CODE,STATION_NAME FROM STATIONS ");
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Station");

                return ds.Tables["Station"];
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }

        }
        public DataTable getScheduleListByDate(string displayDate)
        {

            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();
                string query = String.Format(@"SELECT SCHEDULE_ID,SCHEDULE_DATE,SCHEDULE_FREQ,SCHEDULE_SECRET FROM schedules WHERE SCHEDULE_DATE= '" + displayDate + "'");
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Schedule");

                return ds.Tables["Schedule"];
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }

        }

        //Get Pefix List From Database
        public DataTable getPrefixList()
        {
            ComboBox cmb = new ComboBox();
            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();
                string query = "select PREFIX_NAME, PREFIX_ID from prefixes";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Prefix");

                return ds.Tables["Prefix"];
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }

        //Get Role List From Database
        public DataTable getRoleList()
        {
            ComboBox cmb = new ComboBox();
            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();
                string query = "select ROLE_NAME, ROLE_ID from roles";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Roles");

                return ds.Tables["Roles"];
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }

        //Insert Personel Information
        public bool insertPersonel(string _PERSONEL_PRFIX_ID, string _PERSONEL_RANK_ID, string _PERSONEL_NAME, string _PERSONEL_ARMYNO, string _PERSONEL_USER_ROLE_ID, string _PERSONEL_MOBILE)
        {
            var con = new SQLiteConnection(cs);
            try
            {

                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = String.Format(@"INSERT INTO personels(PERSONEL_PRFIX_ID, PERSONEL_RANK_ID, PERSONEL_NAME, PERSONEL_ARMYNO, PERSONEL_USER_ROLE_ID,PERSONEL_MOBILE) VALUES
                ('{0}','{1}','{2}','{3}','{4}','{5}')", _PERSONEL_PRFIX_ID, _PERSONEL_RANK_ID, _PERSONEL_NAME, _PERSONEL_ARMYNO, _PERSONEL_USER_ROLE_ID, _PERSONEL_MOBILE);
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    MessageBox.Show("User already Exist", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }
            finally
            {
                con.Close();
            }

        }

        //Update Personel Information
        public bool updatePersonel(string _PERSONEL_ID, string _PERSONEL_PRFIX_ID, string _PERSONEL_RANK_ID, string _PERSONEL_NAME, string _PERSONEL_ARMYNO, string _PERSONEL_USER_ROLE_ID, string _PERSONEL_MOBILE)
        {
            var con = new SQLiteConnection(cs);
            try
            {

                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = String.Format(@"UPDATE personels SET PERSONEL_PRFIX_ID='{0}', PERSONEL_RANK_ID='{1}', PERSONEL_NAME='{2}', PERSONEL_ARMYNO='{3}', PERSONEL_USER_ROLE_ID='{4}',PERSONEL_MOBILE='{5}' WHERE PERSONEL_ID={6}", _PERSONEL_PRFIX_ID, _PERSONEL_RANK_ID, _PERSONEL_NAME, _PERSONEL_ARMYNO, _PERSONEL_USER_ROLE_ID, _PERSONEL_MOBILE, _PERSONEL_ID);
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    MessageBox.Show("User already Exist", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }
            finally
            {
                con.Close();
            }

        }

        //Get Personel List
        public DataTable getPersonelList()
        {

            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();
                string query = @"select PERSONEL_ID, PREFIX_NAME||'-'||PERSONEL_ARMYNO AS FULL_ARMYNO, PERSONEL_PRFIX_ID, PREFIX_NAME, RANK_NAME, PERSONEL_RANK_ID, PERSONEL_FINGRE_KEY_NO, PERSONEL_NAME, PERSONEL_ARMYNO, PERSONEL_USER_ROLE_ID, ROLE_NAME, PERSONEL_LAST_LOGIN,PERSONEL_MOBILE   from personels, prefixes, ranks, roles  WHERE  RANK_ID=PERSONEL_RANK_ID AND PREFIX_ID=PERSONEL_PRFIX_ID AND ROLE_ID=PERSONEL_USER_ROLE_ID  ORDER BY PERSONEL_ID DESC ";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Personels");

                return ds.Tables["Personels"];
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }

        }

        //Get Schedule List
        public DataTable getScheduleList(string displayDate)
        {

            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();
                string query = String.Format(@"select SCHEDULE_ID,SCHEDULE_DATE,SCHEDULE_FREQ,SCHEDULE_SECRET
 FROM schedules WHERE SUBSTR(SCHEDULE_DATE,0,8)= SUBSTR('{0}',0,8) ORDER BY SCHEDULE_DATE ASC", displayDate);
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Schedule");

                return ds.Tables["Schedule"];
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }

        }

        //Get Schedule List
        public DataTable getStationList()
        {

            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();
                string query = String.Format(@"select STATION_ID,STATION_CODE,STATION_NAME FROM STATIONS  WHERE STATION_CODE!= '"+Global.MyStationID+"' ORDER BY STATION_NAME ASC");
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Station");

                return ds.Tables["Station"];
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }

        }

        //Get Empty Finger Slot
        public int getEmptyFingreSlot()
        {

            ComboBox cmb = new ComboBox();
            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();


                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "SELECT MIN(FPSLOT_ID)slot FROM fingre_slots WHERE FLSLOT_PERSONEL_ID IS NULL";
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (!string.IsNullOrEmpty(reader["slot"].ToString()))
                    {
                        return Convert.ToInt32(reader["slot"].ToString());
                    }
                    else
                    {
                        return -1;
                    }
                }
                return -1;
            }
            catch (Exception ex)
            {
                con.Close();
                return -1;
            }
            finally
            {
                con.Close();
            }

        }

        public void deleteUserByUserid(int UserID)
        {

           
            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();


                var cmd = new SQLiteCommand(con);

                cmd.CommandText = String.Format("DELETE FROM fingre_slots WHERE FLSLOT_PERSONEL_ID='{0}'",UserID);
                cmd.ExecuteNonQuery();

                cmd.CommandText = String.Format("DELETE FROM personels WHERE PERSONEL_ID='{0}'", UserID);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                con.Close();
              
            }
            finally
            {
                con.Close();
            }

        }

        //Get User Information By Fingreprint ID
        public DataTable getUserInfoByFPID(int FPID)
        {
            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();
                string query = @"SELECT	* FROM	personels,	ranks,	prefixes,	roles WHERE	PERSONEL_FINGRE_KEY_NO =" + FPID + "	AND RANK_ID=PERSONEL_RANK_ID	AND PREFIX_ID=PERSONEL_PRFIX_ID AND ROLE_ID=PERSONEL_USER_ROLE_ID";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "User");

                return ds.Tables["User"];
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }

        //Get Personnel's FP Index

        public string getUserFPIndexByUserID(int USERID)
        {
            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();
                string query = String.Format(@"SELECT	PERSONEL_FINGRE_KEY_NO FROM	personels WHERE PERSONEL_ID={0}", USERID);
                SQLiteCommand cmd = new SQLiteCommand(query,con);
              

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    string _fp = null;
                    while (reader.Read())
                    {
                        _fp = reader["PERSONEL_FINGRE_KEY_NO"].ToString();
                       
                    }
                    return _fp;
                }
                else
                {
                    return null;
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }
        }


        public void  exportLog(string FromDate, string ToDate)
        {

            SaveFileDialog savefile = new SaveFileDialog();
            // set a default file name
            savefile.FileName = FromDate+" to "+ ToDate+".csv";
            // set filters - this can be done in properties as well
            savefile.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";




            var con = new SQLiteConnection(cs);
            try
            {

         if (savefile.ShowDialog() == DialogResult.OK)
            {
                con.Open();
                string query = String.Format(@"SELECT *  FROM logs WHERE logstation_id='{2}' AND SUBSTR(logtime,0,11) BETWEEN '{0}' AND '{1}'",FromDate,ToDate,Global.MyStationID);
                SQLiteCommand cmd = new SQLiteCommand(query, con);


                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    string _fp = null;
                    //before your loop
                    var csv = new StringBuilder();
                    var header = string.Format("Log ID,Log Time,Message");
                    csv.AppendLine(header);
                    while (reader.Read())
                    {
                        


                    

                        //in your loop
                        var logID = reader["logid"].ToString();
                        var time = reader["logtime"].ToString();
                        var message = reader["logtext"].ToString();
                        //Suggestion made by KyleMit
                        var row = string.Format("{0},{1},{2}", logID, time, message);
                        csv.AppendLine(row);

                        //after your loop
                        File.WriteAllText(savefile.FileName, csv.ToString());




                    }
                    
                }
               
               
                reader.Close();
                    MessageBox.Show("File Exported Sucessfully!");
                }
            }
            catch (Exception ex)
            {

                
            }
            finally
            {
                con.Close();
            }
        }


        public void UpdateUserFPIndex(int FPID,int UserID)
        {
            var con = new SQLiteConnection(cs);
            try
            {

                con.Open();
                var cmd = new SQLiteCommand(con);

                //Update Personel Table Finger Index
                cmd.CommandText = String.Format(@"UPDATE personels SET PERSONEL_FINGRE_KEY_NO='{0}' WHERE PERSONEL_ID={1}", FPID, UserID);
                cmd.ExecuteNonQuery();

                cmd.CommandText = String.Format(@"UPDATE fingre_slots SET FLSLOT_PERSONEL_ID='{0}' WHERE FPSLOT_ID={1}", UserID, FPID);
                cmd.ExecuteNonQuery();
               
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    MessageBox.Show("Station already exist for the given date", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

               
            }
            finally
            {
                con.Close();
            }
        }

        //Get Station Count
        public int getStationCount()
        {
            ComboBox cmb = new ComboBox();
            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();


                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "SELECT COUNT(*) count FROM stations";
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (!string.IsNullOrEmpty(reader["count"].ToString()))
                    {
                        return Convert.ToInt32(reader["count"].ToString());
                    }
                    else
                    {
                        return -1;
                    }
                }
                return -1;
            }
            catch (Exception ex)
            {
                con.Close();
                return -1;
            }
            finally
            {
                con.Close();
            }

        }


        //Insert Schedule
        public bool insertStation(string STATION_NAME, string STATION_CODE)
        {
            var con = new SQLiteConnection(cs);
            try
            {

                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = String.Format(@"INSERT INTO stations(STATION_NAME,STATION_CODE) VALUES
                ('{0}','{1}')", STATION_NAME, STATION_CODE);
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    MessageBox.Show("Station already exist!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }
            finally
            {
                con.Close();
            }
        }

        //Update Schedule
        public bool updateStation(string STATION_ID, string STATION_NAME, string STATION_CODE)
        {
            var con = new SQLiteConnection(cs);
            try
            {

                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = String.Format(@"UPDATE stations SET STATION_NAME='{0}',STATION_CODE='{1}' WHERE STATION_ID={2}", STATION_NAME, STATION_CODE, STATION_ID);
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    MessageBox.Show("Station already exist for the given date", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }
            finally
            {
                con.Close();
            }

        }

        //Insert Schedule
        public bool insertSchedule(string SCHEDULE_DATE, string SCHEDULE_FREQ, string SCHEDULE_SECRET)
        {
            var con = new SQLiteConnection(cs);
            try
            {

                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = String.Format(@"INSERT INTO schedules(SCHEDULE_DATE,SCHEDULE_FREQ,SCHEDULE_SECRET) VALUES
                ('{0}','{1}','{2}')", SCHEDULE_DATE, SCHEDULE_FREQ, SCHEDULE_SECRET);
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    MessageBox.Show("Frequency already exist for the given date", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }
            finally
            {
                con.Close();
            }
        }

      
        //Update Schedule
        public bool updateSchedule(string SCHEDULE_ID, string SCHEDULE_DATE, string SCHEDULE_FREQ, string SCHEDULE_SECRET)
        {
            var con = new SQLiteConnection(cs);
            try
            {

                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = String.Format(@"UPDATE schedules SET SCHEDULE_DATE='{0}',SCHEDULE_FREQ='{1}',SCHEDULE_SECRET='{2}' WHERE SCHEDULE_ID={3}", SCHEDULE_DATE, SCHEDULE_FREQ, SCHEDULE_SECRET, SCHEDULE_ID);
                return Convert.ToBoolean(cmd.ExecuteNonQuery());
            }
            catch (SQLiteException ex)
            {
                if (ex.ErrorCode == 19)
                {
                    MessageBox.Show("Frequency already exist for the given date", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                return false;
            }
            finally
            {
                con.Close();
            }

        }

        public byte [] convertToByte(string filepath)
        {

            byte[] bytes = System.IO.File.ReadAllBytes(filepath);


            return bytes;
        }

        public  BigInteger power(BigInteger a, int b, double P)
        {
            BigInteger xx;
            if (b == 1)
                return a;

            else
                xx = BigInteger.Pow(a, b);
            return xx % BigInteger.Parse(P.ToString());

            // return Math.Pow(a , b) % P;
        }


        public  int GetValueForP()
        {
            Random rnd = new Random();
            // Declare the variables 
            int a, b, i, j, flag;

            // Ask user to enter lower value of interval 


            a = rnd.Next(1, 100);
            b = rnd.Next(101, 150);
            // Ask user to enter upper value of interval 
           
            // Traverse each number in the interval 
            // with the help of for loop 
            for (i = a; i <= b; i++)
            {
                // Skip 0 and 1 as they are 
                // niether prime nor composite 
                if (i == 1 || i == 0)
                    continue;

                // flag variable to tell 
                // if i is prime or not 
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                // flag = 1 means i is prime 
                // and flag = 0 means i is not prime 
                if (flag == 1)
                    return i;
            }
            return 47;

        }
        public BigInteger GetValueForG()
        {
            Random rnd = new Random();
            BigInteger G = rnd.Next(152, 200);
            return G;
        }


        public string  GeneratePublicKey(int P_FPID, double P_Freq, BigInteger G, int P)
        {
            var src = DateTime.Now;
           
            int _min =Convert.ToInt32(src.Minute);

          int a =  _min + P_FPID + Convert.ToInt32(P_Freq);
          
            Global.PrivateKey = a;
            BigInteger x = power(G, a, P);
            Global.MyPublicKey = x.ToString();
            return x.ToString();
        }

        public void GenerateSectetKey(BigInteger y, int P )
        {
           BigInteger ka = power(y, Global.PrivateKey, P);
            Global.SecretKey = ka.ToString();
        }


        public DataTable getLogs()
        {

            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();
                string query = @"SELECT logid ,logtime ,logtext  FROM logs WHERE logstation_id="+Global.MyStationID+"  ORDER BY logid DESC";
                SQLiteDataAdapter da = new SQLiteDataAdapter(query, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Logs");

                return ds.Tables["Logs"];
            }
            catch (Exception ex)
            {

                return null;
            }
            finally
            {
                con.Close();
            }

        }

        public void writeLog(string Message)
        {
            var con = new SQLiteConnection(cs);
            try
            {

                con.Open();
                var cmd = new SQLiteCommand(con);

                cmd.CommandText = String.Format(@"INSERT INTO logs(logtime,logstation_id,logtext) VALUES
                ('{0}','{1}','{2}')", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), Global.MyStationID, Message);
              cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {

                MessageBox.Show(ex.Message);
               
            }
            finally
            {
                con.Close();
            }
        }

        public string  getStationByStationCode(string Code)
        {
            string result="Unknown";
            ComboBox cmb = new ComboBox();
            var con = new SQLiteConnection(cs);
            try
            {
              

                con.Open();


                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "SELECT STATION_NAME FROM stations WHERE STATION_CODE="+ Code;
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (!string.IsNullOrEmpty(reader["STATION_NAME"].ToString()))
                    {
                        result= reader["STATION_NAME"].ToString();
                    }
                    else { 
                 
                        result= "Unknown";
                    }
                }
                reader.Close();
                return result;
            }
            catch (Exception ex)
            {
                con.Close();
                  
                return result;
            }
            finally
            {
                con.Close();
            }

        }


 public void  loadTodaysFreqAndSecret()
        {

            ComboBox cmb = new ComboBox();
            var con = new SQLiteConnection(cs);
            try
            {


                con.Open();


                var cmd = new SQLiteCommand(con);

                cmd.CommandText = "SELECT SCHEDULE_FREQ,SCHEDULE_SECRET FROM schedules WHERE SCHEDULE_DATE=CURRENT_DATE";
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (!string.IsNullOrEmpty(reader["SCHEDULE_FREQ"].ToString())&& !string.IsNullOrEmpty(reader["SCHEDULE_SECRET"].ToString()))
                    {
                        Global.TodaysFrequency= reader["SCHEDULE_FREQ"].ToString();
                        Global.TodaysSecret = reader["SCHEDULE_SECRET"].ToString();
                       
                    }
                    else
                    {
                        Global.TodaysFrequency = "0";
                        Global.TodaysSecret = "0";
                    }
                }
              
            }
            catch (Exception ex)
            {
                con.Close();
               
            }
            finally
            {
                con.Close();
            }

        }
    }
}
