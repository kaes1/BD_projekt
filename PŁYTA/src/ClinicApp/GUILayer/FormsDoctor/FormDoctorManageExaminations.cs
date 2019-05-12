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
        public BusinessLayer.AppointmentInformation activeAppointment { get; set; }
        public BusinessLayer.PatientInformation activePatient { get; set; }
        public BusinessLayer.DoctorInformation activeDoctor { get; set; }

        public FormDoctorManageExaminations(BusinessLayer.AppointmentInformation actApp, BusinessLayer.PatientInformation actPat, BusinessLayer.DoctorInformation actDoc)
        {                                    
            InitializeComponent();
            //Set window title.
            this.Text = "Examinations - " + actPat.FirstName + " " + actPat.LastName;
            activeAppointment = actApp;
            activeDoctor = actDoc;
            activePatient = actPat;
            textBoxFirstName.Text = activePatient.FirstName;
            textBoxLastName.Text = activePatient.LastName;
            //Initial search.
            searchForPhysExams();
            searchForLabExams();
        }

        private void buttonBackToAppointment_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchForPhysExams()
        {
            dataGridPhysExamList.DataSource = BusinessLayer.DoctorFacade.GetPhysExamsForAppointment(activeAppointment);
            dataGridPhysExamList.Columns["ExaminationID"].Visible = false;
            dataGridPhysExamList.Columns["Comment"].Visible = false;
            //Select first exam if not empty.
            if (dataGridPhysExamList.Rows.Count > 0)
                dataGridPhysExamList.CurrentCell = dataGridPhysExamList[1, 0];
        }

        private void searchForLabExams()
        {
            dataGridViewLabExamList.DataSource = BusinessLayer.DoctorFacade.GetLabExamsForAppointment(activeAppointment);
            dataGridViewLabExamList.Columns["ExaminationID"].Visible = false;
            dataGridViewLabExamList.Columns["Comment"].Visible = false;
            //Select first exam if not empty.
            if (dataGridViewLabExamList.Rows.Count > 0)
                dataGridViewLabExamList.CurrentCell = dataGridViewLabExamList[1, 0];
        }
        
        private void dataGridPhysExamList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPhysExamList.SelectedCells.Count > 0 && dataGridPhysExamList.CurrentRow != null)
            {
                int examID = (int)dataGridPhysExamList.CurrentRow.Cells["ExaminationID"].Value;
                BusinessLayer.PhysicalExaminationInformation exam = BusinessLayer.DoctorFacade.GetPhysicalExamination(examID);
                richTextBoxResult.Text = exam.Result;
            }
        }

        private void dataGridViewLabExamList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLabExamList.SelectedCells.Count > 0 && dataGridViewLabExamList.CurrentRow != null)
            {
                int examID = (int)dataGridViewLabExamList.CurrentRow.Cells["ExaminationID"].Value;
                BusinessLayer.LabExaminationInformation exam = BusinessLayer.DoctorFacade.GetLaboratoryExamination(examID);
                richTextBoxCommentToLaborant.Text = exam.DoctorComments;
            }
        }

        //open news window for respond
        private void buttonAddPhysExamination_Click(object sender, EventArgs e)
        {
            FormDoctorPhysExam formNewPhysExam = new FormDoctorPhysExam(activeAppointment);
            DialogResult res = formNewPhysExam.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                searchForPhysExams();
            }
        }

        //opens new window for respond
        private void buttonAddLabExamination_Click(object sender, EventArgs e)
        {
            FormDoctorLabTest formNewLabExam = new FormDoctorLabTest(activeAppointment);
            DialogResult res = formNewLabExam.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                searchForLabExams();
            }
        }
    }
}
