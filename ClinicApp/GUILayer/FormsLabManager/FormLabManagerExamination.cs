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
    public partial class FormLabManagerExamination : Form
    {
        public BusinessLayer.LabManagerFacade.LabManagerLabExaminationDetails labExamination;

        public FormLabManagerExamination(int labExaminationID)
        {
            InitializeComponent();
            //Find lab examination.
            labExamination = BusinessLayer.LabManagerFacade.GetLabExaminationDetails(labExaminationID);
            //Fill all fields.
            textBoxExaminationName.Text = labExamination.ExaminationName;
            textBoxExaminationCode.Text = labExamination.Code;
            textBoxStatus.Text = labExamination.Status;
            textBoxDateRegistered.Text = labExamination.DateRegistered.ToString();
            if (labExamination.DateCompleted.HasValue)
                textBoxDateCompleted.Text = labExamination.DateCompleted.ToString();
            textBoxPatientFirstName.Text = labExamination.PatientFirstName;
            textBoxPatientLastName.Text = labExamination.PatientLastName;
            textBoxDoctorComments.Text = labExamination.DoctorComments;
            textBoxResult.Text = labExamination.Result;
            textBoxLabManagerComments.Text = labExamination.LabManagerComments;
            //Disable controls if wrong status.
            if (labExamination.Status.StartsWith("COMP"))
            {
                textBoxLabManagerComments.ReadOnly = false;
                buttonApprove.Enabled = true;
                buttonCancelExamination.Enabled = true;
            }
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            //Check if status is correct.
            if (labExamination.Status != "COMP")
            {
                MessageBox.Show("Can only approve examinations which have been completed .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Approve the examination
            BusinessLayer.LabManagerFacade.ApproveLabExamination(labExamination.LabExaminationID, textBoxLabManagerComments.Text);
            DialogResult = DialogResult.OK;
        }

        private void buttonCancelExamination_Click(object sender, EventArgs e)
        {
            //Check if status is correct.
            if (labExamination.Status != "COMP")
            {
                MessageBox.Show("Can only cancel examinations which have been completed and not approved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Check if comments are empty.
            if (string.IsNullOrWhiteSpace(textBoxLabManagerComments.Text))
            { 
                MessageBox.Show("Cannot cancel examination without any comments.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Cancel the examination
            BusinessLayer.LabManagerFacade.CancelLabExamination(labExamination.LabExaminationID, textBoxLabManagerComments.Text);
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
