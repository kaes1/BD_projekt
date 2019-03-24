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

        DataLayer.Doctor activeDoctor;

        public FormDoctor()
        {
            InitializeComponent();
        }

        public FormDoctor(DataLayer.User user)
        {
            InitializeComponent();
            activeDoctor = BusinessLayer.DoctorFacade.GetDoctor(user.UserID);
        }
    }
}
