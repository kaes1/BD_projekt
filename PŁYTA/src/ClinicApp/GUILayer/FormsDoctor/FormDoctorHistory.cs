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
        BusinessLayer.AppointmentInformation activeAppointment { get; set; }
        BusinessLayer.PatientInformation activePatient { get; set; }
        BusinessLayer.DoctorInformation activeDoctor{ get; set; }
        bool showAppointments = true;

        public FormDoctorHistory(BusinessLayer.AppointmentInformation actApp, BusinessLayer.PatientInformation actPat, BusinessLayer.DoctorInformation actDoc)
        {
            InitializeComponent();
            //Set window title.
            this.Text = "Patient History - " + actPat.FirstName + " " + actPat.LastName;
            activeAppointment = actApp;
            activeDoctor = actDoc;
            activePatient = actPat;

            textBoxFirstName.Text = actPat.FirstName;
            textBoxLastName.Text = actPat.LastName;

            searchForAppointments();
        }

        private void buttonBackToAppointment_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void searchForAppointments()
        {
            dataGridViewAppoinmentsExaminations.DataSource = BusinessLayer.DoctorFacade.GetPatientPrevApps(activePatient);
            dataGridViewAppoinmentsExaminations.Columns["AppointmentID"].Visible = false;
            dataGridViewAppoinmentsExaminations.Columns["DoctorID"].Visible = false;
            dataGridViewAppoinmentsExaminations.Columns["ReceptionistID"].Visible = false;
            dataGridViewAppoinmentsExaminations.Columns["Description"].Visible = false;
            dataGridViewAppoinmentsExaminations.Columns["Diagnosis"].Visible = false;
            dataGridViewAppoinmentsExaminations.Columns["DateRegistered"].Visible = false;
            dataGridViewAppoinmentsExaminations.Columns["DateCompletedOrCanceled"].Visible = false;
            dataGridViewAppoinmentsExaminations.Columns["PatientID"].Visible = false;
            dataGridViewAppoinmentsExaminations.Columns["DateOfAppointment"].DisplayIndex = 0;
            dataGridViewAppoinmentsExaminations.Columns["DateOfAppointment"].HeaderText = "Date";
            dataGridViewAppoinmentsExaminations.Columns["Status"].DisplayIndex = 1;
            dataGridViewAppoinmentsExaminations.Columns["DoctorLastName"].DisplayIndex = 6;
            //Select first appointment if not empty.
            if (dataGridViewAppoinmentsExaminations.Rows.Count > 0)
                dataGridViewAppoinmentsExaminations.CurrentCell = dataGridViewAppoinmentsExaminations[6, 0];
        }

        

        private void buttonPreviousExaminations_Click(object sender, EventArgs e)
        {


            showAppointments = false;

            groupBoxPreviousComments.Text = "Previous Examinations";

            richTextBoxExaminationResult.Visible = true;
            richTextBoxDiagnosis.Visible = false;
            richTextBoxDescription.Visible = false;
            labelResultDiagnosis.Text = "Result";
            labelResultDiagnosis.Visible = true;
            labelDescription.Visible = false;

            dataGridViewAppoinmentsExaminations.DataSource = BusinessLayer.DoctorFacade.GetPatientPrevExams(activePatient);
            dataGridViewAppoinmentsExaminations.Columns["dateRegistered"].DisplayIndex = 0;
            dataGridViewAppoinmentsExaminations.Columns["dateRegistered"].Visible = true;
            dataGridViewAppoinmentsExaminations.Columns["dateRegistered"].HeaderText = "Date";
            dataGridViewAppoinmentsExaminations.Columns["Result"].Visible = false;
            dataGridViewAppoinmentsExaminations.Columns["Code"].Visible = false;
            //Select first examination if not empty.
            if (dataGridViewAppoinmentsExaminations.Rows.Count > 0)
                dataGridViewAppoinmentsExaminations.CurrentCell = dataGridViewAppoinmentsExaminations[0, 0];
        }

        private void buttonPreviousAppointments_Click(object sender, EventArgs e)
        {
            showAppointments = true;

            groupBoxPreviousComments.Text = "Previous Appointments";

            richTextBoxExaminationResult.Visible = false;
            richTextBoxDiagnosis.Visible = true;
            richTextBoxDescription.Visible = true;
            labelResultDiagnosis.Text = "Diagnosis";
            labelResultDiagnosis.Visible = true;
            labelDescription.Visible = true;

            searchForAppointments();
        }

        private void showAppointmentResult()
        {
            if (dataGridViewAppoinmentsExaminations.SelectedCells.Count > 0 && dataGridViewAppoinmentsExaminations.CurrentRow != null)
            {
                int appID = (int)dataGridViewAppoinmentsExaminations.CurrentRow.Cells["AppointmentID"].Value;
                BusinessLayer.AppointmentInformation app = BusinessLayer.DoctorFacade.GetAppointmentByID(appID);
                richTextBoxDiagnosis.Text = app.Diagnosis;
                richTextBoxDescription.Text = app.Description;
            }
        }

        private void showExaminationResult()
        {
            if (dataGridViewAppoinmentsExaminations.SelectedCells.Count > 0 && dataGridViewAppoinmentsExaminations.CurrentRow != null)
            {
                string result = (string)dataGridViewAppoinmentsExaminations.CurrentRow.Cells["Result"].Value;
                richTextBoxExaminationResult.Text = result;
            }
        }

        private void dataGridViewAppoinmentsExaminations_SelectionChanged(object sender, EventArgs e)
        {
            if (showAppointments == true)
                showAppointmentResult();
            else
                showExaminationResult();
        }
    }
}
