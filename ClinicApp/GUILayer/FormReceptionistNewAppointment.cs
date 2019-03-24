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
    public partial class FormReceptionistNewAppointment : Form
    {

        BusinessLayer.PatientInformation activePatientInfo;

        public FormReceptionistNewAppointment()
        {
            InitializeComponent();
        }

        public FormReceptionistNewAppointment(BusinessLayer.PatientInformation patientInfo)
        {
            InitializeComponent();
            activePatientInfo = patientInfo;
            textBoxFirstName.Text = activePatientInfo.FirstName;
            textBoxLastName.Text = activePatientInfo.LastName;
            textBoxPESEL.Text = activePatientInfo.PESEL;
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
