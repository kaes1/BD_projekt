using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace GUILayer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void displayData()
        {

            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = RegistrationFacade.GetPatients();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
