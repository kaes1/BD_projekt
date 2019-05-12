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
        public BusinessLayer.ExaminationDictionaryInformation selectedExam = new BusinessLayer.ExaminationDictionaryInformation();
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
            dataGridViewExamList.AutoGenerateColumns = false;
            dataGridViewExamList.Columns.Remove("Type");
            dataGridViewExamList.Columns["Code"].Width = 90;
            dataGridViewExamList.Columns["Name"].Width = 175;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            selectedExam.Code = dataGridViewExamList.SelectedRows[0].Cells[0].Value.ToString();
            selectedExam.Name = dataGridViewExamList.SelectedRows[0].Cells[1].Value.ToString();
            selectedExam.Type = type[0];
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBoxExamName_TextChanged(object sender, EventArgs e)
        {
            dataGridViewExamList.AutoGenerateColumns = true;
            var pattern = new BusinessLayer.ExaminationDictionaryInformation();
            pattern.Code = textBoxExamID.Text;
            pattern.Name = textBoxExamName.Text;
            if(type == "P")
            {
                dataGridViewExamList.DataSource = BusinessLayer.DoctorFacade.GetDictPhysExams(pattern);
            }
            else if(type == "L")
            {
                dataGridViewExamList.DataSource = BusinessLayer.DoctorFacade.GetDictLabExams(pattern);
            }
            dataGridViewExamList.AutoGenerateColumns = false;
            dataGridViewExamList.Columns.Remove("Type");
            dataGridViewExamList.Columns["Code"].Width = 90;
            dataGridViewExamList.Columns["Name"].Width = 175;
        }

        private void textBoxExamID_TextChanged(object sender, EventArgs e)
        {
            dataGridViewExamList.AutoGenerateColumns = true;
            var pattern = new BusinessLayer.ExaminationDictionaryInformation();
            pattern.Code = textBoxExamID.Text;
            pattern.Name = textBoxExamName.Text;
            if (type == "P")
            {
                dataGridViewExamList.DataSource = BusinessLayer.DoctorFacade.GetDictPhysExams(pattern);
            }
            else if (type == "L")
            {
                dataGridViewExamList.DataSource = BusinessLayer.DoctorFacade.GetDictLabExams(pattern);
            }
            dataGridViewExamList.AutoGenerateColumns = false;
            dataGridViewExamList.Columns.Remove("Type");
            dataGridViewExamList.Columns["Code"].Width = 90;
            dataGridViewExamList.Columns["Name"].Width = 175;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
