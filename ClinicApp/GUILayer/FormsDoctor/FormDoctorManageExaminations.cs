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
    public partial class FormDoctorManageExaminations : Form
    {
        public Form DoctorAppointmentRef { get; set; }
        public BusinessLayer.AppointmentInformation actualAppointment { get; set; }
        public BusinessLayer.PatientInformation actualPatient { get; set; }
        public BusinessLayer.DoctorInformation actualDoctor{ get; set; }

        public FormDoctorManageExaminations(BusinessLayer.AppointmentInformation actApp, BusinessLayer.PatientInformation actPat, BusinessLayer.DoctorInformation actDoc)
            {                                    
            InitializeComponent();
            actualAppointment = actApp;
            actualDoctor = actDoc;
            actualAppointment = actualAppointment;
            dataGridPhysExamList.DataSource = BusinessLayer.DoctorFacade.GetTodaysLabExam(actualAppointment);
            dataGridViewLabExamList.DataSource = BusinessLayer.DoctorFacade.GetTodaysPhysExam(actualAppointment);
        }

        private void buttonBackToAppointment_Click(object sender, EventArgs e)
        {
            DoctorAppointmentRef.Show();
            this.Close();
        }

        private void buttonPatientHistory_Click(object sender, EventArgs e)
        {
            var doctorHistoryForm = new FormsDoctor.FormDoctorHistory(actualAppointment, actualPatient, actualDoctor);
            doctorHistoryForm.Show();
            this.Close();
        }

        //display selected PHISICAL examination's description
        private void dataGridPhysExamList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //display selected LABORATORY examination's description
        private void dataGridViewLabExamList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //open news window for respond
        private void buttonAddPhysExamination_Click(object sender, EventArgs e)
        {
            FormDoctorPhysExam formNewPhysExam = new FormDoctorPhysExam();
            DialogResult res = formNewPhysExam.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                
            }
        }

        //opens new window for respond
        private void buttonAddLabExamination_Click(object sender, EventArgs e)
        {

        }
    }
}
