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
    public partial class FormReceptionistNewPatient : Form
    {

        public BusinessLayer.PatientInformation newPatientInformation;

        public FormReceptionistNewPatient()
        {
            InitializeComponent();
        }

        private bool correctInformation()
        {
            //Check if any field is empty.
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPESEL.Text))
            {
                MessageBox.Show("FirstName, LastName and PESEL must be filled.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Check if length is correct.
            if (textBoxPESEL.Text.Length != 11)
            {
                MessageBox.Show("PESEL number must be 11 digits long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //Check if all characters are numbers.
            foreach (char c in textBoxPESEL.Text)
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("PESEL number must be made up of digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            //Parse for all digits.
            int[] digits = new int[11];
            for (int i = 0; i < 11; i++)
                digits[i] = (int)Char.GetNumericValue(textBoxPESEL.Text[i]);
            //Calculate control digit.
            int controlDigit = (9 * digits[0] + 7 * digits[1] + 3 * digits[2] + 1 * digits[3]
                              + 9 * digits[4] + 7 * digits[5] + 3 * digits[6] + 1 * digits[7]
                              + 9 * digits[8] + 7 * digits[9]) % 10;
            //Check control digit.
            if (controlDigit != digits[10])
            {
                MessageBox.Show("PESEL number is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }  
            
            //Check if 5th and 6th digits are a correct day.
            if (digits[4] * 10 + digits[5] > 31)
            {
                MessageBox.Show("PESEL number is incorrect. Digits 5-6 are not a correct day.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            //Check if patient information is correct.
            if (!correctInformation())
                 return;

            newPatientInformation = new BusinessLayer.PatientInformation();
            newPatientInformation.PESEL = textBoxPESEL.Text;
            newPatientInformation.FirstName = textBoxFirstName.Text.Trim();
            newPatientInformation.LastName = textBoxLastName.Text.Trim();
            //Check if patient with that PESEL already exists.
            if (BusinessLayer.ReceptionistFacade.ExistsPatient(newPatientInformation))
            {
                MessageBox.Show("Patient with that PESEL already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BusinessLayer.ReceptionistFacade.AddPatient(newPatientInformation);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
