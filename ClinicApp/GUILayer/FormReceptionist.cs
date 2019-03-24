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

        private void searchForPatients(BusinessLayer.PatientInformation patientSearchCriteria)
        {
            dataGridViewPatients.Columns.Clear();
            dataGridViewPatients.DataSource = BusinessLayer.ReceptionistFacade.GetPatients(patientSearchCriteria);
            dataGridViewPatients.Columns[0].Width = 124;
            dataGridViewPatients.Columns[1].Width = 124;
            dataGridViewPatients.Columns[2].Width = 124;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            BusinessLayer.PatientInformation patientSearchCriteria = new BusinessLayer.PatientInformation();
            patientSearchCriteria.FirstName = textBoxFirstName.Text;
            patientSearchCriteria.LastName = textBoxLastName.Text;
            patientSearchCriteria.PESEL = textBoxPESEL.Text;
            searchForPatients(patientSearchCriteria);
        }

        private void buttonViewAllPatients_Click(object sender, EventArgs e)
        {
            BusinessLayer.PatientInformation emptySearchCriteria = new BusinessLayer.PatientInformation();
            searchForPatients(emptySearchCriteria);
        }

        private void buttonNewPatient_Click(object sender, EventArgs e)
        {
            FormReceptionistNewPatient formNewPatient = new FormReceptionistNewPatient();
            DialogResult res = formNewPatient.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                //Ponownie wyszukaj pacjentów.
                BusinessLayer.PatientInformation patientSearchCriteria = new BusinessLayer.PatientInformation();
                patientSearchCriteria.FirstName = textBoxFirstName.Text;
                patientSearchCriteria.LastName = textBoxLastName.Text;
                patientSearchCriteria.PESEL = textBoxPESEL.Text;
                searchForPatients(patientSearchCriteria);
            }
        }

        private void buttonRegisterVisit_Click(object sender, EventArgs e)
        {
            BusinessLayer.PatientInformation patientInfo = new BusinessLayer.PatientInformation();
            patientInfo.FirstName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[0].Value);
            patientInfo.LastName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[1].Value);
            patientInfo.PESEL = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[2].Value);

            FormReceptionistNewAppointment formNewAppointment = new FormReceptionistNewAppointment(patientInfo);
            DialogResult res = formNewAppointment.ShowDialog(this);
        }
    }
}
