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
        public BusinessLayer.AppointmentInformation actualAppointment { get; set; }
        public BusinessLayer.PatientInformation actualPatient { get; set; }
        public BusinessLayer.DoctorInformation actualDoctor{ get; set; }

        public FormDoctorManageExaminations(BusinessLayer.AppointmentInformation actApp, BusinessLayer.PatientInformation actPat, BusinessLayer.DoctorInformation actDoc)
            {                                    
            InitializeComponent();
            actualAppointment = actApp;
            actualDoctor = actDoc;
            actualPatient = actPat;
            textBoxFirstName.Text = actualPatient.FirstName;
            textBoxLastName.Text = actualPatient.LastName;
            dataGridPhysExamList.DataSource = BusinessLayer.DoctorFacade.GetTodaysPhysExam(actualAppointment);
            dataGridViewLabExamList.DataSource = BusinessLayer.DoctorFacade.GetTodaysLabExam(actualAppointment);
            dataGridPhysExamList.Columns["ExaminationID"].Visible = false;
            dataGridPhysExamList.Columns["Comment"].Visible = false;
            dataGridViewLabExamList.Columns["ExaminationID"].Visible = false;
            dataGridViewLabExamList.Columns["Comment"].Visible = false;
        }

        private void buttonBackToAppointment_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //display selected PHISICAL examination's description
        private void dataGridPhysExamList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int examID = (int)dataGridPhysExamList.SelectedRows[0].Cells["ExaminationID"].Value;
            BusinessLayer.PhysicalExaminationInformation exam = BusinessLayer.DoctorFacade.GetPhysicalExamination(examID);
            richTextBoxResult.Text = exam.Result;
        }

        //display selected LABORATORY examination's description
        private void dataGridViewLabExamList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int examID = (int)dataGridViewLabExamList.SelectedRows[0].Cells["ExaminationID"].Value;
            BusinessLayer.LabExaminationInformation exam = BusinessLayer.DoctorFacade.GetLaboratoryExamination(examID);
            richTextBoxCommentToLaborant.Text = exam.Result;
        }

        //open news window for respond
        private void buttonAddPhysExamination_Click(object sender, EventArgs e)
        {
            FormDoctorPhysExam formNewPhysExam = new FormDoctorPhysExam(actualAppointment);
            DialogResult res = formNewPhysExam.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                dataGridPhysExamList.DataSource = BusinessLayer.DoctorFacade.GetTodaysPhysExam(actualAppointment);
            }
        }

        //opens new window for respond
        private void buttonAddLabExamination_Click(object sender, EventArgs e)
        {
            FormDoctorLabTest formNewLabExam = new FormDoctorLabTest(actualAppointment);
            DialogResult res = formNewLabExam.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                dataGridViewLabExamList.DataSource = BusinessLayer.DoctorFacade.GetTodaysLabExam(actualAppointment);
            }
        }

        private void dataGridPhysExamList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridPhysExamList.CurrentRow != null)
            {
                try
                {
                    int examID = (int)dataGridPhysExamList.CurrentRow.Cells["ExaminationID"].Value;
                    BusinessLayer.PhysicalExaminationInformation exam = BusinessLayer.DoctorFacade.GetPhysicalExamination(examID);
                    richTextBoxResult.Text = exam.Result;
                }
                catch(Exception)
                {
                    //It's not an error
                }
            }
        }

        private void dataGridViewLabExamList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewLabExamList.CurrentRow != null)
            {
                try
                {
                    int examID = (int)dataGridViewLabExamList.CurrentRow.Cells["ExaminationID"].Value;
                    BusinessLayer.LabExaminationInformation exam = BusinessLayer.DoctorFacade.GetLaboratoryExamination(examID);
                    richTextBoxCommentToLaborant.Text = exam.Result;
                }
                catch (Exception)
                {
                    //It's not an error
                }
            }
        }
    }
}
