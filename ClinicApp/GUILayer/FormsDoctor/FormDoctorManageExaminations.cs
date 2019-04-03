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
        public Form DoctorAppointmentRef { get; set; }

        public FormDoctorManageExaminations()
        {
            InitializeComponent();
        }

        private void buttonBackToAppointment_Click(object sender, EventArgs e)
        {
            DoctorAppointmentRef.Show();
            this.Close();
        }

        private void buttonPatientHistory_Click(object sender, EventArgs e)
        {
            var doctorHistoryForm = new FormsDoctor.FormDoctorHistory();
            doctorHistoryForm.DoctorAppointmentRef = DoctorAppointmentRef;
            doctorHistoryForm.Show();
            this.Close();
        }
    }
}
