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
    public partial class FormReceptionist : Form
    {

        DataLayer.Receptionist activeReceptionist;

        public FormReceptionist()
        {
            InitializeComponent();
        }

        public FormReceptionist(DataLayer.User user)
        {
            InitializeComponent();
            activeReceptionist = BusinessLayer.ReceptionistFacade.GetReceptionist(user.UserID);
            labelReceptionistName.Text = activeReceptionist.FirstName + " " + activeReceptionist.LastName;
        }

        private void searchForPatients()
        {
            BusinessLayer.PatientInformation patientSearchCriteria = new BusinessLayer.PatientInformation();
            patientSearchCriteria.FirstName = textBoxFirstName.Text;
            patientSearchCriteria.LastName = textBoxLastName.Text;
            patientSearchCriteria.PESEL = textBoxPESEL.Text;

            dataGridViewPatients.Columns.Clear();
            dataGridViewPatients.DataSource = BusinessLayer.ReceptionistFacade.GetPatients(patientSearchCriteria);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchForPatients();
        }

        private void buttonViewAllPatients_Click(object sender, EventArgs e)
        {
            dataGridViewPatients.Columns.Clear();
            dataGridViewPatients.DataSource = BusinessLayer.ReceptionistFacade.GetAllPatients();
        }

        private void buttonNewPatient_Click(object sender, EventArgs e)
        {
            FormReceptionistNewPatient formNewPatient = new FormReceptionistNewPatient();
            DialogResult res = formNewPatient.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                searchForPatients();
            }
        }
    }
}
