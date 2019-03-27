using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILayer.FormsLab
{
    public partial class FormLabTechExamV2 : Form
    {
        public Form prevPageRef { get; set; }
        public FormLabTechExamV2()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Close this form.
            this.Close();
            //Show the previous form.
            prevPageRef.Show();
        }
    }
}
