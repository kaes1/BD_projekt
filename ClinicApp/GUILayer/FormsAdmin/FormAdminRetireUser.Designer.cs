namespace GUILayer
{
    partial class FormAdminRetireUser
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
            this.labelPanelName = new System.Windows.Forms.Label();
            this.buttonRetireUser = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.labelRetireDate = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.labelUserID = new System.Windows.Forms.Label();
            this.textBoxRole = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(129, 21);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(183, 37);
            this.labelPanelName.TabIndex = 10;
            this.labelPanelName.Text = "Retire User";
            // 
            // buttonRetireUser
            // 
            this.buttonRetireUser.Location = new System.Drawing.Point(37, 216);
            this.buttonRetireUser.Name = "buttonRetireUser";
            this.buttonRetireUser.Size = new System.Drawing.Size(100, 23);
            this.buttonRetireUser.TabIndex = 32;
            this.buttonRetireUser.Text = "Retire User";
            this.buttonRetireUser.UseVisualStyleBackColor = true;
            this.buttonRetireUser.Click += new System.EventHandler(this.buttonRetireUser_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(297, 216);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 33;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // datePicker
            // 
            this.datePicker.Checked = false;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(154, 169);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(99, 20);
            this.datePicker.TabIndex = 34;
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(269, 169);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(72, 20);
            this.timePicker.TabIndex = 36;
            // 
            // labelRetireDate
            // 
            this.labelRetireDate.AutoSize = true;
            this.labelRetireDate.Location = new System.Drawing.Point(82, 173);
            this.labelRetireDate.Name = "labelRetireDate";
            this.labelRetireDate.Size = new System.Drawing.Size(64, 13);
            this.labelRetireDate.TabIndex = 37;
            this.labelRetireDate.Text = "Retire Date:";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.textBoxUserID);
            this.groupBoxUser.Controls.Add(this.labelUserID);
            this.groupBoxUser.Controls.Add(this.textBoxRole);
            this.groupBoxUser.Controls.Add(this.labelRole);
            this.groupBoxUser.Controls.Add(this.textBoxUsername);
            this.groupBoxUser.Controls.Add(this.labelUsername);
            this.groupBoxUser.Location = new System.Drawing.Point(12, 65);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(411, 77);
            this.groupBoxUser.TabIndex = 38;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(25, 37);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.ReadOnly = true;
            this.textBoxUserID.Size = new System.Drawing.Size(110, 20);
            this.textBoxUserID.TabIndex = 6;
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(22, 21);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(40, 13);
            this.labelUserID.TabIndex = 3;
            this.labelUserID.Text = "UserID";
            // 
            // textBoxRole
            // 
            this.textBoxRole.Location = new System.Drawing.Point(282, 37);
            this.textBoxRole.Name = "textBoxRole";
            this.textBoxRole.ReadOnly = true;
            this.textBoxRole.Size = new System.Drawing.Size(110, 20);
            this.textBoxRole.TabIndex = 8;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(279, 21);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 5;
            this.labelRole.Text = "Role";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(154, 37);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(110, 20);
            this.textBoxUsername.TabIndex = 7;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(151, 21);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            // 
            // FormAdminRetireUser
            // 
            this.AcceptButton = this.buttonRetireUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(435, 267);
            this.Controls.Add(this.groupBoxUser);
            this.Controls.Add(this.labelRetireDate);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRetireUser);
            this.Controls.Add(this.labelPanelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdminRetireUser";
            this.Text = "FormAdminRetireUser";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.Button buttonRetireUser;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label labelRetireDate;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.TextBox textBoxRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelUsername;
    }
}