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
    public partial class FormAdminRetireUser : Form
    {

        BusinessLayer.UserInformation userInformation;

        public FormAdminRetireUser(BusinessLayer.UserInformation userInformation)
        {
            InitializeComponent();
            this.userInformation = userInformation;
            textBoxUserID.Text = userInformation.UserID.ToString();
            textBoxUsername.Text = userInformation.Username;
            textBoxRole.Text = userInformation.Role;
            //Set initial values of datetime pickers.
            if (userInformation.DateRetired != null)
            {
                datePicker.Value = userInformation.DateRetired.GetValueOrDefault().Date;
                timePicker.Value = userInformation.DateRetired.GetValueOrDefault();
            }
            else
            {
                datePicker.Value = DateTime.Now.Date;
                timePicker.Value = DateTime.Today + new TimeSpan(18, 00, 00);
            }
        }

        private void buttonRetireUser_Click(object sender, EventArgs e)
        {
            //Set new retirement date of User.
            BusinessLayer.AdminFacade.ChangeUserDateRetired(userInformation.UserID, datePicker.Value.Date + timePicker.Value.TimeOfDay);
            DialogResult = DialogResult.OK;
        }

        private void buttonCancelRetirement_Click(object sender, EventArgs e)
        {
            //Delete retirement date of User.
            BusinessLayer.AdminFacade.ChangeUserDateRetired(userInformation.UserID, null);
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
