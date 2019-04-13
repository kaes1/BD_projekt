﻿using System;
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
    public partial class FormLabTechnicianExamination : Form
    {
        public BusinessLayer.LabTechnicianFacade.LabTechnicianLabExaminationDetails labExamination;

        public FormLabTechnicianExamination(int labExaminationID)
        {
            InitializeComponent();
            //Find lab examination.
            labExamination = BusinessLayer.LabTechnicianFacade.GetLabExaminationDetails(labExaminationID);
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
            //Enable controls and set correct text.
            if (labExamination.Status.StartsWith("REG"))
            {
                buttonComplete.Text = "Begin";
                buttonComplete.Enabled = true;
                buttonCancelExamination.Enabled = true;
            }
            else if (labExamination.Status.StartsWith("BEG"))
            {
                buttonComplete.Text = "Complete";
                textBoxResult.ReadOnly = false;
                buttonComplete.Enabled = true;
                buttonCancelExamination.Enabled = true;
            }
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            //If begin was pressed, begin the examination.
            if (labExamination.Status.StartsWith("REG"))
            {
                BusinessLayer.LabTechnicianFacade.BeginLabExamination(labExamination.LabExaminationID);
                textBoxResult.ReadOnly = false;
                textBoxStatus.Text = "BEG";
                buttonComplete.Text = "Complete";
            }
            //If complete was pressed, complete the examination.
            else if (labExamination.Status.StartsWith("BEG"))
            {
                //Check if result is empty.
                if (string.IsNullOrWhiteSpace(textBoxResult.Text))
                {
                    MessageBox.Show("Cannot complete lab examination without any results.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //Complete the examination.
                BusinessLayer.LabTechnicianFacade.CompleteLabExamination(labExamination.LabExaminationID, textBoxResult.Text);
                DialogResult = DialogResult.OK;
            }        
        }

        private void buttonCancelExamination_Click(object sender, EventArgs e)
        {
            //Check if status is correct.
            if (labExamination.Status != "REG" && labExamination.Status != "BEG")
            {
                MessageBox.Show("Can only cancel examinations which haven't been completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Cancel the examination
            BusinessLayer.LabTechnicianFacade.CancelLabExamination(labExamination.LabExaminationID, textBoxResult.Text);
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
