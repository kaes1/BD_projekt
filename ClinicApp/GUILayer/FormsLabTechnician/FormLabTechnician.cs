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
    public partial class FormLabTechnician : Form
    {

        public FormLabTechnician()
        {
            InitializeComponent();
        }

        public FormLabTechnician(int userID)
        {
            InitializeComponent();
        }

        private void buttonBeginExamination_Click(object sender, EventArgs e)
        {
            //Hide this form.
            this.Hide();
            //Create a new LabTechExamForm.
            var labExamForm = new FormsLab.FormLabTechExam();
            //Set reference to this form.
            labExamForm.prevPageRef = this;
            //Show the new doctorVisitForm.
            labExamForm.Show();
        }
    }
}
