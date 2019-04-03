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
        public FormDoctorPhysExam()
        {
            InitializeComponent();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
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

            }
        }
    }
}
