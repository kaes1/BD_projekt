﻿using System;
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
    public partial class FormLabTechExam : Form
    {
        public Form prevPageRef { get; set; }
        public FormLabTechExam()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            prevPageRef.Show();
            this.Close();
        }
    }
}
