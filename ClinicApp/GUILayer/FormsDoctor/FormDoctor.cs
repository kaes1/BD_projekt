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
            //Hide this form.
            this.Hide();
            //Create a new doctorVisitForm.
            var doctorVisitForm = new FormDoctorVisit();
            //Set reference to this form.
            doctorVisitForm.prevPageRef = this;
            //Add closing loginForm to the closing event of receptionistForm.
            //doctorVisitForm.FormClosed += (s, args) => this.Close();
            //Show the new doctorVisitForm.
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
