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
    public partial class FormLabManager : Form
    {

        DataLayer.LabManager activeLabManager;

        public FormLabManager()
        {
            InitializeComponent();
        }

        public FormLabManager(DataLayer.User user)
        {
            InitializeComponent();
            activeLabManager = BusinessLayer.LabManagerFacade.GetLabManager(user.UserID);
        }
    }
}
