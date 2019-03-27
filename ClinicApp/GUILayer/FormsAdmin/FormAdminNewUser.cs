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
        public FormAdminNewUser()
        {
            InitializeComponent();
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
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
