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
        public FormReceptionistNewPatient()
        {
            InitializeComponent();
        }

        private void buttonAddPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text) ||
                string.IsNullOrWhiteSpace(textBoxPESEL.Text))
            {
                MessageBox.Show("Please fill out patient's information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (textBoxPESEL.Text.Length != 11 /* Dodać sprawdzanie poprawnosci PESEL */)
            {
                MessageBox.Show("PESEL not correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                BusinessLayer.PatientInformation newPatient = new BusinessLayer.PatientInformation();
                newPatient.FirstName = textBoxFirstName.Text;
                newPatient.LastName = textBoxLastName.Text;
                newPatient.PESEL = textBoxPESEL.Text;
                //Dodanie nowego pacjenta do BD.
                // DO ZROBIENIA
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
