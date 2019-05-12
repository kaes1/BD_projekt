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
        public BusinessLayer.AppointmentInformation activeAppointment { get; set; }
        public BusinessLayer.PatientInformation activePatient { get; set; }
        public BusinessLayer.DoctorInformation activeDoctor { get; set; }

        public FormDoctorAppointment(BusinessLayer.AppointmentInformation app, BusinessLayer.PatientInformation pat)
        {
            InitializeComponent();
            //Set window title.
            this.Text = "Appointment - " + pat.FirstName + " " + pat.LastName;
            //Set active appointment and patient.
            activeAppointment = app;
            activePatient = pat;

            //Set patient name and lastname
            textBoxFirstName.Text = activePatient.FirstName;
            textBoxLastName.Text = activePatient.LastName;

            //Get new description if there was a change
            activeAppointment = BusinessLayer.DoctorFacade.GetActAppInfo(app);
            richTextBoxDescription.Text = activeAppointment.Description;
            richTextBoxDiagnosis.Text = activeAppointment.Diagnosis;

            if(activeAppointment.Status == "BEG")
            {
                buttonBeginAppointment.Text = "Continue appointment";
            }
            else if (activeAppointment.Status == "COMP")
            {
                buttonBeginAppointment.Enabled = false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonPatientHistory_Click(object sender, EventArgs e)
        {
            var doctorHistoryForm = new FormsDoctor.FormDoctorHistory(activeAppointment, activePatient, activeDoctor);
            DialogResult res = doctorHistoryForm.ShowDialog(this);
            if (res == DialogResult.OK)
            {

            }
        }

        private void buttonManageExaminations_Click(object sender, EventArgs e)
        {
            var doctorExaminationsForm = new FormsDoctor.FormDoctorManageExaminations(activeAppointment, activePatient, activeDoctor);
            DialogResult res = doctorExaminationsForm.ShowDialog(this);
            if (res == DialogResult.OK)
            {

            }
        }

        private void buttonBeginAppointment_Click(object sender, EventArgs e)
        {
            if (buttonBeginAppointment.Text != "End")
            {
                //Unlock buttons and change beginButton to endButton
                buttonBack.Enabled = false;
                buttonCancelAppointment.Enabled = true;
                richTextBoxDescription.Enabled = true;
                richTextBoxDiagnosis.Enabled = true;
                buttonPatientHistory.Enabled = true;
                buttonManageExaminations.Enabled = true;
                buttonBeginAppointment.Text = "End";

                //Set appointment status as BEG
                BusinessLayer.DoctorFacade.SetAppStatus(activeAppointment, "BEG");
            }
            else
            {
                if (string.IsNullOrWhiteSpace(richTextBoxDescription.Text))
                {
                    MessageBox.Show("Description cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                BusinessLayer.DoctorFacade.CompleteAppointment(activeAppointment);
                this.Close();
            }
        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {
            FormsDoctor.FormDoctorAppCancelled appCanc = new FormsDoctor.FormDoctorAppCancelled();
            DialogResult res = appCanc.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                activeAppointment.Description = appCanc.reason;
                BusinessLayer.DoctorFacade.CancelAppointment(activeAppointment);
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void richTextBoxDescription_TextChanged(object sender, EventArgs e)
        {
            BusinessLayer.DoctorFacade.UpdateDescription(activeAppointment, richTextBoxDescription.Text);
        }

        private void richTextBoxDiagnosis_TextChanged(object sender, EventArgs e)
        {
            BusinessLayer.DoctorFacade.UpdateDiagnosis(activeAppointment, richTextBoxDiagnosis.Text);
        }
    }
}
