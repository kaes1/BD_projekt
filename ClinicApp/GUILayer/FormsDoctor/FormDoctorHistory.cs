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
        public Form DoctorAppointmentRef { get; set; }

        public FormDoctorHistory()
        {
            InitializeComponent();
        }

        private void buttonBackToAppointment_Click(object sender, EventArgs e)
        {
            DoctorAppointmentRef.Show();
            this.Close();
        }

        private void buttonManageExaminations_Click(object sender, EventArgs e)
        {
            var doctorExaminationsForm = new FormsDoctor.FormDoctorManageExaminations();
            doctorExaminationsForm.DoctorAppointmentRef = DoctorAppointmentRef;
            doctorExaminationsForm.Show();
            this.Close();
        }
    }
}
