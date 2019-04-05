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
    public partial class FormAdminChangePassword : Form
    {

        BusinessLayer.UserInformation userInformation;

        public FormAdminChangePassword(BusinessLayer.UserInformation userInformation)
        {
            InitializeComponent();
            this.userInformation = userInformation;
            textBoxUserID.Text = userInformation.UserID.ToString();
            textBoxUsername.Text = userInformation.Username;
            textBoxRole.Text = userInformation.Role;
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            //Check if either password field is empty.
            if (string.IsNullOrWhiteSpace(textBoxNewPassword.Text) ||
                string.IsNullOrWhiteSpace(textBoxConfirmPassword.Text))
            {
                MessageBox.Show("Both password fields must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //DODAĆ MINIMALNE WYMOGI DLA HASŁA???
            //TO BE DONE

            //Change password of User.
            BusinessLayer.AdminFacade.ChangeUserPassword(userInformation.UserID, textBoxNewPassword.Text);

            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
