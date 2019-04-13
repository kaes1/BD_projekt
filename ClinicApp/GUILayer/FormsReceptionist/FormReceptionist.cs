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
            activeReceptionistInformation = BusinessLayer.ReceptionistFacade.GetReceptionist(userID);
            InitializeComponent();
            //Set window title.
            this.Text = "Receptionist - " + activeReceptionistInformation.FirstName + " " + activeReceptionistInformation.LastName;
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
            //Select first patient if not empty.
            if (dataGridViewPatients.Rows.Count > 0)
                dataGridViewPatients.CurrentCell = dataGridViewPatients[0, 0];
            //Search for appointments.
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
            List<BusinessLayer.ReceptionistFacade.ReceptionistAppointment> appointments;

            //Check if any patient is selected.
            if (dataGridViewPatients.SelectedCells.Count > 0 && dataGridViewPatients.CurrentRow != null)
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
                //Search for appointments.
                appointments = BusinessLayer.ReceptionistFacade.GetAppointments(patientInfo, appointmentDate, status, textBoxDoctorLastName.Text);
            }
            else
            {
                //Get an empty list.
                appointments = new List<BusinessLayer.ReceptionistFacade.ReceptionistAppointment>();
            } 
            //Display the appointments.
            dataGridViewAppointments.Columns.Clear();
            dataGridViewAppointments.DataSource = appointments;
            dataGridViewAppointments.Columns[4].Visible = false;
            dataGridViewAppointments.Columns[0].Width = 124;
            dataGridViewAppointments.Columns[1].Width = 72;
            dataGridViewAppointments.Columns[2].Width = 124;
            dataGridViewAppointments.Columns[3].Width = 124;
            //Select first appointment if not empty.
            if (dataGridViewAppointments.Rows.Count > 0)
                dataGridViewAppointments.CurrentCell = dataGridViewAppointments[0, 0];
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
                    if (row.Cells[3].Value.ToString().Equals(formNewPatient.newPatientInformation.PESEL))
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
                        if ((int)row.Cells[0].Value == formEditPatient.editedPatientInformation.PatientID)
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

        private void dataGridViewPatients_SelectionChanged(object sender, EventArgs e)
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
                BusinessLayer.PatientInformation patientInformation = new BusinessLayer.PatientInformation();
                patientInformation.PatientID = (int)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[0].Value);
                patientInformation.FirstName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[1].Value);
                patientInformation.LastName = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[2].Value);
                patientInformation.PESEL = (string)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[3].Value);
                //Create and display new appointment form.
                FormReceptionistNewAppointment formNewAppointment = new FormReceptionistNewAppointment(patientInformation, activeReceptionistInformation);
                DialogResult res = formNewAppointment.ShowDialog(this);
                
                //Select the new appointment if added.
                if (res == DialogResult.OK)
                {
                    //Refresh appointments.
                    searchForAppointments();
                    //Find and select the new appointment.
                    foreach (DataGridViewRow row in dataGridViewAppointments.Rows)
                        if (row.Cells[2].Value.Equals(formNewAppointment.newAppointment.DoctorFirstName)
                           &&
                           row.Cells[3].Value.Equals(formNewAppointment.newAppointment.DoctorLastName)
                           &&
                           row.Cells[0].Value.ToString().Equals(formNewAppointment.newAppointment.Date.ToString())
                           &&
                           row.Cells[1].Value.Equals("REG"))
                        {
                            dataGridViewAppointments.CurrentCell = dataGridViewAppointments[1, row.Index];
                            break;
                        }                   
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
                appointmentInfo.AppointmentID = (int)(dataGridViewAppointments.Rows[dataGridViewAppointments.CurrentCell.RowIndex].Cells[4].Value);
                appointmentInfo.Date = (DateTime)(dataGridViewAppointments.Rows[dataGridViewAppointments.CurrentCell.RowIndex].Cells[0].Value);
                appointmentInfo.Status = (string)(dataGridViewAppointments.Rows[dataGridViewAppointments.CurrentCell.RowIndex].Cells[1].Value);
                appointmentInfo.DoctorFirstName = (string)(dataGridViewAppointments.Rows[dataGridViewAppointments.CurrentCell.RowIndex].Cells[2].Value);
                appointmentInfo.DoctorLastName = (string)(dataGridViewAppointments.Rows[dataGridViewAppointments.CurrentCell.RowIndex].Cells[3].Value);
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
                        if (row.Cells[4].Value.Equals(formCancelAppointment.canceledAppointment.AppointmentID))
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
