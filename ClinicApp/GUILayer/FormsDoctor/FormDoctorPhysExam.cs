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
    public partial class FormDoctorPhysExam : Form
    {
        BusinessLayer.AppointmentInformation actApp;
        BusinessLayer.ExaminationDictionaryInformation selectedExam;
        public FormDoctorPhysExam(BusinessLayer.AppointmentInformation app)
        {
            InitializeComponent();
            actApp = app;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxChoosenExamination.Text != "")
            {
                if (richTextBoxResult.Text == "")
                {
                    MessageBox.Show("You need to write down the examination result.");
                }
                else
                {
                    BusinessLayer.DoctorFacade.AddPhysExamination(actApp.AppointmentID, selectedExam.Code, richTextBoxResult.Text);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Select examination or cancel selection.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonChooseExam_Click(object sender, EventArgs e)
        {
            var examList = new FormsDoctor.FormDoctorExamList("P");
            DialogResult res = examList.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                selectedExam = examList.selectedExam;
                textBoxChoosenExamination.Text = selectedExam.Name;
            }
        }
    }
}
