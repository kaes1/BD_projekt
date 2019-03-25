namespace GUILayer
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPanelName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBoxLoginForm = new System.Windows.Forms.GroupBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelPleaseLogin = new System.Windows.Forms.Label();
            this.labelIncorrectLogin = new System.Windows.Forms.Label();
            this.groupBoxLoginForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(43, 49);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(219, 22);
            this.textBoxUsername.TabIndex = 0;
            this.textBoxUsername.Text = "doctor";
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(108, 27);
            this.labelPanelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(286, 75);
            this.labelPanelName.TabIndex = 1;
            this.labelPanelName.Text = "ClinicApp";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(39, 30);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 17);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(39, 92);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(43, 112);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(219, 22);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "test";
            // 
            // groupBoxLoginForm
            // 
            this.groupBoxLoginForm.Controls.Add(this.buttonLogin);
            this.groupBoxLoginForm.Controls.Add(this.textBoxUsername);
            this.groupBoxLoginForm.Controls.Add(this.textBoxPassword);
            this.groupBoxLoginForm.Controls.Add(this.labelUsername);
            this.groupBoxLoginForm.Controls.Add(this.labelPassword);
            this.groupBoxLoginForm.Location = new System.Drawing.Point(81, 148);
            this.groupBoxLoginForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxLoginForm.Name = "groupBoxLoginForm";
            this.groupBoxLoginForm.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxLoginForm.Size = new System.Drawing.Size(311, 217);
            this.groupBoxLoginForm.TabIndex = 5;
            this.groupBoxLoginForm.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.AutoSize = true;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLogin.Location = new System.Drawing.Point(103, 161);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(100, 37);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelPleaseLogin
            // 
            this.labelPleaseLogin.AutoSize = true;
            this.labelPleaseLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPleaseLogin.Location = new System.Drawing.Point(153, 111);
            this.labelPleaseLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPleaseLogin.Name = "labelPleaseLogin";
            this.labelPleaseLogin.Size = new System.Drawing.Size(154, 29);
            this.labelPleaseLogin.TabIndex = 6;
            this.labelPleaseLogin.Text = "Please Login";
            // 
            // labelIncorrectLogin
            // 
            this.labelIncorrectLogin.AutoSize = true;
            this.labelIncorrectLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIncorrectLogin.ForeColor = System.Drawing.Color.Red;
            this.labelIncorrectLogin.Location = new System.Drawing.Point(105, 396);
            this.labelIncorrectLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIncorrectLogin.Name = "labelIncorrectLogin";
            this.labelIncorrectLogin.Size = new System.Drawing.Size(241, 18);
            this.labelIncorrectLogin.TabIndex = 7;
            this.labelIncorrectLogin.Text = "Username or password is incorrect";
            this.labelIncorrectLogin.Visible = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 460);
            this.Controls.Add(this.labelIncorrectLogin);
            this.Controls.Add(this.labelPleaseLogin);
            this.Controls.Add(this.groupBoxLoginForm);
            this.Controls.Add(this.labelPanelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLogin";
            this.Text = "ClinicApp";
            this.groupBoxLoginForm.ResumeLayout(false);
            this.groupBoxLoginForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBoxLoginForm;
        private System.Windows.Forms.Label labelPleaseLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelIncorrectLogin;
    }
}