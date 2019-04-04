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

        public FormDoctor()
        {
            InitializeComponent();
        }

        public FormDoctor(int userID)
        {
            InitializeComponent();
            activeDoctorInformation = BusinessLayer.DoctorFacade.GetDoctor(userID);
            labelDoctorName.Text = activeDoctorInformation.FirstName + " " + activeDoctorInformation.LastName;
        }

        public FormDoctor(BusinessLayer.DoctorInformation doc)
        {
            InitializeComponent();
            activeDoctorInformation = doc;
            labelDoctorName.Text = activeDoctorInformation.FirstName + " " + activeDoctorInformation.LastName;
        }

        //Move to doctorVisitform.
        private void buttonSelectPatient_Click(object sender, EventArgs e)
        {

            String pesel = (String)dataGridViewPatients.SelectedRows[0].Cells[3].Value;
            DateTime date = (DateTime)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[0].Value);
            this.Hide();
            var doctorAppointmentForm = new FormDoctorAppointment(BusinessLayer.DoctorFacade.getAppointmentByPeselAndDate(pesel, date), BusinessLayer.DoctorFacade.getPatientByPesel(pesel));
            doctorAppointmentForm.actualDoctor = activeDoctorInformation;
            doctorAppointmentForm.Show();
            //this.Close();
        }

        private void buttonViewAllForToday_Click(object sender, EventArgs e)
        {
            dataGridViewPatients.Columns.Clear();
            dataGridViewPatients.DataSource = BusinessLayer.DoctorFacade.GetAppointmentsForToday(activeDoctorInformation.DoctorID);
            dataGridViewPatients.Columns.Remove("AppointmentID");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewPatients.Columns.Clear();
            BusinessLayer.DoctorAppointment searchParams = new BusinessLayer.DoctorAppointment()
            {
                DateOfAppointment = dateTimePicker.Value,
                PatientFirstName = textBoxFirstName.Text,
                PatientLastName = textBoxLastName.Text,
                PatientPesel = textBoxPESEL.Text,
                Status = textBoxStatus.Text
            };
            dataGridViewPatients.DataSource = BusinessLayer.DoctorFacade.GetSearch(searchParams, activeDoctorInformation.DoctorID);
            dataGridViewPatients.Columns.Remove("AppointmentID");

        }
    }
}
