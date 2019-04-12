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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            BusinessLayer.UserInformation userInfo = BusinessLayer.LoginFacade.GetUser(username, password);
           
            if (userInfo != null)
            {
                if (userInfo.DateRetired != null && userInfo.DateRetired < DateTime.Now)
                {
                    //User is retired.
                    labelIncorrectLogin.Text = "Specified account has been retired";
                    labelIncorrectLogin.Visible = true;
                }
                else
                {
                    labelIncorrectLogin.Visible = false;
                    switch (userInfo.Role)
                    {
                        case "DOC":
                            this.Hide();
                            var doctorForm = new FormDoctor(userInfo.UserID);
                            doctorForm.FormClosed += (s, args) => this.Close();
                            doctorForm.Show();
                            break;
                        case "REC":
                            //Hide this form.
                            this.Hide();
                            //Create a new receptionistForm. MainForm ONLY TEMP.
                            var receptionistForm = new FormReceptionist(userInfo.UserID);
                            //Add closing loginForm to the closing event of receptionistForm.
                            receptionistForm.FormClosed += (s, args) => this.Close();
                            //Show the new receptionistForm.
                            receptionistForm.Show();
                            break;
                        case "TEC":
                            this.Hide();
                            var technicianForm = new FormLabTechnician();
                            technicianForm.FormClosed += (s, args) => this.Close();
                            technicianForm.Show();
                            break;
                        case "MAN":
                            this.Hide();
                            var managerForm = new FormLabManager();
                            managerForm.FormClosed += (s, args) => this.Close();
                            managerForm.Show();
                            break;
                        case "ADM":
                            this.Hide();
                            var adminForm = new FormAdmin();
                            adminForm.FormClosed += (s, args) => this.Close();
                            adminForm.Show();
                            break;
                    }
                }           
            }
            else
            {
                //Incorrect login
                labelIncorrectLogin.Text = "Username or password is incorrect";
                labelIncorrectLogin.Visible = true;
            }
        }
    }
}
