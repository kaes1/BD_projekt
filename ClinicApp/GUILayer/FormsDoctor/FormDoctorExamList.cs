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
    public partial class FormDoctorExamList : Form
    {
        String type;
        public FormDoctorExamList(String tp)
        {
            InitializeComponent();
            type = tp;
            if(tp == "P")
            {
                dataGridViewExamList.DataSource = BusinessLayer.DoctorFacade.GetPhysExam(textBoxExamName.Text, textBoxExamID.Text);
            }
            else if(tp=="L")
            {
                dataGridViewExamList.DataSource = BusinessLayer.DoctorFacade.GetLabExam(textBoxExamName.Text, textBoxExamID.Text);
            }
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void textBoxExamName_TextChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void textBoxExamID_TextChanged(object sender, EventArgs e)
        {
            //TODO
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}
