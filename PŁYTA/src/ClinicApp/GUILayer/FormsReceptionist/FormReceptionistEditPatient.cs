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
    public partial class FormReceptionistEditPatient : Form
    {
        public BusinessLayer.PatientInformation editedPatientInformation;

        public FormReceptionistEditPatient(BusinessLayer.PatientInformation patientInformation)
        {
            InitializeComponent();
            //Set window title.
            this.Text = "Edit Patient";
            editedPatientInformation = patientInformation;
            textBoxFirstName.Text = patientInformation.FirstName;
            textBoxLastName.Text = patientInformation.LastName;
            textBoxPESEL.Text = patientInformation.PESEL;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            //Check if first name or last name textbox is empty.
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text))
            {
                MessageBox.Show("First Name and Last Name must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BusinessLayer.ReceptionistFacade.ChangePatientInfo(editedPatientInformation, textBoxFirstName.Text.Trim(), textBoxLastName.Text.Trim());
            editedPatientInformation.FirstName = textBoxFirstName.Text.Trim();
            editedPatientInformation.LastName = textBoxLastName.Text.Trim();
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
