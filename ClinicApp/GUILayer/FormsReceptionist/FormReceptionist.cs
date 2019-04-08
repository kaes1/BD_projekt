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
            //Select first patient.
            dataGridViewPatients.CurrentCell = dataGridViewPatients[0, 0];
            //Initial search for appointments.
            searchForAppointments();
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
            //Select first patient.
            dataGridViewPatients.CurrentCell = dataGridViewPatients[0, 0];
            //Search and display appointments.
            searchForAppointments();
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
            dataGridViewAppointments.Columns[0].Visible = true;
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
            //Select the new patient if added.
            if (res == DialogResult.OK)
            {
                //Refresh patients.
                searchForPatients();
                foreach (DataGridViewRow row in dataGridViewPatients.Rows)
                    if (row.Cells[2].Value.ToString().Equals(formNewPatient.newPatientInformation.LastName))
                    {
                        dataGridViewPatients.CurrentCell = dataGridViewPatients[0, row.Index];
                        break;
                    }
            }
            //Dispose of form.
            formNewPatient.Dispose();
        }

        private void buttonEditPatient_Click(object sender, EventArgs e)
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
                //Create and display edit patient form.
                FormReceptionistEditPatient formEditPatient = new FormReceptionistEditPatient(patientInfo);
                DialogResult res = formEditPatient.ShowDialog(this);
                //Select the edited patient if edited.
                if (res == DialogResult.OK)
                {
                    //Refresh displayed patients.
                    searchForPatients();
                    foreach (DataGridViewRow row in dataGridViewPatients.Rows)
                        if (row.Cells[2].Value.ToString().Equals(formEditPatient.editedPatientInformation.LastName))
                        {
                            dataGridViewPatients.CurrentCell = dataGridViewPatients[0, row.Index];
                            break;
                        }
                }
                //Dispose of form.
                formEditPatient.Dispose();
            }
            else
            {
                MessageBox.Show("Please select a patient to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridViewPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            resetAppointmentSearch();
            searchForAppointments();
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
                
                //Select the new appointment if added.
                if (res == DialogResult.OK)
                {
                    //Refresh appointments.
                    searchForAppointments();

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
            //Check if any appointment is selected.
            if (dataGridViewAppointments.SelectedCells.Count > 0)
            {
                //Get patient information.
                BusinessLayer.PatientInformation patientInfo = new BusinessLayer.PatientInformation();
                patientInfo.PatientID = (int)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[0].Value);
                patientInfo.FirstName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[1].Value);
                patientInfo.LastName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[2].Value);
                patientInfo.PESEL = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[3].Value);
                //Get appointment information.
                var appointmentInfo = new BusinessLayer.ReceptionistFacade.ReceptionistAppointment();
                appointmentInfo.AppointmentID = (int)(dataGridViewAppointments.Rows[dataGridViewAppointments.CurrentCell.RowIndex].Cells[0].Value);
                appointmentInfo.Date = (DateTime)(dataGridViewAppointments.Rows[dataGridViewAppointments.CurrentCell.RowIndex].Cells[1].Value);
                appointmentInfo.Status = (string)(dataGridViewAppointments.Rows[dataGridViewAppointments.CurrentCell.RowIndex].Cells[2].Value);
                appointmentInfo.DoctorFirstName = (string)(dataGridViewAppointments.Rows[dataGridViewAppointments.CurrentCell.RowIndex].Cells[3].Value);
                appointmentInfo.DoctorLastName = (string)(dataGridViewAppointments.Rows[dataGridViewAppointments.CurrentCell.RowIndex].Cells[4].Value);
                //Check if appointment has status REG.
                if (appointmentInfo.Status != "REG")
                {
                    MessageBox.Show("You can only cancel registered appointments that have not begun yet.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Create and display cancel appointment form.
                FormReceptionistCancelAppointment formCancelAppointment = new FormReceptionistCancelAppointment(patientInfo, appointmentInfo);
                DialogResult res = formCancelAppointment.ShowDialog(this);
                //Select the canceled appointment if canceled.
                if (res == DialogResult.OK)
                {
                    //Refresh appointments.
                    searchForAppointments();
                    foreach (DataGridViewRow row in dataGridViewAppointments.Rows)
                        if (row.Cells[0].Value.Equals(formCancelAppointment.canceledAppointment.AppointmentID))
                        {
                            dataGridViewAppointments.CurrentCell = dataGridViewAppointments[1, row.Index];
                            break;
                        }
                }
                formCancelAppointment.Dispose();
            }
            else
            {
                MessageBox.Show("Please select an appointment to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonSearchAppointments_Click(object sender, EventArgs e)
        {
            //Check if any patient is selected.
            if (dataGridViewPatients.SelectedCells.Count > 0)
                searchForAppointments();
        }
    }
}
