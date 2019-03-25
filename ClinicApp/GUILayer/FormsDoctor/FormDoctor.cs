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
    public partial class FormDoctor : Form
    {
        BusinessLayer.DoctorInformation activeDoctorInformation;

        public FormDoctor()
        {
            InitializeComponent();
        }

        public FormDoctor(int userID)
        {
            InitializeComponent();
            activeDoctorInformation = BusinessLayer.DoctorFacade.GetDoctor(userID);
        }

        //Move to doctorVisitform.
        private void buttonSelectPatient_Click(object sender, EventArgs e)
        {
            //Hide this form.
            this.Hide();
            //Create a new doctorVisitForm.
            var doctorVisitForm = new FormDoctorVisit();
            //Set reference to this form.
            doctorVisitForm.prevPageRef = this;
            //Show the new doctorVisitForm.
            doctorVisitForm.Show();
        }
    }
}
