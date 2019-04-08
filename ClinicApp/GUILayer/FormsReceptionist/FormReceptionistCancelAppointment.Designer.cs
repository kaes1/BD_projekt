namespace GUILayer
{
    partial class FormReceptionistCancelAppointment
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
            this.buttonCancelAppointment = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPanelName = new System.Windows.Forms.Label();
            this.groupBoxAppointment = new System.Windows.Forms.GroupBox();
            this.textBoxDoctor = new System.Windows.Forms.TextBox();
            this.labelDoctor = new System.Windows.Forms.Label();
            this.textBoxDateAndTime = new System.Windows.Forms.TextBox();
            this.labelDateAndTime = new System.Windows.Forms.Label();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.groupBoxAppointment.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancelAppointment
            // 
            this.buttonCancelAppointment.Location = new System.Drawing.Point(27, 262);
            this.buttonCancelAppointment.Name = "buttonCancelAppointment";
            this.buttonCancelAppointment.Size = new System.Drawing.Size(100, 23);
            this.buttonCancelAppointment.TabIndex = 27;
            this.buttonCancelAppointment.Text = "Cancel";
            this.buttonCancelAppointment.UseVisualStyleBackColor = true;
            this.buttonCancelAppointment.Click += new System.EventHandler(this.buttonCancelAppointment_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(283, 262);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Back";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(58, 9);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(305, 37);
            this.labelPanelName.TabIndex = 29;
            this.labelPanelName.Text = "Cancel Appointment";
            // 
            // groupBoxAppointment
            // 
            this.groupBoxAppointment.Controls.Add(this.textBoxDoctor);
            this.groupBoxAppointment.Controls.Add(this.labelDoctor);
            this.groupBoxAppointment.Controls.Add(this.textBoxDateAndTime);
            this.groupBoxAppointment.Controls.Add(this.labelDateAndTime);
            this.groupBoxAppointment.Location = new System.Drawing.Point(12, 156);
            this.groupBoxAppointment.Name = "groupBoxAppointment";
            this.groupBoxAppointment.Size = new System.Drawing.Size(385, 77);
            this.groupBoxAppointment.TabIndex = 31;
            this.groupBoxAppointment.TabStop = false;
            this.groupBoxAppointment.Text = "Appointment";
            // 
            // textBoxDoctor
            // 
            this.textBoxDoctor.Location = new System.Drawing.Point(15, 37);
            this.textBoxDoctor.Name = "textBoxDoctor";
            this.textBoxDoctor.ReadOnly = true;
            this.textBoxDoctor.Size = new System.Drawing.Size(171, 20);
            this.textBoxDoctor.TabIndex = 6;
            // 
            // labelDoctor
            // 
            this.labelDoctor.AutoSize = true;
            this.labelDoctor.Location = new System.Drawing.Point(12, 21);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(39, 13);
            this.labelDoctor.TabIndex = 3;
            this.labelDoctor.Text = "Doctor";
            // 
            // textBoxDateAndTime
            // 
            this.textBoxDateAndTime.Location = new System.Drawing.Point(200, 37);
            this.textBoxDateAndTime.Name = "textBoxDateAndTime";
            this.textBoxDateAndTime.ReadOnly = true;
            this.textBoxDateAndTime.Size = new System.Drawing.Size(171, 20);
            this.textBoxDateAndTime.TabIndex = 8;
            // 
            // labelDateAndTime
            // 
            this.labelDateAndTime.AutoSize = true;
            this.labelDateAndTime.Location = new System.Drawing.Point(197, 21);
            this.labelDateAndTime.Name = "labelDateAndTime";
            this.labelDateAndTime.Size = new System.Drawing.Size(77, 13);
            this.labelDateAndTime.TabIndex = 5;
            this.labelDateAndTime.Text = "Date and Time";
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatient.Controls.Add(this.labelFirstName);
            this.groupBoxPatient.Controls.Add(this.textBoxPESEL);
            this.groupBoxPatient.Controls.Add(this.labelPESEL);
            this.groupBoxPatient.Controls.Add(this.textBoxLastName);
            this.groupBoxPatient.Controls.Add(this.labelLastName);
            this.groupBoxPatient.Location = new System.Drawing.Point(12, 60);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(385, 77);
            this.groupBoxPatient.TabIndex = 32;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(15, 37);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 21);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(271, 37);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.ReadOnly = true;
            this.textBoxPESEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPESEL.TabIndex = 8;
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(268, 21);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(41, 13);
            this.labelPESEL.TabIndex = 5;
            this.labelPESEL.Text = "PESEL";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(143, 37);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 7;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(140, 21);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";
            // 
            // FormReceptionistCancelAppointment
            // 
            this.AcceptButton = this.buttonCancelAppointment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(409, 305);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.groupBoxAppointment);
            this.Controls.Add(this.labelPanelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCancelAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormReceptionistCancelAppointment";
            this.Text = "FormReceptionistCancelAppointment";
            this.groupBoxAppointment.ResumeLayout(false);
            this.groupBoxAppointment.PerformLayout();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelAppointment;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.GroupBox groupBoxAppointment;
        private System.Windows.Forms.TextBox textBoxDoctor;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.TextBox textBoxDateAndTime;
        private System.Windows.Forms.Label labelDateAndTime;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
    }
}