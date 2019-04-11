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
    public partial class FormReceptionistCancelAppointment : Form
    {
        public BusinessLayer.ReceptionistFacade.ReceptionistAppointment canceledAppointment;

        public FormReceptionistCancelAppointment(BusinessLayer.PatientInformation patient, BusinessLayer.ReceptionistFacade.ReceptionistAppointment appointment)
        {
            InitializeComponent();
            canceledAppointment = appointment;
            //Fill patient textboxes.
            textBoxFirstName.Text = patient.FirstName;
            textBoxLastName.Text = patient.LastName;
            textBoxPESEL.Text = patient.PESEL;
            //Fill appointment textboxes.
            textBoxDoctor.Text = appointment.DoctorFirstName + " " + appointment.DoctorLastName;
            textBoxDateAndTime.Text = appointment.Date.ToString();
        }

        private void buttonCancelAppointment_Click(object sender, EventArgs e)
        {
            //Cancel the appointment.
            BusinessLayer.ReceptionistFacade.CancelAppointment(canceledAppointment.AppointmentID);
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
