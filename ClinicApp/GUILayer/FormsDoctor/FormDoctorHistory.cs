using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILayer.FormsDoctor
{
    public partial class FormDoctorHistory : Form
    {
        public Form DoctorAppointmentRef { get; set; }
        public BusinessLayer.AppointmentInformation actualAppointment { get; set; }
        public BusinessLayer.PatientInformation actualPatient { get; set; }
        public BusinessLayer.DoctorInformation actualDoctor{ get; set; }

        public FormDoctorHistory(BusinessLayer.AppointmentInformation actApp, BusinessLayer.PatientInformation actPat, BusinessLayer.DoctorInformation actDoc)
        {
            InitializeComponent();
            actualAppointment = actApp;
            actualDoctor = actDoc;
            actualPatient = actPat;
            dataGridViewAppoinmentsExaminations.DataSource = BusinessLayer.DoctorFacade.ShowPatientPrevApp(actualPatient);
        }

        private void buttonBackToAppointment_Click(object sender, EventArgs e)
        {
            //TODO nie widzi formy z wizytą? why? 
            DoctorAppointmentRef.Show();
            this.Close();
        }

        private void buttonManageExaminations_Click(object sender, EventArgs e)
        {
            var doctorExaminationsForm = new FormsDoctor.FormDoctorManageExaminations(actualAppointment, actualPatient, actualDoctor);
            doctorExaminationsForm.DoctorAppointmentRef = DoctorAppointmentRef;
            doctorExaminationsForm.Show();
            this.Close();
        }

        private void buttonPreviousExaminations_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewAppoinmentsExaminations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //TODO on click update result box
        }

        private void buttonPreviousRegistry_Click(object sender, EventArgs e)
        {
            //TODO check actual selected app and show previous
        }

        private void buttonNextRegistry_Click(object sender, EventArgs e)
        {
            //TODO check actual selected app and show next
        }
    }
}
