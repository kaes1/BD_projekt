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
        public BusinessLayer.ReceptionistFacade.ReceptionistAppointment newAppointment;
        BusinessLayer.PatientInformation patientInformation;
        BusinessLayer.ReceptionistInformation receptionistInformation;
        List<Tuple<RadioButton, TimeSpan>> timeButtons;

        public FormReceptionistNewAppointment(BusinessLayer.PatientInformation patientInfo, BusinessLayer.ReceptionistInformation receptionistInfo)
        {
            InitializeComponent();
            patientInformation = patientInfo;
            receptionistInformation = receptionistInfo;
            //Create table of tuples: <radio buttons, corresponding time>.
            timeButtons = new List<Tuple<RadioButton, TimeSpan>>()
            {
                Tuple.Create(radioButton0,new TimeSpan(6,0,0)),
                Tuple.Create(radioButton1,new TimeSpan(6,30,0)),
                Tuple.Create(radioButton2,new TimeSpan(7,0,0)),
                Tuple.Create(radioButton3,new TimeSpan(7,30,0)),
                Tuple.Create(radioButton4,new TimeSpan(8,0,0)),
                Tuple.Create(radioButton5,new TimeSpan(8,30,0)),
                Tuple.Create(radioButton6,new TimeSpan(9,0,0)),
                Tuple.Create(radioButton7,new TimeSpan(9,30,0)),
                Tuple.Create(radioButton8,new TimeSpan(10,0,0)),
                Tuple.Create(radioButton9,new TimeSpan(10,30,0)),
                Tuple.Create(radioButton10,new TimeSpan(11,0,0)),
                Tuple.Create(radioButton11,new TimeSpan(11,30,0)),
                Tuple.Create(radioButton12,new TimeSpan(12,0,0)),
                Tuple.Create(radioButton13,new TimeSpan(12,30,0)),
                Tuple.Create(radioButton14,new TimeSpan(13,0,0)),
                Tuple.Create(radioButton15,new TimeSpan(13,30,0)),
                Tuple.Create(radioButton16,new TimeSpan(14,0,0)),
                Tuple.Create(radioButton17,new TimeSpan(14,30,0)),
                Tuple.Create(radioButton18,new TimeSpan(15,0,0)),
                Tuple.Create(radioButton19,new TimeSpan(15,30,0)),
                Tuple.Create(radioButton20,new TimeSpan(16,0,0)),
                Tuple.Create(radioButton21,new TimeSpan(16,30,0)),
                Tuple.Create(radioButton22,new TimeSpan(17,0,0)),
                Tuple.Create(radioButton23,new TimeSpan(17,30,0)),
                Tuple.Create(radioButton24,new TimeSpan(18,0,0)),
                Tuple.Create(radioButton25,new TimeSpan(18,30,0)),
                Tuple.Create(radioButton26,new TimeSpan(19,0,0)),
                Tuple.Create(radioButton27,new TimeSpan(19,30,0))
            };
            //Initial search for doctors.
            searchForDoctors();
            //Fill patient textboxes.
            textBoxFirstName.Text = patientInformation.FirstName;
            textBoxLastName.Text = patientInformation.LastName;
            textBoxPESEL.Text = patientInformation.PESEL;
            //Initialize date picker with today's date.
            dateTimePickerAppointmentDate.Value = DateTime.Now.Date;
            dateTimePickerAppointmentDate.MinDate = DateTime.Now.Date;

        }

        private void enableValidTimeButtons()
        {
            //Enable and uncheck all radio buttons.
            foreach (var element in timeButtons)
            {
                element.Item1.Enabled = true;
                element.Item1.Checked = false;
            }
            //Check if any doctor is selected.
            if (dataGridViewDoctors.SelectedCells.Count > 0 && dataGridViewDoctors.CurrentRow != null)
            {
                //Get Doctor information.
                BusinessLayer.DoctorInformation doctorInfo = new BusinessLayer.DoctorInformation();
                doctorInfo.DoctorID = (int)(dataGridViewDoctors.Rows[dataGridViewDoctors.CurrentCell.RowIndex].Cells[0].Value);
                doctorInfo.FirstName = (string)(dataGridViewDoctors.Rows[dataGridViewDoctors.CurrentCell.RowIndex].Cells[1].Value);
                doctorInfo.LastName = (string)(dataGridViewDoctors.Rows[dataGridViewDoctors.CurrentCell.RowIndex].Cells[2].Value);
                doctorInfo.PWZ = (int)(dataGridViewDoctors.Rows[dataGridViewDoctors.CurrentCell.RowIndex].Cells[3].Value);
                //Get selected date.
                DateTime date = dateTimePickerAppointmentDate.Value.Date;
                //Get inavailable times.
                var inavailableTimes = BusinessLayer.ReceptionistFacade.GetAppointmentTimes(doctorInfo, date);
                //Disable buttons for inavailable times.
                foreach (TimeSpan t in inavailableTimes)
                {
                    int buttonIndex = (t.Hours - 6) * 2 + t.Minutes / 30;
                    timeButtons[buttonIndex].Item1.Enabled = false;
                }
            }
        }

        private void searchForDoctors()
        {
            //Get search criteria.
            BusinessLayer.DoctorInformation doctorSearchCriteria = new BusinessLayer.DoctorInformation();
            doctorSearchCriteria.FirstName = textBoxDoctorFirstName.Text;
            doctorSearchCriteria.LastName = textBoxDoctorLastName.Text;
            //Search and display.
            dataGridViewDoctors.Columns.Clear();
            dataGridViewDoctors.DataSource = BusinessLayer.ReceptionistFacade.GetDoctors(doctorSearchCriteria);
            dataGridViewDoctors.Columns[0].Visible = false;
            dataGridViewDoctors.Columns[1].Width = 120;
            dataGridViewDoctors.Columns[2].Width = 120;
            dataGridViewDoctors.Columns[3].Width = 120;
            //Select first doctor.
            if (dataGridViewDoctors.Rows.Count > 0)
                dataGridViewDoctors.CurrentCell = dataGridViewDoctors[1, 0];
            enableValidTimeButtons();
        }

        private bool validAppointmentDateTime()
        {
            //Check if any time button is checked.
            foreach (var element in timeButtons)
                if (element.Item1.Checked == true)
                    return true;

            return false;
        }

        private DateTime getAppointmentDateTime()
        {
            //Get time of checked button.
            TimeSpan time = new TimeSpan();
            foreach (var element in timeButtons)
                if (element.Item1.Checked == true)
                {
                    time = element.Item2;
                    break;
                }
            return dateTimePickerAppointmentDate.Value.Date.Add(time);
        }

        private void buttonAddAppointment_Click(object sender, EventArgs e)
        {
            //Check if any doctor is selected.
            if (dataGridViewDoctors.SelectedCells.Count > 0)
            {
                //Check if proper date and time is selected.
                if (!validAppointmentDateTime())
                {
                    MessageBox.Show("Please select a proper date and time for the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Get Doctor information.
                BusinessLayer.DoctorInformation doctorInfo = new BusinessLayer.DoctorInformation();
                doctorInfo.DoctorID = (int)(dataGridViewDoctors.Rows[dataGridViewDoctors.CurrentCell.RowIndex].Cells[0].Value);
                doctorInfo.FirstName = (string)(dataGridViewDoctors.Rows[dataGridViewDoctors.CurrentCell.RowIndex].Cells[1].Value);
                doctorInfo.LastName = (string)(dataGridViewDoctors.Rows[dataGridViewDoctors.CurrentCell.RowIndex].Cells[2].Value);
                doctorInfo.PWZ = (int)(dataGridViewDoctors.Rows[dataGridViewDoctors.CurrentCell.RowIndex].Cells[3].Value);
                //Get appointment date.
                DateTime appointmentDate = getAppointmentDateTime();
                //Add appointment
                newAppointment = new BusinessLayer.ReceptionistFacade.ReceptionistAppointment();
                newAppointment.Date = appointmentDate;
                newAppointment.DoctorFirstName = doctorInfo.FirstName;
                newAppointment.DoctorLastName = doctorInfo.LastName;
                BusinessLayer.ReceptionistFacade.AddAppointment(receptionistInformation, patientInformation, doctorInfo, appointmentDate);

                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Please select a doctor to register an appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonSearchDoctors_Click(object sender, EventArgs e)
        {
            searchForDoctors();
        }

        private void dateTimePickerAppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            //Find available hours.
            enableValidTimeButtons();
        }

        private void dataGridViewDoctors_SelectionChanged(object sender, EventArgs e)
        {
            //Find available hours.
            enableValidTimeButtons();
        }
    }
}