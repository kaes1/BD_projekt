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
        BusinessLayer.AppointmentInformation actualAppointment { get; set; }
        BusinessLayer.PatientInformation actualPatient { get; set; }
        BusinessLayer.DoctorInformation actualDoctor{ get; set; }
        bool showAppointments = true;

        public FormDoctorHistory(BusinessLayer.AppointmentInformation actApp, BusinessLayer.PatientInformation actPat, BusinessLayer.DoctorInformation actDoc)
        {
            InitializeComponent();
            actualAppointment = actApp;
            actualDoctor = actDoc;
            actualPatient = actPat;
            dataGridViewAppoinmentsExaminations.AutoGenerateColumns = true;
            dataGridViewAppoinmentsExaminations.DataSource = BusinessLayer.DoctorFacade.GetPatientPrevApps(actualPatient);
            dataGridViewAppoinmentsExaminations.AutoGenerateColumns = false;
            dataGridViewAppoinmentsExaminations.Columns.Remove("PatientFirstName");
            dataGridViewAppoinmentsExaminations.Columns.Remove("PatientLastName");
            dataGridViewAppoinmentsExaminations.Columns.Remove("PatientPesel");
        }

        private void buttonBackToAppointment_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonPreviousExaminations_Click(object sender, EventArgs e)
        {
            dataGridViewAppoinmentsExaminations.AutoGenerateColumns = true;
            dataGridViewAppoinmentsExaminations.DataSource = BusinessLayer.DoctorFacade.GetPreviousExaminations(actualPatient);
            dataGridViewAppoinmentsExaminations.AutoGenerateColumns = false;
            showAppointments = false;
        }

        private void dataGridViewAppoinmentsExaminations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showAppointments == true)
            {
                int appID = (int)dataGridViewAppoinmentsExaminations.SelectedRows[0].Cells[0].Value;
                BusinessLayer.AppointmentInformation app = BusinessLayer.DoctorFacade.GetAppointmentByID(appID);
                richTextBoxResultDescription.Text = app.Description;
            }
            else
            {
              //  String examResult = BusinessLayer.DoctorFacade.GetExamResultById(dataGridViewAppoinmentsExaminations.SelectedRows[0].Cells[0].Value);
               // richTextBoxResultDescription.Text = app.Description;
            }
        }

        private void buttonPreviousAppointments_Click(object sender, EventArgs e)
        {
            dataGridViewAppoinmentsExaminations.AutoGenerateColumns = true;
            dataGridViewAppoinmentsExaminations.DataSource = BusinessLayer.DoctorFacade.GetPatientPrevApps(actualPatient);
            dataGridViewAppoinmentsExaminations.AutoGenerateColumns = false;
            dataGridViewAppoinmentsExaminations.Columns.Remove("PatientFirstName");
            dataGridViewAppoinmentsExaminations.Columns.Remove("PatientLastName");
            dataGridViewAppoinmentsExaminations.Columns.Remove("PatientPesel");
            showAppointments = true;
        }
    }
}
