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
    public partial class FormDoctor : Form
    {
        public BusinessLayer.DoctorInformation activeDoctorInformation { get; set; }

        public FormDoctor(int userID)
        {
            activeDoctorInformation = BusinessLayer.DoctorFacade.GetDoctor(userID);
            InitializeComponent();
            //Set window title.
            this.Text = "Doctor - " + activeDoctorInformation.FirstName + " " + activeDoctorInformation.LastName;
            searchForAppointmentsForToday();
        }

        private void searchForAppointmentsForToday()
        {
            //Set date to today and mark date as checked.
            dateTimePicker.Value = DateTime.Now;
            dateTimePicker.Checked = true;
            //Search for appointments.
            searchForAppointments();
        }

        private void searchForAppointments()
        {
            //Get search criteria.
            BusinessLayer.DoctorFacade.DoctorAppointment appointmentSearchCriteria = new BusinessLayer.DoctorFacade.DoctorAppointment();
            appointmentSearchCriteria.PatientFirstName = textBoxFirstName.Text;
            appointmentSearchCriteria.PatientLastName = textBoxLastName.Text;
            appointmentSearchCriteria.PatientPESEL = textBoxPESEL.Text;
            if (dateTimePicker.Checked)
                appointmentSearchCriteria.DateOfAppointment = dateTimePicker.Value.Date;
            if (!string.IsNullOrWhiteSpace(comboBoxStatus.Text))
                appointmentSearchCriteria.Status = comboBoxStatus.Text;

            //Search and display.
            dataGridViewAppointments.Columns.Clear();
            dataGridViewAppointments.AutoGenerateColumns = true;
            dataGridViewAppointments.DataSource = BusinessLayer.DoctorFacade.GetAppointments(appointmentSearchCriteria, activeDoctorInformation.DoctorID);
            dataGridViewAppointments.AutoGenerateColumns = false;
            dataGridViewAppointments.Columns["AppointmentID"].Visible = false;
            dataGridViewAppointments.Columns[1].Width = 120;
            dataGridViewAppointments.Columns[2].Width = 110;
            dataGridViewAppointments.Columns[3].Width = 110;
            //Select first appointment if not empty.
            if (dataGridViewAppointments.Rows.Count > 0)
                dataGridViewAppointments.CurrentCell = dataGridViewAppointments[1, 0];
        }

        private void buttonBeginAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Please select an appointment first.");
            }
            else
            {
                string st = (string)(dataGridViewAppointments.Rows[dataGridViewAppointments.CurrentCell.RowIndex].Cells[5].Value);
                if (st == "CANC")
                {
                    MessageBox.Show("This appointment has been canceled.");
                    return;
                }
                String pesel = (String)dataGridViewAppointments.SelectedRows[0].Cells[4].Value;
                int appointmentID = (int)(dataGridViewAppointments.Rows[dataGridViewAppointments.CurrentCell.RowIndex].Cells[0].Value);

                var doctorAppointmentForm = new FormDoctorAppointment(BusinessLayer.DoctorFacade.GetAppointmentByID(appointmentID), BusinessLayer.DoctorFacade.GetPatientByPesel(pesel));
                doctorAppointmentForm.activeDoctor = activeDoctorInformation;
                DialogResult res = doctorAppointmentForm.ShowDialog();

                searchForAppointments();
            }
        }

        private void buttonViewAllForToday_Click(object sender, EventArgs e)
        {
            searchForAppointmentsForToday();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchForAppointments();
        }
    }
}
