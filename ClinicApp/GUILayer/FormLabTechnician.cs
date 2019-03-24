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

        DataLayer.LabTechnician activeLabTechnician;

        public FormLabTechnician()
        {
            InitializeComponent();
        }

        public FormLabTechnician(DataLayer.User user)
        {
            InitializeComponent();
            activeLabTechnician = BusinessLayer.LabTechnicianFacade.GetLabTechnician(user.UserID);
        }
    }
}
