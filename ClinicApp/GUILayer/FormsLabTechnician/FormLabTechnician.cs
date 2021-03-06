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
    public partial class FormLabTechnician : Form
    {

        private BusinessLayer.LabTechnicianInformation activeLabTechnician;
   
        public FormLabTechnician(int userID)
        {
            activeLabTechnician = BusinessLayer.LabTechnicianFacade.GetLabTechnician(userID);
            InitializeComponent();
            //Set window title.
            this.Text = "Lab Technician - " + activeLabTechnician.FirstName + " " + activeLabTechnician.LastName;
            //Set initial search options.
            comboBoxStatus.SelectedIndex = 1;
            dateTimePickerDateRegistered.Value = DateTime.Now.Date;
            //Initial search for lab examinations.
            searchForLabExaminations();
        }

        private void searchForLabExaminations()
        {
            //Get search criteria.
            var labExaminationSearchCriteria = new BusinessLayer.LabTechnicianFacade.LabTechnicianLabExamination();
            if (dateTimePickerDateRegistered.Checked)
                labExaminationSearchCriteria.DateRegistered = dateTimePickerDateRegistered.Value.Date;
            labExaminationSearchCriteria.ExaminationName = textBoxExaminationName.Text;
            if (!string.IsNullOrWhiteSpace(comboBoxStatus.Text))
                labExaminationSearchCriteria.Status = comboBoxStatus.Text;
            labExaminationSearchCriteria.PatientFirstName = textBoxFirstName.Text;
            labExaminationSearchCriteria.PatientLastName = textBoxLastName.Text;
            //Search and display.
            dataGridViewLabExaminations.Columns.Clear();
            dataGridViewLabExaminations.DataSource = BusinessLayer.LabTechnicianFacade.GetLabExaminations(labExaminationSearchCriteria);
            dataGridViewLabExaminations.Columns[3].Width = 70;
            dataGridViewLabExaminations.Columns[6].Visible = false;
            if (dataGridViewLabExaminations.Rows.Count > 0)
                dataGridViewLabExaminations.CurrentCell = dataGridViewLabExaminations[0, 0];
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchForLabExaminations();
        }

        private void buttonExaminationDisplay_Click(object sender, EventArgs e)
        {
            //Check if any patient is selected.
            if (dataGridViewLabExaminations.SelectedCells.Count > 0)
            {
                //Get lab examination information.
                int labExaminationID = (int)(dataGridViewLabExaminations.Rows[dataGridViewLabExaminations.CurrentCell.RowIndex].Cells[6].Value);
                //Create and display examination form.
                FormLabTechnicianExamination formExaminationDetails = new FormLabTechnicianExamination(activeLabTechnician, labExaminationID);
                DialogResult res = formExaminationDetails.ShowDialog(this);
                //Select the edited examination if edited.
                if (res == DialogResult.OK)
                {
                    //Refresh displayed examinations.
                    searchForLabExaminations();
                    foreach (DataGridViewRow row in dataGridViewLabExaminations.Rows)
                        if ((int)row.Cells[6].Value == formExaminationDetails.labExamination.LabExaminationID)
                        {
                            dataGridViewLabExaminations.CurrentCell = dataGridViewLabExaminations[0, row.Index];
                            break;
                        }
                }
                //Dispose of form.
                formExaminationDetails.Dispose();
            }
        }

    }
}
