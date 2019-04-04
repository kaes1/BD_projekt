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
        BusinessLayer.DoctorInformation activeDoctorInformation;

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

        //Move to doctorVisitform.
        private void buttonSelectPatient_Click(object sender, EventArgs e)
        {
           
            String pesel = (String)dataGridViewPatients.SelectedRows[0].Cells[3].Value;
            DateTime date = (DateTime)(dataGridViewPatients.Rows[dataGridViewPatients.CurrentCell.RowIndex].Cells[0].Value);
            this.Hide();
            var doctorVisitForm = new FormDoctorVisit(BusinessLayer.DoctorFacade.getAppointmentByPeselAndDate(pesel, date),BusinessLayer.DoctorFacade.getPatientByPesel(pesel));
            doctorVisitForm.prevPageRef = this;
            //doctorVisitForm.actualPatient = BusinessLayer.DoctorFacade.getPatientByPesel(pesel);
            //doctorVisitForm.actualAppointment = BusinessLayer.DoctorFacade.getAppointmentByPeselAndDate(pesel, date);
            doctorVisitForm.Show();
        }

        private void buttonViewAllForToday_Click(object sender, EventArgs e)
        {
            dataGridViewPatients.Columns.Clear();
            dataGridViewPatients.DataSource = BusinessLayer.DoctorFacade.GetAppointmentsForToday(1);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {          
            dataGridViewPatients.Columns.Clear();
            BusinessLayer.DoctorAppointment searchParams = new BusinessLayer.DoctorAppointment()
            {
                DateRegistered = dateTimePicker.Value,
                PatientFirstName = textBoxFirstName.Text,
                PatientLastName = textBoxLastName.Text,
                PatientPesel = textBoxPESEL.Text,
                Status = textBoxStatus.Text              
            };
            dataGridViewPatients.DataSource = BusinessLayer.DoctorFacade.GetSearch(searchParams, activeDoctorInformation.DoctorID);
        }
    }
}
