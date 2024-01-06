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
    public partial class frmUserManager : Form
    {
        DB _db = new DB();
        string _selectedPersonelID = null;
        public frmUserManager()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void frmUserManager_Load(object sender, EventArgs e)
        {
            this.Size = new Size(870, 460);

            cmbRank.DisplayMember = "RANK_NAME";
            cmbRank.ValueMember = "RANK_ID";
            cmbRank.DataSource = _db.getRankList();
            cmbRank.SelectedIndex = -1;

            cmbPrefix.DisplayMember = "PREFIX_NAME";
            cmbPrefix.ValueMember = "PREFIX_ID";
            cmbPrefix.DataSource = _db.getPrefixList();
            cmbPrefix.SelectedIndex = -1;

            cmbRole.DisplayMember = "ROLE_NAME";
            cmbRole.ValueMember = "ROLE_ID";
            cmbRole.DataSource = _db.getRoleList();
            cmbRole.SelectedIndex = -1;

            _loadUsersListView();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if(btnSaveUser.Text=="Save")
            {

                //Validation

                if (cmbPrefix.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select prefix!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPrefix.Focus();
                    return;
                }

                if (cmbRank.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select rank!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPrefix.Focus();
                    return;
                }

                if (txtArmyNo.Text.Length == 0)
                {
                    MessageBox.Show("Please enter army no!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtArmyNo.Focus();
                    return;
                }
                if (txtName.Text.Length == 0)
                {
                    MessageBox.Show("Please enter name!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }
               
              
                if (cmbRole.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a user role!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPrefix.Focus();
                    return;
                }

                if (_db.insertPersonel(cmbPrefix.SelectedValue.ToString(), cmbRank.SelectedValue.ToString(), txtName.Text.Trim(), txtArmyNo.Text.Trim(), cmbRole.SelectedValue.ToString(),txtMobileNo.Text.Trim()))
                {
                    MessageBox.Show("User Created Successfully", Application.ProductName,  MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _clearInputForm();
                    _loadUsersListView();
                }
            }
            else if (btnSaveUser.Text == "Update")
            {

                //Validation

                if (cmbPrefix.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select prefix!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPrefix.Focus();
                    return;
                }

                if (cmbRank.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select rank!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPrefix.Focus();
                    return;
                }

                if (txtArmyNo.Text.Length == 0)
                {
                    MessageBox.Show("Please enter army no!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtArmyNo.Focus();
                    return;
                }
                if (txtName.Text.Length == 0)
                {
                    MessageBox.Show("Please enter name!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtName.Focus();
                    return;
                }


                if (cmbRole.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select a user role!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPrefix.Focus();
                    return;
                }

                if (_db.updatePersonel(_selectedPersonelID,cmbPrefix.SelectedValue.ToString(), cmbRank.SelectedValue.ToString(), txtName.Text.Trim(), txtArmyNo.Text.Trim(), cmbRole.SelectedValue.ToString(), txtMobileNo.Text.Trim()))
                {
                    MessageBox.Show("User Updated Successfully", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _clearInputForm();
                    _loadUsersListView();
                }
            }
        }


        private void _loadUsersListView()
        {



            lvUsers.BeginUpdate();
            lvUsers.Items.Clear();
            try
            {
                DataTable _data = _db.getPersonelList();
                foreach (DataRow row in _data.Rows)
                {
                    if (row["PERSONEL_ID"].ToString() != "1")
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = row["PERSONEL_ID"].ToString();
                        item.SubItems.Add(row["FULL_ARMYNO"].ToString());
                        item.SubItems.Add(row["RANK_NAME"].ToString());
                        item.SubItems.Add(row["PERSONEL_NAME"].ToString());
                        item.SubItems.Add(row["PERSONEL_MOBILE"].ToString());
                        item.SubItems.Add(row["ROLE_NAME"].ToString());
                        item.SubItems.Add(row["PERSONEL_LAST_LOGIN"].ToString());
                        item.SubItems.Add(row["PERSONEL_RANK_ID"].ToString());
                        item.SubItems.Add(row["PERSONEL_PRFIX_ID"].ToString());
                        item.SubItems.Add(row["PERSONEL_FINGRE_KEY_NO"].ToString());
                        item.SubItems.Add(row["PERSONEL_USER_ROLE_ID"].ToString());
                        item.SubItems.Add(row["PERSONEL_ARMYNO"].ToString());

                        lvUsers.Items.Add(item);
                    }
                   


                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lvUsers.EndUpdate();
                lvUsers.Refresh();
            }

        }

        //Reset Input Forms
        private void _clearInputForm()
        {
            _selectedPersonelID = null;
            cmbPrefix.SelectedIndex = -1;
            cmbRank.SelectedIndex = -1;
            cmbRole.SelectedIndex = -1;
            txtArmyNo.Clear();
            txtName.Clear();
            txtMobileNo.Clear();
            btnSaveUser.Text = "Save";

            lvUsers.SelectedItems.Clear();
            btnEnrollFingre.Enabled = false;
            btnEnrollFingre.Text = " Enroll Fingreprint";

        }

        private void lvUsers_DoubleClick(object sender, EventArgs e)
        {
            if(lvUsers.SelectedIndices.Count > 0)
            {
                ListViewItem item = lvUsers.SelectedItems[0];
                _selectedPersonelID= item.SubItems[colPersonelID.Index].Text;
                txtArmyNo.Text = item.SubItems[colArmyNoOnly.Index].Text;
                txtName.Text = item.SubItems[colName.Index].Text;
                cmbPrefix.SelectedValue=item.SubItems[colPrefixID.Index].Text;
                cmbRank.SelectedValue = item.SubItems[colRankID.Index].Text;
                cmbRole.SelectedValue = item.SubItems[colRoleID.Index].Text;
                txtMobileNo.Text= item.SubItems[colMobileNo.Index].Text;
                btnSaveUser.Text = "Update";

                if (string.IsNullOrWhiteSpace(item.SubItems[colFingreID.Index].Text))
                {
                    btnEnrollFingre.Enabled = true;
                    btnEnrollFingre.Text = " Enroll Fingreprint";

                }
                else
                {
                    btnEnrollFingre.Enabled = true;
                    btnEnrollFingre.Text = " Update Fingreprint";
                }
                

            }
            
        }

        private void btnCancleUser_Click(object sender, EventArgs e)
        {
            _clearInputForm();
        }

        private void btnEnrollFingre_Click(object sender, EventArgs e)
        {


            Form _frmCaptureFingre = new frmCaptureFingre(_selectedPersonelID);
             
            _frmCaptureFingre.ShowDialog();
            _clearInputForm();
            _loadUsersListView();
        }

        private void lvUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this user ??",
                                       "Confirm Delete!!",
                                       MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _db.deleteUserByUserid(Convert.ToInt32(lvUsers.SelectedItems[0].SubItems[colPersonelID.Index].Text));
                    lvUsers.SelectedItems.Clear();
                    _loadUsersListView();
                }
                else
                {
                    return;
                }
            }
        }
    }
}





