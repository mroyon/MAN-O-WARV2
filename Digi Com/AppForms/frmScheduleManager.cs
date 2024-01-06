using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Digi_Com.AppForms
{
    public partial class frmScheduleManager : Form
    {

        DB _db = new DB();
        string _selectedScheduleID = null;
        public frmScheduleManager()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {
                //if (Convert.ToDecimal(txtFrequency.Text) >= 33000 || Convert.ToDecimal(txtFrequency.Text) <= 3000)
                //{
                //    MessageBox.Show("Not a Valid Frequency!");
                //}

                if (txtFrequency.Text.Length == 0)
                {
                    MessageBox.Show("Please enter Frequency!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFrequency.Focus();
                    return;
                }

                if (txtSecretKey.Text.Length == 0)
                {
                    MessageBox.Show("Please enter Secret Key!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSecretKey.Focus();
                    return;
                }

             
                    if (_db.insertSchedule(txtFreqFromDate.Value.ToString("yyyy-MM-dd"), txtFrequency.Text.Trim(), txtSecretKey.Text.Trim()))
                    {
                        MessageBox.Show("Frequency Created Successfully", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _clearInputForm();
                        _loadSchedule();
                    }
              


               
            }

            if (btnSave.Text == "Update")
            {


                if (txtFrequency.Text.Length == 0)
                {
                    MessageBox.Show("Please enter Frequency!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtFrequency.Focus();
                    return;
                }

                if (txtSecretKey.Text.Length == 0)
                {
                    MessageBox.Show("Please enter Secret Key!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSecretKey.Focus();
                    return;
                }


                if (_db.updateSchedule(_selectedScheduleID,txtFreqFromDate.Value.ToString("yyyy-MM-dd"), txtFrequency.Text.Trim(), txtSecretKey.Text.Trim()))
                {
                    MessageBox.Show("Frequency Updated Successfully", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _clearInputForm();
                    _loadSchedule();
                }




            }
            if (btnSave.Text == "Generate")
            {
                if (txtFreqFromDate.Value == null)
                {
                    MessageBox.Show("Please select To Date", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFreqFromDate.Focus();
                    return;
                }
                if (Convert.ToDateTime(txtFreqFromDate.Value) > Convert.ToDateTime(txtFreqFromDate.Value))
                {
                    MessageBox.Show("Invalid Date Range", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFreqFromDate.Focus();
                    return;
                }
                if (txtFreqFromDate.Value == null)
                {
                    MessageBox.Show("Please select To Date", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFreqFromDate.Focus();
                    return;
                }
               

               
                foreach (DateTime day in EachDay(Convert.ToDateTime(txtFreqFromDate.Value), Convert.ToDateTime(txtFreqFromDate.Value)))
                {


                    _db.insertSchedule(day.ToString("yyyy-MM-dd"), null, null);
                }
                MessageBox.Show("Frequency Created Successfully", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                //chkGenerate.Checked = false;
                txtFreqFromDate.Enabled = false;
                txtFreqFromDate.Visible = false;
                _clearInputForm();
                _loadSchedule();
            }


        }
        private void _loadSchedule()
        {



            lvSchedules.BeginUpdate();
            lvSchedules.Items.Clear();
            try
            {
                DataTable _data = _db.getScheduleList(txtDisplayDate.Value.ToString("yyyy-MM-dd"));
                foreach (DataRow row in _data.Rows)
                {
                 
                        ListViewItem item = new ListViewItem();
                        item.Text = row["SCHEDULE_ID"].ToString();
                        item.SubItems.Add(row["SCHEDULE_DATE"].ToString());
                        item.SubItems.Add(row["SCHEDULE_FREQ"].ToString());
                        item.SubItems.Add(row["SCHEDULE_SECRET"].ToString());
                       

                        lvSchedules.Items.Add(item);
                    }



               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lvSchedules.EndUpdate();
                lvSchedules.Refresh();
            }

        }
        private void _loadScheduleByDate()
        {



            lvSchedules.BeginUpdate();
            lvSchedules.Items.Clear();
            try
            {
                DataTable _data = _db.getScheduleListByDate(txtDisplayDate.Value.ToString("yyyy-MM-dd"));
                foreach (DataRow row in _data.Rows)
                {

                    ListViewItem item = new ListViewItem();
                    item.Text = row["SCHEDULE_ID"].ToString();
                    item.SubItems.Add(row["SCHEDULE_DATE"].ToString());
                    item.SubItems.Add(row["SCHEDULE_FREQ"].ToString());
                    item.SubItems.Add(row["SCHEDULE_SECRET"].ToString());


                    lvSchedules.Items.Add(item);
                }







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lvSchedules.EndUpdate();
                lvSchedules.Refresh();
            }

        }

        //Reset Input Forms
        private void _clearInputForm()
        {
            _selectedScheduleID = null;
            txtFrequency.Text = "";
            txtSecretKey.Text = "";
            btnSave.Text = "Save";

            if (lvSchedules.SelectedItems.Count > 0)
            {
                lvSchedules.SelectedItems.Clear();
            }
          


        }

        private void frmScheduleManager_Load(object sender, EventArgs e)
        {
            this.Size = new Size(540, 550);
            txtDisplayDate.Value = DateTime.Today;
            _loadSchedule();

            txtFreqFromDate.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));
            txtFreqFromDate.Value = Convert.ToDateTime(DateTime.Now.ToString("yyyy-MM-dd"));



        }

        private void chkGenerate_OnChange(object sender, EventArgs e)
        {
            //if (chkGenerate.Checked)
            //{
            //    btnSave.Text = "Generate";
            //    txtFreqToDate.Enabled = true;
            //    txtFreqToDate.Visible = true;
            //}else
            //{
            //    btnSave.Text = "Save";
            //    txtFreqToDate.Enabled = false;
            //    txtFreqToDate.Visible = false;
            //}

            

        }

        public IEnumerable<DateTime> EachDay(DateTime from, DateTime thru)
        {
            for (var day = from.Date; day.Date <= thru.Date; day = day.AddDays(1))
                yield return day;
        }

        private void txtDisplayDate_ValueChanged(object sender, EventArgs e)
        {
            _loadSchedule();
        }

        private void lvSchedules_DoubleClick(object sender, EventArgs e)
        {
            btnSave.Text = "Update";
            _selectedScheduleID = lvSchedules.SelectedItems[0].SubItems[colSl.Index].Text.ToString();

            string date = lvSchedules.SelectedItems[0].SubItems[colFreqDate.Index].Text;

            txtFreqFromDate.Value = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            txtFrequency.Text = lvSchedules.SelectedItems[0].SubItems[colFrequency.Index].Text;
            txtSecretKey.Text = lvSchedules.SelectedItems[0].SubItems[colSecretKey.Index].Text;

        }

        private void txtFrequency_OnValueChanged(object sender, EventArgs e)
       {
            //Convert.ToDecimal(txtFrequency.Text);
            //if (Convert.ToDecimal(txtFrequency.Text) >= 33000 || Convert.ToDecimal(txtFrequency.Text) <= 3000)
            //{
            //    //MessageBox.Show("Not a Valid Frequency!");
            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          _loadScheduleByDate();
        }

        private void loadFreqAndSecretByDate(string dateparm)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            _loadSchedule();
        }
    }
}
