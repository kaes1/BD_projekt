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
    public partial class FormDoctorVisit : Form
    {
        public FormDoctor prevPageRef { get; set; }
        public FormDoctorVisit()
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
