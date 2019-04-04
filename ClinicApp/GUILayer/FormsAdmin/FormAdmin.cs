using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILayer
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            //Set the dateTimePickerDateRetired to current date when the form loads.
            dateTimePickerDateRetired.Value = DateTime.Now;
            //Initial search for users.
            searchForUsers();
        }

        private void searchForUsers()
        {
            BusinessLayer.UserInformation userSearchCriteria = new BusinessLayer.UserInformation();
            userSearchCriteria.UserID = (textBoxUserID.Text=="" ? 0 : int.Parse(textBoxUserID.Text));
            userSearchCriteria.Username = textBoxUsername.Text;
            if (!string.IsNullOrWhiteSpace(comboBoxRole.Text))
                userSearchCriteria.Role = comboBoxRole.Text;
            if (dateTimePickerDateRetired.Checked)
                userSearchCriteria.DateRetired = dateTimePickerDateRetired.Value.Date;
            dataGridViewUsers.Columns.Clear();
            dataGridViewUsers.DataSource = BusinessLayer.AdminFacade.GetUsers(userSearchCriteria, checkBoxOnlyActive.Checked);
            dataGridViewUsers.Columns[0].Width = 60;
            dataGridViewUsers.Columns[1].Width = 130;
            dataGridViewUsers.Columns[2].Width = 143;
            dataGridViewUsers.Columns[3].Width = 60;
            dataGridViewUsers.Columns[4].Width = 110;
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            //Create and display the form for creating new users.
            FormAdminNewUser formAdminNewUser = new FormAdminNewUser();
            DialogResult res = formAdminNewUser.ShowDialog(this);    
            //Refresh displayed Users.
            searchForUsers();
            //Select the new user if added.
            if (res == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dataGridViewUsers.Rows)
                    if (row.Cells[1].Value.ToString().Equals(formAdminNewUser.newUserInformation.Username))
                    {
                        dataGridViewUsers.CurrentCell = dataGridViewUsers[0, row.Index];
                        break;
                    }
            }
            formAdminNewUser.Dispose();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            //Check if any User is selected.
            if (dataGridViewUsers.SelectedCells.Count > 0)
            {
                //Save current row index to reselect this row later.
                int savedRowIndex = (dataGridViewUsers.CurrentRow.Index);

                //Get selected user's information.
                BusinessLayer.UserInformation userInfo = new BusinessLayer.UserInformation();
                userInfo.UserID = (int)(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells[0].Value);
                userInfo.Username = (string)(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells[1].Value);
                userInfo.Role = (string)(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells[3].Value);
                //Create and display the form for changing password.
                FormAdminChangePassword formAdminChangePassword = new FormAdminChangePassword(userInfo);
                DialogResult res = formAdminChangePassword.ShowDialog(this);
                formAdminChangePassword.Dispose();
                //Refresh displayed Users.
                searchForUsers();

                //Select previously selected user.
                dataGridViewUsers.CurrentCell = dataGridViewUsers[0, savedRowIndex];
            }
            else
            {
                MessageBox.Show("Please select a User to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }

        private void buttonRetireUser_Click(object sender, EventArgs e)
        {
            //Check if any User is selected.
            if (dataGridViewUsers.SelectedCells.Count > 0)
            {
                //Save current row index to reselect this row later.
                int savedRowIndex = (dataGridViewUsers.CurrentRow.Index);

                //Get selected user's information.
                BusinessLayer.UserInformation userInfo = new BusinessLayer.UserInformation();
                userInfo.UserID = (int)(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells[0].Value);
                userInfo.Username = (string)(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells[1].Value);
                userInfo.Role = (string)(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells[3].Value);
                if (dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells[4].Value != null)
                    userInfo.DateRetired = (DateTime)(dataGridViewUsers.Rows[dataGridViewUsers.CurrentCell.RowIndex].Cells[4].Value);
                //Create and display the form for managing retirement.
                FormAdminRetireUser formAdminRetireUser = new FormAdminRetireUser(userInfo);
                DialogResult res = formAdminRetireUser.ShowDialog(this);
                formAdminRetireUser.Dispose();
                //Refresh displayed Users.
                searchForUsers();

                //Select previously selected user.
                dataGridViewUsers.CurrentCell = dataGridViewUsers[0, savedRowIndex];
            }
            else
            {
                MessageBox.Show("Please select a User to manage retirement.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchForUsers();
        }

        private void checkBoxOnlyActive_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOnlyActive.Checked)
            {
                dateTimePickerDateRetired.Checked = false;
            }
        }

        private void dateTimePickerDateRetired_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerDateRetired.Checked)
            {
                checkBoxOnlyActive.Checked = false;
            }
        }
    }
}
