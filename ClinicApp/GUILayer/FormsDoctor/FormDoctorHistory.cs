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
            dataGridViewAppoinmentsExaminations.DataSource = BusinessLayer.DoctorFacade.GetPatientPrevApps(actualPatient);
        }

        private void buttonBackToAppointment_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonPreviousExaminations_Click(object sender, EventArgs e)
        {
            //TODO show examinations
            showAppointments = false;
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

        private void buttonPreviousAppointments_Click(object sender, EventArgs e)
        {
            dataGridViewAppoinmentsExaminations.DataSource = BusinessLayer.DoctorFacade.GetPatientPrevApps(actualPatient);
            showAppointments = true;
        }
    }
}
