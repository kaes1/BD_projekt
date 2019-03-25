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
        BusinessLayer.ReceptionistInformation activeReceptionistInfo;

        public FormReceptionistNewAppointment(BusinessLayer.PatientInformation patientInfo, BusinessLayer.ReceptionistInformation receptionistInfo)
        {
            InitializeComponent();

            activeReceptionistInfo = receptionistInfo;

            activePatientInfo = patientInfo;
            textBoxFirstName.Text = activePatientInfo.FirstName;
            textBoxLastName.Text = activePatientInfo.LastName;
            textBoxPESEL.Text = activePatientInfo.PESEL;

            dataGridViewDoctors.Columns.Clear();
            dataGridViewDoctors.DataSource = BusinessLayer.ReceptionistFacade.GetAllDoctors();
            dataGridViewDoctors.Columns[0].Width = 60;
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            //Check if any doctor is selected.
            if (dataGridViewDoctors.SelectedCells.Count > 0)
            {
                BusinessLayer.DoctorInformation doctorInfo = new BusinessLayer.DoctorInformation();
                doctorInfo.DoctorID = (int)(dataGridViewDoctors.Rows[dataGridViewDoctors.CurrentCell.RowIndex].Cells[0].Value);
                doctorInfo.FirstName = (string)(dataGridViewDoctors.Rows[dataGridViewDoctors.CurrentCell.RowIndex].Cells[1].Value);
                doctorInfo.LastName = (string)(dataGridViewDoctors.Rows[dataGridViewDoctors.CurrentCell.RowIndex].Cells[2].Value);
                doctorInfo.PWZ = (int)(dataGridViewDoctors.Rows[dataGridViewDoctors.CurrentCell.RowIndex].Cells[3].Value);

                //Add appointment
                BusinessLayer.ReceptionistFacade.AddNewAppointment(activeReceptionistInfo, activePatientInfo, doctorInfo);

                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a doctor to register an appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
