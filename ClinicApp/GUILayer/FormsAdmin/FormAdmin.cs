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
            dataGridViewUsers.Columns.Clear();
            dataGridViewUsers.DataSource = BusinessLayer.AdminFacade.GetUsers(new BusinessLayer.UserInformation());
            dataGridViewUsers.Columns[0].Width = 60;
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            FormAdminNewUser formAdminNewUser = new FormAdminNewUser();
            DialogResult res = formAdminNewUser.ShowDialog(this);
            if (res == DialogResult.OK)
            {

            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            FormAdminChangePassword formAdminChangePassword = new FormAdminChangePassword();
            DialogResult res = formAdminChangePassword.ShowDialog(this);
            if (res == DialogResult.OK)
            {

            }
        }

        private void buttonRetireUser_Click(object sender, EventArgs e)
        {
            FormAdminRetireUser formAdminRetireUser = new FormAdminRetireUser();
            DialogResult res = formAdminRetireUser.ShowDialog(this);
            if (res == DialogResult.OK)
            {

            }
        }
    }
}
