namespace GUILayer
{
    partial class FormReceptionistNewAppointment
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
            this.buttonAddAppointment = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPanelName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PWZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAppointmentTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.groupBoxPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.Location = new System.Drawing.Point(42, 441);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(100, 23);
            this.buttonAddAppointment.TabIndex = 0;
            this.buttonAddAppointment.Text = "Add Appointment";
            this.buttonAddAppointment.UseVisualStyleBackColor = true;
            this.buttonAddAppointment.Click += new System.EventHandler(this.buttonAddAppointment_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(311, 441);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Back";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(54, 20);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(344, 37);
            this.labelPanelName.TabIndex = 2;
            this.labelPanelName.Text = "Add New Appointment";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(27, 21);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(163, 21);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(296, 21);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(41, 13);
            this.labelPESEL.TabIndex = 5;
            this.labelPESEL.Text = "PESEL";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(30, 37);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(166, 37);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 7;
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(299, 37);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.ReadOnly = true;
            this.textBoxPESEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPESEL.TabIndex = 8;
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorID,
            this.FirstName,
            this.LastName,
            this.PWZ});
            this.dataGridViewDoctors.Location = new System.Drawing.Point(14, 169);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.Size = new System.Drawing.Size(429, 185);
            this.dataGridViewDoctors.TabIndex = 9;
            // 
            // DoctorID
            // 
            this.DoctorID.HeaderText = "DoctorID";
            this.DoctorID.Name = "DoctorID";
            this.DoctorID.ReadOnly = true;
            this.DoctorID.Width = 86;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // PWZ
            // 
            this.PWZ.HeaderText = "PWZ";
            this.PWZ.Name = "PWZ";
            this.PWZ.ReadOnly = true;
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatient.Controls.Add(this.labelFirstName);
            this.groupBoxPatient.Controls.Add(this.textBoxPESEL);
            this.groupBoxPatient.Controls.Add(this.labelPESEL);
            this.groupBoxPatient.Controls.Add(this.textBoxLastName);
            this.groupBoxPatient.Controls.Add(this.labelLastName);
            this.groupBoxPatient.Location = new System.Drawing.Point(12, 75);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(432, 77);
            this.groupBoxPatient.TabIndex = 10;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(104, 378);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerAppointmentDate.TabIndex = 20;
            this.dateTimePickerAppointmentDate.Value = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            // 
            // dateTimePickerAppointmentTime
            // 
            this.dateTimePickerAppointmentTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerAppointmentTime.Location = new System.Drawing.Point(235, 378);
            this.dateTimePickerAppointmentTime.Name = "dateTimePickerAppointmentTime";
            this.dateTimePickerAppointmentTime.ShowUpDown = true;
            this.dateTimePickerAppointmentTime.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerAppointmentTime.TabIndex = 21;
            this.dateTimePickerAppointmentTime.Value = new System.DateTime(2019, 4, 19, 12, 30, 0, 0);
            // 
            // FormReceptionistNewAppointment
            // 
            this.AcceptButton = this.buttonAddAppointment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(456, 493);
            this.Controls.Add(this.dateTimePickerAppointmentTime);
            this.Controls.Add(this.dateTimePickerAppointmentDate);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Controls.Add(this.labelPanelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormReceptionistNewAppointment";
            this.Text = "FormReceptionistNewAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PWZ;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentTime;
    }
}