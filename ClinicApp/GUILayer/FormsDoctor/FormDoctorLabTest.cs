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
    public partial class FormDoctorLabTest : Form
    {
        BusinessLayer.AppointmentInformation actApp;
        BusinessLayer.ExaminationDictionaryInformation selectedExam;
        public FormDoctorLabTest(BusinessLayer.AppointmentInformation app)
        {
            InitializeComponent();
            actApp = app;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxChoosenExamination.Text != "")
            {
                BusinessLayer.DoctorFacade.AddLabExamination(actApp.AppointmentID, selectedExam.Code, richTextBoxComment.Text);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select examination or cancel selection.");
            }
        }

        private void buttonChooseExam_Click(object sender, EventArgs e)
        {
            var examList = new FormsDoctor.FormDoctorExamList("L");
            DialogResult res = examList.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                selectedExam = examList.selectedExam;
                textBoxChoosenExamination.Text = selectedExam.Name;
            }
        }

        private void buttonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
