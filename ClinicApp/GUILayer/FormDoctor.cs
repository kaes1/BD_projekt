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
    }
}
