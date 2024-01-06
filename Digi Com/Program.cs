using Digi_Com.AppForms;
using Digi_Com.Tests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Digi_Com
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /*
                DataTable table = new DataTable();
                table.Columns.Add("PERSONEL_ID", typeof(int));
                table.Columns.Add("PERSONEL_PRFIX_ID", typeof(string));
                table.Columns.Add("PERSONEL_RANK_ID", typeof(string));
                table.Columns.Add("PERSONEL_FINGRE_KEY_NO", typeof(string));
                table.Columns.Add("PERSONEL_NAME", typeof(string));
                table.Columns.Add("PERSONEL_ARMYNO", typeof(string));
                table.Columns.Add("PERSONEL_MOBILE", typeof(string));
                table.Columns.Add("PERSONEL_USER_ROLE_ID", typeof(string));
                table.Columns.Add("PERSONEL_LAST_LOGIN", typeof(DateTime));

                table.Rows.Add(1, "0", "0","1", "Administrator","00000", "0181482691","1", DateTime.Now);
                 Here we add five DataRows.
                Global.User = table.Rows[0];

                Global.MyStationID = "10";*/

            Application.Run(new frmLogin());
        }
    }
}

