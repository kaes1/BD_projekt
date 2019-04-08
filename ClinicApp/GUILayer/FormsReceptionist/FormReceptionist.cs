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
            //Initial search for patients.
            searchForPatients();
        }

        private void searchForPatients()
        {
            //Get search criteria.
            BusinessLayer.PatientInformation patientSearchCriteria = new BusinessLayer.PatientInformation();
            patientSearchCriteria.FirstName = textBoxFirstName.Text;
            patientSearchCriteria.LastName = textBoxLastName.Text;
            patientSearchCriteria.PESEL = textBoxPESEL.Text;
            //Search and display.
            dataGridViewPatients.Columns.Clear();
            dataGridViewPatients.DataSource = BusinessLayer.ReceptionistFacade.GetPatients(patientSearchCriteria);
            dataGridViewPatients.Columns[0].Width = 72;
            dataGridViewPatients.Columns[1].Width = 124;
            dataGridViewPatients.Columns[2].Width = 124;
            dataGridViewPatients.Columns[3].Width = 124;
            //Reorder columns.
            dataGridViewPatients.Columns[1].DisplayIndex = 0;
            dataGridViewPatients.Columns[2].DisplayIndex = 1;
            dataGridViewPatients.Columns[3].DisplayIndex = 2;
            dataGridViewPatients.Columns[0].DisplayIndex = 3;
        }

        private void resetAppointmentSearch()
        {
            dateTimePickerAppointmentDate.Checked = false;
            textBoxDoctorLastName.Text = "";
            comboBoxStatus.SelectedIndex = 0;
        }

        private void searchForAppointments()
        {
            //Get search criteria.
            BusinessLayer.PatientInformation patientInfo = new BusinessLayer.PatientInformation();
            patientInfo.PatientID = (int)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[0].Value);
            patientInfo.FirstName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[1].Value);
            patientInfo.LastName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[2].Value);
            patientInfo.PESEL = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[3].Value);
            DateTime? appointmentDate = null;
            if (dateTimePickerAppointmentDate.Checked)
                appointmentDate = dateTimePickerAppointmentDate.Value;
            string status = null;
            if (!string.IsNullOrWhiteSpace(comboBoxStatus.Text))
                status = comboBoxStatus.Text;
            //Search and display.
            dataGridViewAppointments.Columns.Clear();
            dataGridViewAppointments.DataSource = BusinessLayer.ReceptionistFacade.GetAppointments(patientInfo, appointmentDate, status, textBoxDoctorLastName.Text);
            dataGridViewAppointments.Columns[0].Visible = false;
            dataGridViewAppointments.Columns[1].Width = 124;
            dataGridViewAppointments.Columns[2].Width = 72;
            dataGridViewAppointments.Columns[3].Width = 124;
            dataGridViewAppointments.Columns[4].Width = 124;
        }

        private void buttonSearchPatients_Click(object sender, EventArgs e)
        {
            searchForPatients();
        }

        private void buttonNewPatient_Click(object sender, EventArgs e)
        {
            //Create and display new patient form.
            FormReceptionistNewPatient formNewPatient = new FormReceptionistNewPatient();
            DialogResult res = formNewPatient.ShowDialog(this);
            //Refresh patients.
            searchForPatients();
            //Select the new patient if added.
            if (res == DialogResult.OK)
                foreach (DataGridViewRow row in dataGridViewPatients.Rows)
                    if (row.Cells[2].Value.ToString().Equals(formNewPatient.newPatientInformation.LastName))
                    {
                        dataGridViewPatients.CurrentCell = dataGridViewPatients[0, row.Index];
                        break;
                    }
            //Dispose of form.
            formNewPatient.Dispose();
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
        {
            //Create and display edit patient form.

            //Refresh patients.
            searchForPatients();

            //Dispose of form.
        }

        private void buttonNewAppointment_Click(object sender, EventArgs e)
        {
            //Check if any patient is selected.
            if (dataGridViewPatients.SelectedCells.Count > 0)
            {
                //Get patient information.
                BusinessLayer.PatientInformation patientInfo = new BusinessLayer.PatientInformation();
                patientInfo.PatientID = (int)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[0].Value);
                patientInfo.FirstName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[1].Value);
                patientInfo.LastName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[2].Value);
                patientInfo.PESEL = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[3].Value);
                //Create and display new appointment form.
                FormReceptionistNewAppointment formNewAppointment = new FormReceptionistNewAppointment(patientInfo, activeReceptionistInformation);
                DialogResult res = formNewAppointment.ShowDialog(this);
                //Refresh appointments.
                searchForAppointments();
                //Select the new patient if added.
                if (res == DialogResult.OK)
                {

                }
                //Dispose of form.
                formNewAppointment.Dispose();
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
            resetAppointmentSearch();
            searchForAppointments();
        }

        private void buttonSearchAppointments_Click(object sender, EventArgs e)
        {
            //Check if any patient is selected.
            if (dataGridViewPatients.SelectedCells.Count > 0)
                searchForAppointments();
        }


    }
}
