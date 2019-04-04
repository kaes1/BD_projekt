﻿using System;
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
    public partial class FormDoctorVisit : Form
    {
        public Form prevPageRef { get; set; }
        public BusinessLayer.AppointmentInformation actualAppointment { get; set; }
        public BusinessLayer.PatientInformation actualPatient { get; set; }

        public FormDoctorVisit()
        {
            InitializeComponent();
        }

        public FormDoctorVisit(BusinessLayer.AppointmentInformation app, BusinessLayer.PatientInformation pat)
        {
            InitializeComponent();
            actualAppointment = app;
            actualPatient = pat;

            textBoxFirstName.Text = actualPatient.FirstName;
            textBoxLastName.Text = actualPatient.LastName;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Show the previous form.
            prevPageRef.Show();
            this.Close();
        }

        private void buttonAddPhysExamination_Click(object sender, EventArgs e)
        {
            var PhysExamForm = new FormDoctorPhysExam();
            PhysExamForm.Show();
        }

        private void buttonAddLabTest_Click(object sender, EventArgs e)
        {
            var LabTestForm = new FormsDoctor.FormDoctorLabTest();
            LabTestForm.Show();
        }

        private void buttonPatientHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            var doctorHistoryForm = new FormsDoctor.FormDoctorHistory();
            doctorHistoryForm.DoctorAppointmentRef = this;
            //doctorHistoryForm.FormClosed += (s, args) => this.Close();
            doctorHistoryForm.actualPatient = actualPatient;
            doctorHistoryForm.actualAppointment = actualAppointment;
            doctorHistoryForm.Show();
        }

        private void buttonManageExaminations_Click(object sender, EventArgs e)
        {
            this.Hide();
            var doctorExaminationsForm = new FormsDoctor.FormDoctorManageExaminations();
            doctorExaminationsForm.DoctorAppointmentRef = this;
            //doctorHistoryForm.FormClosed += (s, args) => this.Close();
            doctorExaminationsForm.actualPatient = actualPatient;
            doctorExaminationsForm.actualAppointment = actualAppointment;
            doctorExaminationsForm.Show();
        }

        private void buttonBeginAppointment_Click(object sender, EventArgs e)
        {
            buttonBeginAppointment.Enabled = false;
            buttonEndAppointment.Enabled = true;
            buttonBack.Enabled = false;
            buttonCancelAppointment.Enabled = true;
            richTextBoxDescription.Enabled = true;
            richTextBoxDiagnosis.Enabled = true;
            buttonPatientHistory.Enabled = true;
            buttonManageExaminations.Enabled = true;
        }

        private void buttonEndAppointment_Click(object sender, EventArgs e)
        {

            actualAppointment.Diagnosis = richTextBoxDiagnosis.Text;
            actualAppointment.Description = richTextBoxDescription.Text;
            BusinessLayer.DoctorFacade.completeAppointment(actualAppointment);
        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {
            BusinessLayer.DoctorFacade.appointmentCanceled(actualAppointment);
            prevPageRef.Show();
            this.Close();
        }
    }
}
