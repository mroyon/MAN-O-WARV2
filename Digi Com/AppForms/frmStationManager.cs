using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Digi_Com.AppForms
{
    public partial class frmStationManager : Form
    {
        DB _db = new DB();
        string _selectedStationID = null;
        public frmStationManager()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void _loadStations()
        {



            lvStations.BeginUpdate();
            lvStations.Items.Clear();
            try
            {
                DataTable _data = _db.getAllStationList();
                foreach (DataRow row in _data.Rows)
                {
                    
                        ListViewItem item = new ListViewItem();
                        item.Text = row["STATION_ID"].ToString();
                        item.SubItems.Add(row["STATION_NAME"].ToString());
                        item.SubItems.Add(row["STATION_CODE"].ToString());

                        lvStations.Items.Add(item);
                    }



               



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lvStations.EndUpdate();
                lvStations.Refresh();
            }

        }

        private void frmStationManager_Load(object sender, EventArgs e)
        {
            this.Size = new Size(490, 530);
            _loadStations();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {

                //Validation

              

                if (txtStationName.Text.Length == 0)
                {
                    MessageBox.Show("Please enter army no!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStationName.Focus();
                    return;
                }
                if (txtStationCode.Text.Length == 0)
                {
                    MessageBox.Show("Please enter name!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStationCode.Focus();
                    return;
                }
                if (_db.insertStation(txtStationName.Text.Trim(), txtStationCode.Text.Trim()))
                {
                    MessageBox.Show("User Created Successfully", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _clearInputForm();
                    _loadStations();
                }

            }else if (btnSave.Text == "Update")
            {

                //Validation



                if (txtStationName.Text.Length == 0)
                {
                    MessageBox.Show("Please enter army no!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStationName.Focus();
                    return;
                }
                if (txtStationCode.Text.Length == 0)
                {
                    MessageBox.Show("Please enter name!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStationCode.Focus();
                    return;
                }
                if (_db.updateStation(_selectedStationID,txtStationName.Text.Trim(), txtStationCode.Text.Trim()))
                {
                    MessageBox.Show("Station Updated Successfully!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _clearInputForm();
                    _loadStations();
                }

            }
        }


        private void _clearInputForm()
        {
            _selectedStationID = null;

            txtStationName.Text = null;
            txtStationCode.Text = null; ;
            
            btnSave.Text = "Save";

            lvStations.SelectedItems.Clear();
          

        }

        private void lvStations_DoubleClick(object sender, EventArgs e)
        {
            if (lvStations.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvStations.SelectedItems[0];
                _selectedStationID = item.SubItems[colStationID.Index].Text;
                txtStationName.Text = item.SubItems[colStationName.Index].Text;
                txtStationCode.Text = item.SubItems[colStationCode.Index].Text;
                
                btnSave.Text = "Update";

               

            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (btnSave.Text == "Save")
            {

                //Validation



                if (txtStationName.Text.Length == 0)
                {
                    MessageBox.Show("Please enter army no!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStationName.Focus();
                    return;
                }
                if (txtStationCode.Text.Length == 0)
                {
                    MessageBox.Show("Please enter name!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStationCode.Focus();
                    return;
                }
                if (_db.insertStation(txtStationName.Text.Trim(), txtStationCode.Text.Trim()))
                {
                    MessageBox.Show("User Created Successfully", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _clearInputForm();
                    _loadStations();
                }

            }
            else if (btnSave.Text == "Update")
            {

                //Validation



                if (txtStationName.Text.Length == 0)
                {
                    MessageBox.Show("Please enter army no!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStationName.Focus();
                    return;
                }
                if (txtStationCode.Text.Length == 0)
                {
                    MessageBox.Show("Please enter name!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtStationCode.Focus();
                    return;
                }
                if (_db.updateStation(_selectedStationID, txtStationName.Text.Trim(), txtStationCode.Text.Trim()))
                {
                    MessageBox.Show("Station Updated Successfully!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _clearInputForm();
                    _loadStations();
                }

            }
        }
    }
}
