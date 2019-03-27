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
        BusinessLayer.ReceptionistInformation activeReceptionistInformation;

        public FormReceptionist(int userID)
        {
            InitializeComponent();
            activeReceptionistInformation = BusinessLayer.ReceptionistFacade.GetReceptionist(userID);
            //Display active receptionist.
            labelReceptionistName.Text = activeReceptionistInformation.FirstName + " " + activeReceptionistInformation.LastName;
            //Display all patients.
            BusinessLayer.PatientInformation emptySearchCriteria = new BusinessLayer.PatientInformation();
            searchForPatients(emptySearchCriteria);
        }

        private void searchForPatients(BusinessLayer.PatientInformation patientSearchCriteria)
        {
            dataGridViewPatients.Columns.Clear();
            dataGridViewPatients.DataSource = BusinessLayer.ReceptionistFacade.GetPatients(patientSearchCriteria);
            dataGridViewPatients.Columns[0].Width = 72;
            dataGridViewPatients.Columns[1].Width = 124;
            dataGridViewPatients.Columns[2].Width = 124;
            dataGridViewPatients.Columns[3].Width = 124;
        }

        private void showAppointments()
        {
            //Check if any patient is selected.
            if (dataGridViewPatients.SelectedCells.Count > 0)
            {
                BusinessLayer.PatientInformation patientInfo = new BusinessLayer.PatientInformation();
                patientInfo.PatientID = (int)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[0].Value);
                patientInfo.FirstName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[1].Value);
                patientInfo.LastName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[2].Value);
                patientInfo.PESEL = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[3].Value);

                var appointments = BusinessLayer.ReceptionistFacade.GetAppointments(patientInfo);
                dataGridViewAppointments.Columns.Clear();
                dataGridViewAppointments.DataSource = appointments;
                dataGridViewAppointments.Columns[0].Visible = false;
                dataGridViewAppointments.Columns[1].Width = 92;
                dataGridViewAppointments.Columns[2].Width = 92;
                dataGridViewAppointments.Columns[3].Width = 60;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            BusinessLayer.PatientInformation patientSearchCriteria = new BusinessLayer.PatientInformation();
            patientSearchCriteria.FirstName = textBoxFirstName.Text;
            patientSearchCriteria.LastName = textBoxLastName.Text;
            patientSearchCriteria.PESEL = textBoxPESEL.Text;
            searchForPatients(patientSearchCriteria);
        }

        private void buttonNewPatient_Click(object sender, EventArgs e)
        {
            FormReceptionistNewPatient formNewPatient = new FormReceptionistNewPatient();
            DialogResult res = formNewPatient.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                //Ponownie wyszukaj pacjentów (by wyświetlić nowego pacjenta).
                BusinessLayer.PatientInformation patientSearchCriteria = new BusinessLayer.PatientInformation();
                patientSearchCriteria.FirstName = textBoxFirstName.Text;
                patientSearchCriteria.LastName = textBoxLastName.Text;
                patientSearchCriteria.PESEL = textBoxPESEL.Text;
                searchForPatients(patientSearchCriteria);
            }
        }

        private void buttonNewAppointment_Click(object sender, EventArgs e)
        {
            //Check if any patient is selected.
            if (dataGridViewPatients.SelectedCells.Count > 0)
            {
                BusinessLayer.PatientInformation patientInfo = new BusinessLayer.PatientInformation();
                patientInfo.PatientID = (int)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[0].Value);
                patientInfo.FirstName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[1].Value);
                patientInfo.LastName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[2].Value);
                patientInfo.PESEL = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[3].Value);

                FormReceptionistNewAppointment formNewAppointment = new FormReceptionistNewAppointment(patientInfo, activeReceptionistInformation);
                DialogResult res = formNewAppointment.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Please select a patient to add an appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showAppointments();
        }
    }
}
