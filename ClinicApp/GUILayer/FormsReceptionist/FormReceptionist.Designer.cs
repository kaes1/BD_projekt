namespace GUILayer
{
    partial class FormReceptionist
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
            this.buttonSearchPatients = new System.Windows.Forms.Button();
            this.groupBoxSearchPatients = new System.Windows.Forms.GroupBox();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLoggedInAs = new System.Windows.Forms.Label();
            this.labelReceptionistName = new System.Windows.Forms.Label();
            this.labelPanelName = new System.Windows.Forms.Label();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.buttonNewPatient = new System.Windows.Forms.Button();
            this.buttonEditPatient = new System.Windows.Forms.Button();
            this.buttonNewAppointment = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancelAppointment = new System.Windows.Forms.Button();
            this.groupBoxSearchAppointments = new System.Windows.Forms.GroupBox();
            this.buttonSearchAppointments = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxDoctorLastName = new System.Windows.Forms.TextBox();
            this.labelDoctorLastName = new System.Windows.Forms.Label();
            this.groupBoxSearchPatients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.groupBoxSearchAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearchPatients
            // 
            this.buttonSearchPatients.Location = new System.Drawing.Point(552, 42);
            this.buttonSearchPatients.Name = "buttonSearchPatients";
            this.buttonSearchPatients.Size = new System.Drawing.Size(120, 23);
            this.buttonSearchPatients.TabIndex = 2;
            this.buttonSearchPatients.Text = "Search";
            this.buttonSearchPatients.UseVisualStyleBackColor = true;
            this.buttonSearchPatients.Click += new System.EventHandler(this.buttonSearchPatients_Click);
            // 
            // groupBoxSearchPatients
            // 
            this.groupBoxSearchPatients.Controls.Add(this.labelPESEL);
            this.groupBoxSearchPatients.Controls.Add(this.labelLastName);
            this.groupBoxSearchPatients.Controls.Add(this.labelFirstName);
            this.groupBoxSearchPatients.Controls.Add(this.textBoxPESEL);
            this.groupBoxSearchPatients.Controls.Add(this.textBoxLastName);
            this.groupBoxSearchPatients.Controls.Add(this.textBoxFirstName);
            this.groupBoxSearchPatients.Controls.Add(this.buttonSearchPatients);
            this.groupBoxSearchPatients.Location = new System.Drawing.Point(12, 57);
            this.groupBoxSearchPatients.Name = "groupBoxSearchPatients";
            this.groupBoxSearchPatients.Size = new System.Drawing.Size(705, 89);
            this.groupBoxSearchPatients.TabIndex = 3;
            this.groupBoxSearchPatients.TabStop = false;
            this.groupBoxSearchPatients.Text = "Search Patients";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(350, 28);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(41, 13);
            this.labelPESEL.TabIndex = 8;
            this.labelPESEL.Text = "PESEL";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(194, 28);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(41, 28);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(353, 44);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPESEL.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(197, 44);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(44, 44);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelLoggedInAs
            // 
            this.labelLoggedInAs.AutoSize = true;
            this.labelLoggedInAs.Location = new System.Drawing.Point(588, 590);
            this.labelLoggedInAs.Name = "labelLoggedInAs";
            this.labelLoggedInAs.Size = new System.Drawing.Size(73, 13);
            this.labelLoggedInAs.TabIndex = 5;
            this.labelLoggedInAs.Text = "Logged In As:";
            // 
            // labelReceptionistName
            // 
            this.labelReceptionistName.Location = new System.Drawing.Point(527, 611);
            this.labelReceptionistName.Name = "labelReceptionistName";
            this.labelReceptionistName.Size = new System.Drawing.Size(195, 13);
            this.labelReceptionistName.TabIndex = 6;
            this.labelReceptionistName.Text = "Name Surname";
            this.labelReceptionistName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(184, 9);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(363, 48);
            this.labelPanelName.TabIndex = 8;
            this.labelPanelName.Text = "Receptionist Panel";
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AllowUserToAddRows = false;
            this.dataGridViewAppointments.AllowUserToDeleteRows = false;
            this.dataGridViewAppointments.AllowUserToResizeColumns = false;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Status,
            this.DoctorFirstName,
            this.DoctorLastName});
            this.dataGridViewAppointments.Location = new System.Drawing.Point(12, 447);
            this.dataGridViewAppointments.MultiSelect = false;
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.ReadOnly = true;
            this.dataGridViewAppointments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(505, 180);
            this.dataGridViewAppointments.TabIndex = 11;
            // 
            // buttonNewPatient
            // 
            this.buttonNewPatient.Location = new System.Drawing.Point(564, 183);
            this.buttonNewPatient.Name = "buttonNewPatient";
            this.buttonNewPatient.Size = new System.Drawing.Size(120, 23);
            this.buttonNewPatient.TabIndex = 0;
            this.buttonNewPatient.Text = "New Patient";
            this.buttonNewPatient.UseVisualStyleBackColor = true;
            this.buttonNewPatient.Click += new System.EventHandler(this.buttonNewPatient_Click);
            // 
            // buttonEditPatient
            // 
            this.buttonEditPatient.Location = new System.Drawing.Point(564, 239);
            this.buttonEditPatient.Name = "buttonEditPatient";
            this.buttonEditPatient.Size = new System.Drawing.Size(120, 23);
            this.buttonEditPatient.TabIndex = 14;
            this.buttonEditPatient.Text = "Edit Patient";
            this.buttonEditPatient.UseVisualStyleBackColor = true;
            this.buttonEditPatient.Click += new System.EventHandler(this.buttonEditPatient_Click);
            // 
            // buttonNewAppointment
            // 
            this.buttonNewAppointment.Location = new System.Drawing.Point(564, 482);
            this.buttonNewAppointment.Name = "buttonNewAppointment";
            this.buttonNewAppointment.Size = new System.Drawing.Size(120, 23);
            this.buttonNewAppointment.TabIndex = 12;
            this.buttonNewAppointment.Text = "New Appointment";
            this.buttonNewAppointment.UseVisualStyleBackColor = true;
            this.buttonNewAppointment.Click += new System.EventHandler(this.buttonNewAppointment_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AllowUserToResizeColumns = false;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.PESEL,
            this.PatientID});
            this.dataGridViewPatients.Location = new System.Drawing.Point(12, 152);
            this.dataGridViewPatients.MultiSelect = false;
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(505, 177);
            this.dataGridViewPatients.TabIndex = 1;
            this.dataGridViewPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellClick);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 124;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 124;
            // 
            // PESEL
            // 
            this.PESEL.HeaderText = "PESEL";
            this.PESEL.Name = "PESEL";
            this.PESEL.ReadOnly = true;
            this.PESEL.Width = 124;
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "PatientID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 72;
            // 
            // buttonCancelAppointment
            // 
            this.buttonCancelAppointment.Location = new System.Drawing.Point(564, 542);
            this.buttonCancelAppointment.Name = "buttonCancelAppointment";
            this.buttonCancelAppointment.Size = new System.Drawing.Size(120, 23);
            this.buttonCancelAppointment.TabIndex = 13;
            this.buttonCancelAppointment.Text = "Cancel Appointment";
            this.buttonCancelAppointment.UseVisualStyleBackColor = true;
            this.buttonCancelAppointment.Click += new System.EventHandler(this.buttonCancelAppointment_Click);
            // 
            // groupBoxSearchAppointments
            // 
            this.groupBoxSearchAppointments.Controls.Add(this.labelDoctorLastName);
            this.groupBoxSearchAppointments.Controls.Add(this.textBoxDoctorLastName);
            this.groupBoxSearchAppointments.Controls.Add(this.labelDate);
            this.groupBoxSearchAppointments.Controls.Add(this.dateTimePickerAppointmentDate);
            this.groupBoxSearchAppointments.Controls.Add(this.labelStatus);
            this.groupBoxSearchAppointments.Controls.Add(this.comboBoxStatus);
            this.groupBoxSearchAppointments.Controls.Add(this.buttonSearchAppointments);
            this.groupBoxSearchAppointments.Location = new System.Drawing.Point(12, 352);
            this.groupBoxSearchAppointments.Name = "groupBoxSearchAppointments";
            this.groupBoxSearchAppointments.Size = new System.Drawing.Size(705, 89);
            this.groupBoxSearchAppointments.TabIndex = 15;
            this.groupBoxSearchAppointments.TabStop = false;
            this.groupBoxSearchAppointments.Text = "Search Appointments";
            // 
            // buttonSearchAppointments
            // 
            this.buttonSearchAppointments.Location = new System.Drawing.Point(552, 40);
            this.buttonSearchAppointments.Name = "buttonSearchAppointments";
            this.buttonSearchAppointments.Size = new System.Drawing.Size(120, 23);
            this.buttonSearchAppointments.TabIndex = 9;
            this.buttonSearchAppointments.Text = "Search";
            this.buttonSearchAppointments.UseVisualStyleBackColor = true;
            this.buttonSearchAppointments.Click += new System.EventHandler(this.buttonSearchAppointments_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            " ",
            "REG",
            "CANC",
            "COMP",
            "BEG"});
            this.comboBoxStatus.Location = new System.Drawing.Point(197, 44);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStatus.TabIndex = 18;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(194, 28);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 19;
            this.labelStatus.Text = "Status";
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.Checked = false;
            this.dateTimePickerAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(44, 44);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.ShowCheckBox = true;
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerAppointmentDate.TabIndex = 19;
            this.dateTimePickerAppointmentDate.Value = new System.DateTime(2019, 4, 5, 19, 12, 43, 0);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(41, 28);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(30, 13);
            this.labelDate.TabIndex = 20;
            this.labelDate.Text = "Date";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 124;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 72;
            // 
            // DoctorFirstName
            // 
            this.DoctorFirstName.HeaderText = "DoctorFirstName";
            this.DoctorFirstName.Name = "DoctorFirstName";
            this.DoctorFirstName.ReadOnly = true;
            this.DoctorFirstName.Width = 124;
            // 
            // DoctorLastName
            // 
            this.DoctorLastName.HeaderText = "DoctorLastName";
            this.DoctorLastName.Name = "DoctorLastName";
            this.DoctorLastName.ReadOnly = true;
            this.DoctorLastName.Width = 124;
            // 
            // textBoxDoctorLastName
            // 
            this.textBoxDoctorLastName.Location = new System.Drawing.Point(353, 44);
            this.textBoxDoctorLastName.Name = "textBoxDoctorLastName";
            this.textBoxDoctorLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDoctorLastName.TabIndex = 21;
            // 
            // labelDoctorLastName
            // 
            this.labelDoctorLastName.AutoSize = true;
            this.labelDoctorLastName.Location = new System.Drawing.Point(350, 28);
            this.labelDoctorLastName.Name = "labelDoctorLastName";
            this.labelDoctorLastName.Size = new System.Drawing.Size(93, 13);
            this.labelDoctorLastName.TabIndex = 22;
            this.labelDoctorLastName.Text = "Doctor Last Name";
            // 
            // FormReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 639);
            this.Controls.Add(this.groupBoxSearchAppointments);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.buttonCancelAppointment);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.buttonNewAppointment);
            this.Controls.Add(this.buttonEditPatient);
            this.Controls.Add(this.labelPanelName);
            this.Controls.Add(this.buttonNewPatient);
            this.Controls.Add(this.labelReceptionistName);
            this.Controls.Add(this.labelLoggedInAs);
            this.Controls.Add(this.groupBoxSearchPatients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormReceptionist";
            this.Text = "FormReceptionist";
            this.groupBoxSearchPatients.ResumeLayout(false);
            this.groupBoxSearchPatients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.groupBoxSearchAppointments.ResumeLayout(false);
            this.groupBoxSearchAppointments.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearchPatients;
        private System.Windows.Forms.GroupBox groupBoxSearchPatients;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLoggedInAs;
        private System.Windows.Forms.Label labelReceptionistName;
        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button buttonNewPatient;
        private System.Windows.Forms.Button buttonEditPatient;
        private System.Windows.Forms.Button buttonNewAppointment;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Button buttonCancelAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.GroupBox groupBoxSearchAppointments;
        private System.Windows.Forms.Button buttonSearchAppointments;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorLastName;
        private System.Windows.Forms.Label labelDoctorLastName;
        private System.Windows.Forms.TextBox textBoxDoctorLastName;
    }
}