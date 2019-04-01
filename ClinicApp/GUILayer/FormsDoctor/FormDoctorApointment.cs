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
    public partial class FormDoctorVisit : Form
    {
        public Form prevPageRef { get; set; }
        public FormDoctorVisit()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Close this form.
            this.Close();
            //Show the previous form.
            prevPageRef.Show();
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
    }
}
