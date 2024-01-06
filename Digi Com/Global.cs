using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;


namespace Digi_Com
{
    static class Global
    {
        private static bool _isCaller = false;

        private static string _filename = null;
        private static string _globalVar = "";
        private static DataTable _user =null;
        private static DataRow _userRow = null;
        private static string _currentTimestamp = null;
        private static string _fpComport = null;
        private static string _trnsComport = null;
        private static string _secretKey = null;
        private static string _bobsPublicKey = null;
        private static string _MyPublicKey = null;
        private static string _MyStationID = null;
        private static string _ValueofG = null;
        private static string _ValueofP = null;
        private static int _PrivateKey = 0;
        private static bool _isCallRceived = false;
        private static string _TodaysFreq = "0";
        private static string _TodaysSecret = "0";


        private static List<byte[]> _byteArrayList = new List<byte[]>();

        public static List<byte[]> byteArrayList
        {
            get { return _byteArrayList; }
            set { _byteArrayList = value; }
        }



        private static string _personel_fingre_key_no = "0";
        public static string personel_fingre_key_no
        {
            get { return _personel_fingre_key_no; }
            set { _personel_fingre_key_no = value; }
        }


        public static string GlobalVar
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }

        public static bool isCallReceived
        {
            get { return _isCallRceived; }
            set { _isCallRceived = value; }
        }

        public static string TodaysFrequency
        {
            get { return _TodaysFreq; }
            set { _TodaysFreq = value; }
        }
        public static string TodaysSecret
        {
            get { return _TodaysSecret; }
            set { _TodaysSecret = value; }
        }
        public static string FPCOMPORT
        {
            get { return _fpComport; }
            set { _fpComport = value; }
        }
        public static string MyStationID
        {
            get { return _MyStationID; }
            set { _MyStationID = value; }
        }
        public static string TrnsComPort
        {
            get { return _trnsComport; }
            set { _trnsComport = value; }
        }
        private static DataTable UserDataTable
        {
            get { return _user; }
            set { _user = value; }
        }
        public static int  PrivateKey
        {
            get { return _PrivateKey; }
            set { _PrivateKey = value; }
        }

        public static string  SecretKey
        {
            get { return _secretKey; }
            set { _secretKey = value; }
        }

        public static string BobsPublicKey
        {
            get { return _bobsPublicKey; }
            set { _bobsPublicKey = value; }
        }
        public static string MyPublicKey
        {
            get { return _MyPublicKey; }
            set { _MyPublicKey = value; }
        }
        public static string ValueofP
        {
            get { return _ValueofP; }
            set { _ValueofP = value; }
        }

        public static string ValueofG
        {
            get { return _ValueofG; }
            set { _ValueofG = value; }
        }
        public static string filename
        {
            get { return _filename; }
            set { _filename = value; }
        }
        public static bool isCaller
        {
            get { return _isCaller; }
            set { _isCaller = value; }
        }
        public static DataRow User
        {
            get { return _userRow; }
            set { _userRow = value; }
        }



        private static string _genKey = string.Empty;
        public static string GenKey
        {
            get { return _genKey; }
            set { _genKey = value; }
        }

        private static string _callerFingerID = string.Empty;
        public static string callerFingerID
        {
            get { return _callerFingerID; }
            set { _callerFingerID = value; }
        }


        private static string _receivedCallerID = "";
        public static string ReceivedCallerID
        {
            get { return _receivedCallerID; }
            set { _receivedCallerID = value; }
        }
        public static string GetTimestamp
        {
            get { return _currentTimestamp; }
            set { _currentTimestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); }
          
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

    }
}