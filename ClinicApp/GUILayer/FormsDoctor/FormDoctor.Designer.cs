namespace GUILayer
{
    partial class FormDoctor
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
            this.buttonCheckPatient = new System.Windows.Forms.Button();
            this.labelDoctorName = new System.Windows.Forms.Label();
            this.labelLoggedInAs = new System.Windows.Forms.Label();
            this.buttonViewAllForToday = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.TimeOfVisit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBeginVisit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelPanelName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCheckPatient
            // 
            this.buttonCheckPatient.Location = new System.Drawing.Point(879, 405);
            this.buttonCheckPatient.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheckPatient.Name = "buttonCheckPatient";
            this.buttonCheckPatient.Size = new System.Drawing.Size(140, 28);
            this.buttonCheckPatient.TabIndex = 14;
            this.buttonCheckPatient.Text = "Check Patient";
            this.buttonCheckPatient.UseVisualStyleBackColor = true;
            // 
            // labelDoctorName
            // 
            this.labelDoctorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDoctorName.Location = new System.Drawing.Point(815, 588);
            this.labelDoctorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDoctorName.Name = "labelDoctorName";
            this.labelDoctorName.Size = new System.Drawing.Size(260, 16);
            this.labelDoctorName.TabIndex = 13;
            this.labelDoctorName.Text = "Name Surname";
            this.labelDoctorName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoggedInAs
            // 
            this.labelLoggedInAs.AutoSize = true;
            this.labelLoggedInAs.Location = new System.Drawing.Point(897, 542);
            this.labelLoggedInAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoggedInAs.Name = "labelLoggedInAs";
            this.labelLoggedInAs.Size = new System.Drawing.Size(95, 17);
            this.labelLoggedInAs.TabIndex = 12;
            this.labelLoggedInAs.Text = "Logged In As:";
            // 
            // buttonViewAllForToday
            // 
            this.buttonViewAllForToday.Location = new System.Drawing.Point(879, 282);
            this.buttonViewAllForToday.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewAllForToday.Name = "buttonViewAllForToday";
            this.buttonViewAllForToday.Size = new System.Drawing.Size(140, 28);
            this.buttonViewAllForToday.TabIndex = 11;
            this.buttonViewAllForToday.Text = "View all for today";
            this.buttonViewAllForToday.UseVisualStyleBackColor = true;
            this.buttonViewAllForToday.Click += new System.EventHandler(this.buttonViewAllForToday_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.dateTimePicker);
            this.groupBoxSearch.Controls.Add(this.textBoxStatus);
            this.groupBoxSearch.Controls.Add(this.labelStatus);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Controls.Add(this.labelPESEL);
            this.groupBoxSearch.Controls.Add(this.labelLastName);
            this.groupBoxSearch.Controls.Add(this.labelFirstName);
            this.groupBoxSearch.Controls.Add(this.textBoxPESEL);
            this.groupBoxSearch.Controls.Add(this.textBoxLastName);
            this.groupBoxSearch.Controls.Add(this.textBoxFirstName);
            this.groupBoxSearch.Location = new System.Drawing.Point(16, 98);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSearch.Size = new System.Drawing.Size(1052, 116);
            this.groupBoxSearch.TabIndex = 10;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(465, 63);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowCheckBox = true;
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 13;
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(676, 63);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(132, 22);
            this.textBoxStatus.TabIndex = 12;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(673, 43);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(48, 17);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(317, 43);
            this.labelPESEL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(52, 17);
            this.labelPESEL.TabIndex = 8;
            this.labelPESEL.Text = "PESEL";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(172, 43);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 17);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(27, 43);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 17);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(321, 63);
            this.textBoxPESEL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(132, 22);
            this.textBoxPESEL.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(176, 63);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(132, 22);
            this.textBoxLastName.TabIndex = 4;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(31, 63);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(132, 22);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeOfVisit,
            this.FirstName,
            this.LastName,
            this.PESEL,
            this.Status});
            this.dataGridViewPatients.Location = new System.Drawing.Point(16, 252);
            this.dataGridViewPatients.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(789, 385);
            this.dataGridViewPatients.TabIndex = 9;
            // 
            // TimeOfVisit
            // 
            this.TimeOfVisit.HeaderText = "TimeOfVisit";
            this.TimeOfVisit.Name = "TimeOfVisit";
            this.TimeOfVisit.ReadOnly = true;
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
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // buttonBeginVisit
            // 
            this.buttonBeginVisit.Location = new System.Drawing.Point(879, 341);
            this.buttonBeginVisit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBeginVisit.Name = "buttonBeginVisit";
            this.buttonBeginVisit.Size = new System.Drawing.Size(140, 28);
            this.buttonBeginVisit.TabIndex = 8;
            this.buttonBeginVisit.Text = "Begin examination";
            this.buttonBeginVisit.UseVisualStyleBackColor = true;
            this.buttonBeginVisit.Click += new System.EventHandler(this.buttonSelectPatient_Click);
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(343, 11);
            this.labelPanelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(375, 69);
            this.labelPanelName.TabIndex = 16;
            this.labelPanelName.Text = "Doctor Panel";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(923, 63);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 650);
            this.Controls.Add(this.labelPanelName);
            this.Controls.Add(this.buttonCheckPatient);
            this.Controls.Add(this.labelDoctorName);
            this.Controls.Add(this.labelLoggedInAs);
            this.Controls.Add(this.buttonViewAllForToday);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.buttonBeginVisit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDoctor";
            this.Text = "FormDoctor";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCheckPatient;
        private System.Windows.Forms.Label labelDoctorName;
        private System.Windows.Forms.Label labelLoggedInAs;
        private System.Windows.Forms.Button buttonViewAllForToday;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Button buttonBeginVisit;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOfVisit;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonSearch;
    }
}