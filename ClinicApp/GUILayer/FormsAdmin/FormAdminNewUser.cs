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
    public partial class FormAdminNewUser : Form
    {

        public BusinessLayer.UserInformation newUserInformation;

        public FormAdminNewUser()
        {
            InitializeComponent();
        }

        private bool correctInformation()
        {
            //Check if Username or Password is empty.
            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) ||
                string.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Username and Password must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Check if password meets requirements.
            if (!BusinessLayer.AdminFacade.ValidPassword(textBoxPassword.Text))
            {
                MessageBox.Show("Password must meet these requirements:\n" + BusinessLayer.AdminFacade.PasswordRequirements, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Check if Role is selected
            string selectedRole = (string)comboBoxRole.SelectedItem;
            if (selectedRole == null)
            {
                MessageBox.Show("Role must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Check if FirstName or LastName is empty.
            if (selectedRole != "ADM" &&
                (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text)))
            {
                MessageBox.Show("First Name and Last Name must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //Doctor specific checks
            if (selectedRole == "DOC")
            {
                //Check if PWZ Number is empty.
                if (string.IsNullOrWhiteSpace(textBoxPWZNumber.Text))
                {
                    MessageBox.Show("PWZ Number must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                //Check if length is correct.
                if (textBoxPWZNumber.Text.Length != 7)
                {
                    MessageBox.Show("PWZ Number must be 7 digits long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                //Check if all characters are numbers.
                foreach (char c in textBoxPWZNumber.Text)
                    if (c < '0' || c > '9')
                    {
                        MessageBox.Show("PWZ Number must be made up of digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }

                //CHECK CORRECTNESS  OF PWZ NUMBER??? NOT START WITH 0??? CONTROL DIGIT???
                //TO BE DONE
            }

            return true;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            //Check if information is correct.
            if (!correctInformation())
                return;

            //Check if user already exists in database.
            if (BusinessLayer.AdminFacade.ExistsUser(textBoxUsername.Text))
            {
                MessageBox.Show("User with Username '" + textBoxUsername.Text + "' already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Utworzenie Usera oraz danej Roli.
            int PWZNumber = (comboBoxRole.Text == "DOC") ? int.Parse(textBoxPWZNumber.Text) : 0;
            BusinessLayer.AdminFacade.AddUser(textBoxUsername.Text, textBoxPassword.Text, comboBoxRole.Text, textBoxFirstName.Text, textBoxLastName.Text, PWZNumber);
            newUserInformation = new BusinessLayer.UserInformation(){ Username = textBoxUsername.Text };
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = (string) comboBoxRole.SelectedItem;
            if (selectedRole == "DOC")
            {
                textBoxPWZNumber.Visible = true;
                labelPWZNumber.Visible = true;
            }
            else
            {
                textBoxPWZNumber.Visible = false;
                labelPWZNumber.Visible = false;
            }

            if (selectedRole == "ADM")
            {
                textBoxFirstName.Visible = false;
                labelFirstName.Visible = false;
                textBoxLastName.Visible = false;
                labelLastName.Visible = false;
            }
            else
            {
                textBoxFirstName.Visible = true;
                labelFirstName.Visible = true;
                textBoxLastName.Visible = true;
                labelLastName.Visible = true;
            }
        }
    }
}
