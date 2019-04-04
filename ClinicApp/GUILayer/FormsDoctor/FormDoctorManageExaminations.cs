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

        public FormDoctorManageExaminations()
        {
            InitializeComponent();
            //show all added examinations
           // dataGridPhysExamList.DataSource = BusinessLayer.DoctorFacade.getExaminations(String type);
            //dataGridViewLabExamList.DataSource = BusinessLayer.DoctorFacade.getExaminations(String type);
        }

        private void buttonBackToAppointment_Click(object sender, EventArgs e)
        {
            DoctorAppointmentRef.Show();
            this.Close();
        }

        private void buttonPatientHistory_Click(object sender, EventArgs e)
        {
            var doctorHistoryForm = new FormsDoctor.FormDoctorHistory();
            doctorHistoryForm.DoctorAppointmentRef = DoctorAppointmentRef;
            doctorHistoryForm.actualPatient = actualPatient;
            doctorHistoryForm.actualAppointment = actualAppointment;
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
