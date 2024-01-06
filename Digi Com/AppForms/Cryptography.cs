using ManOWarEncLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digi_Com.AppForms
{
    public class Cryptography
    {//  Call this function to remove the key from memory after use for security
        [DllImport("KERNEL32.DLL", EntryPoint = "RtlZeroMemory")]
        public static extern bool ZeroMemory(IntPtr Destination, int Length);



        DB _db = new DB();
        /// <summary>
        /// Creates a random salt that will be used to encrypt your file. This method is required on FileEncrypt.
        /// </summary>
        /// <returns></returns>
        public static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    // Fille the buffer with the generated data
                    rng.GetBytes(data);
                }
            }

            return data;
        }

        /// <summary>
        /// Encrypts a file from its path and a plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        public string FileEncrypt(string inputFile)
        {
            string secrateKey = string.Empty;
            string fileName = string.Empty;
            clsEncLibrary objEncDec2 = new clsEncLibrary();
            DataTable _data = _db.getScheduleListByDate(DateTime.Now.ToString("yyyy-MM-dd"));
            if (_data != null && _data.Rows.Count > 0)
            {
                foreach (DataRow row in _data.Rows)
                {
                    string callerCode = Global.personel_fingre_key_no;
                    DateTime truncatedDateTime = DateTime.Now;
                    string frequency = row["SCHEDULE_FREQ"].ToString();
                    secrateKey = row["SCHEDULE_SECRET"].ToString();
                    string filePath = inputFile;// @"C:\CF\sampleFile\Free_Test_Data_100KB_PDF.pdf";
                    fileName = objEncDec2.FileEncrypt(filePath, callerCode, truncatedDateTime, frequency, secrateKey);
                }
            }
            else
            {
                throw new Exception("Date wise frequency was not found in the database. Please set todays frequency valid data.");
            }
            return fileName;
        }

        /// <summary>
        /// Decrypts an encrypted file with the FileEncrypt method through its path and the plain password.
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="outputFile"></param>
        public void FileDecrypt(string inputFile, string outputFile)
        {
            string fileName = string.Empty;
            string secrateKey = string.Empty;

            clsEncLibrary objEncDec2 = new clsEncLibrary();
            DataTable _data = _db.getScheduleListByDate(DateTime.Now.ToString("yyyy-MM-dd"));
            foreach (DataRow row in _data.Rows)
            {
                string callerCode = Global.ReceivedCallerID;// Global.personel_fingre_key_no;
                DateTime truncatedDateTime = DateTime.Now;
                string frequency = row["SCHEDULE_FREQ"].ToString();
                secrateKey = row["SCHEDULE_SECRET"].ToString();
                string filePath = inputFile;// @"C:\CF\sampleFile\Free_Test_Data_100KB_PDF.pdf";
                //fileName = objEncDec2.FileDeccrypt(filePath);
            }



            //byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(secrateKey);
            //byte[] salt = new byte[32];

            //FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);
            //fsCrypt.Read(salt, 0, salt.Length);

            //RijndaelManaged AES = new RijndaelManaged();
            //AES.KeySize = 256;
            //AES.BlockSize = 128;
            //var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            //AES.Key = key.GetBytes(AES.KeySize / 8);
            //AES.IV = key.GetBytes(AES.BlockSize / 8);
            //AES.Padding = PaddingMode.PKCS7;
            //AES.Mode = CipherMode.CFB;

            //CryptoStream cs = new CryptoStream(fsCrypt, AES.CreateDecryptor(), CryptoStreamMode.Read);

            //FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            //int read;
            //byte[] buffer = new byte[1048576];

            //try
            //{
            //    while ((read = cs.Read(buffer, 0, buffer.Length)) > 0)
            //    {
            //        Application.DoEvents();
            //        fsOut.Write(buffer, 0, read);
            //    }
            //}
            //catch (CryptographicException ex_CryptographicException)
            //{
            //    Console.WriteLine("CryptographicException error: " + ex_CryptographicException.Message);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error: " + ex.Message);
            //}

            //try
            //{
            //    cs.Close();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error by closing CryptoStream: " + ex.Message);
            //}
            //finally
            //{
            //    fsOut.Close();
            //    fsCrypt.Close();
            //}
        }
    }

}



