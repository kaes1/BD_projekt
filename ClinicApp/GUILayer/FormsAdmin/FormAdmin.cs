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
            userSearchCriteria.Role = comboBoxRole.SelectedText;
            if (dateTimePickerDateRetired.Checked)
                userSearchCriteria.DateRetired = dateTimePickerDateRetired.Value;
            dataGridViewUsers.Columns.Clear();
            dataGridViewUsers.DataSource = BusinessLayer.AdminFacade.GetUsers(userSearchCriteria);

        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            FormAdminNewUser formAdminNewUser = new FormAdminNewUser();
            DialogResult res = formAdminNewUser.ShowDialog(this);
            if (res == DialogResult.OK)
            {

            }
            formAdminNewUser.Dispose();
            //Refresh displayed Users.
            searchForUsers();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            //Check if any User is selected.
            if (dataGridViewUsers.SelectedCells.Count > 0)
            {
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

                //BYĆ MOŻE UPILNOWAĆ, BY PO REFRESHU ZAZNACZONY BYŁ TEN SAM USER???
                //TO BE DONE

            }
            else
            {
                MessageBox.Show("Please select a User to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }

        private void buttonRetireUser_Click(object sender, EventArgs e)
        {
            FormAdminRetireUser formAdminRetireUser = new FormAdminRetireUser();
            DialogResult res = formAdminRetireUser.ShowDialog(this);
            if (res == DialogResult.OK)
            {

            }
            formAdminRetireUser.Dispose();
            //Refresh displayed Users.
            searchForUsers();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchForUsers();
        }
    }
}
