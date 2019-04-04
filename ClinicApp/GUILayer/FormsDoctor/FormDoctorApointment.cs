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
    public partial class FormDoctorAppointment : Form
    {
        public BusinessLayer.AppointmentInformation actualAppointment { get; set; }
        public BusinessLayer.PatientInformation actualPatient { get; set; }
        public BusinessLayer.DoctorInformation actualDoctor { get; set; }

        public FormDoctorAppointment()
        {
            InitializeComponent();
        }

        public FormDoctorAppointment(BusinessLayer.AppointmentInformation app, BusinessLayer.PatientInformation pat)
        {
            InitializeComponent();
            //set act app and patient
            actualAppointment = app;
            actualPatient = pat;

            //set patient name i lastname
            textBoxFirstName.Text = actualPatient.FirstName;
            textBoxLastName.Text = actualPatient.LastName;

            //get new decsription if there was a change
            actualAppointment = BusinessLayer.DoctorFacade.GetActAppInfo(app);
            richTextBoxDescription.Text = actualAppointment.Description;
            richTextBoxDiagnosis.Text = actualAppointment.Diagnosis;
                
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Show the previous form.
            FormDoctor formDoctor = new FormDoctor(actualDoctor);
            formDoctor.Show();
            this.Close();
        }

        private void buttonAddPhysExamination_Click(object sender, EventArgs e)
        {
            var PhysExamForm = new FormDoctorPhysExam(actualAppointment);
            PhysExamForm.Show();
        }

        private void buttonAddLabTest_Click(object sender, EventArgs e)
        {
            var LabTestForm = new FormsDoctor.FormDoctorLabTest(actualAppointment);
            LabTestForm.Show();
        }

        private void buttonPatientHistory_Click(object sender, EventArgs e)
        {
            var doctorHistoryForm = new FormsDoctor.FormDoctorHistory(actualAppointment, actualPatient, actualDoctor);
            this.Hide();
            DialogResult res = doctorHistoryForm.ShowDialog(this);
            if (res == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void buttonManageExaminations_Click(object sender, EventArgs e)
        {
            var doctorExaminationsForm = new FormsDoctor.FormDoctorManageExaminations(actualAppointment, actualPatient, actualDoctor);
            this.Hide();
            DialogResult res = doctorExaminationsForm.ShowDialog(this);
            if (res == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void buttonBeginAppointment_Click(object sender, EventArgs e)
        {
            if (buttonBeginAppointment.Text != "End")
            {
                //unlock buttons and change beginButton to endButton
                buttonBeginAppointment.Enabled = false;
                buttonBack.Enabled = false;
                buttonCancelAppointment.Enabled = true;
                richTextBoxDescription.Enabled = true;
                richTextBoxDiagnosis.Enabled = true;
                buttonPatientHistory.Enabled = true;
                buttonManageExaminations.Enabled = true;
                buttonBeginAppointment.Text = "End";

                //set app status as BEG
                BusinessLayer.DoctorFacade.SetAppStatus(actualAppointment, "BEG");
            }
            else
            {
                //TODO ZAKONCZ WIZYTE
            }
        }

        private void buttonEndAppointment_Click(object sender, EventArgs e)
        {

            actualAppointment.Diagnosis = richTextBoxDiagnosis.Text;
            actualAppointment.Description = richTextBoxDescription.Text;
            BusinessLayer.DoctorFacade.completeAppointment(actualAppointment);
        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {
            FormsDoctor.FormDoctorAppCancelled appCancp = new FormsDoctor.FormDoctorAppCancelled();
            DialogResult res = appCancp.ShowDialog(this);
            if (res == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {
            BusinessLayer.DoctorFacade.updateDescription(actualAppointment, richTextBoxDescription.Text);
        }

        private void richTextBoxDiagnosis_TextChanged(object sender, EventArgs e)
        {
            BusinessLayer.DoctorFacade.updateDiagnosis(actualAppointment, richTextBoxDiagnosis.Text);
        }
    }
}
