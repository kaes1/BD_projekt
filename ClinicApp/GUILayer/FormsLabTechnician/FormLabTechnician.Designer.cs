namespace GUILayer
{
    partial class FormLabTechnician
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
            this.buttonExaminationDisplay = new System.Windows.Forms.Button();
            this.labelLastName = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelDateRegistered = new System.Windows.Forms.Label();
            this.dateTimePickerDateRegistered = new System.Windows.Forms.DateTimePicker();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelExaminationName = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxExaminationName = new System.Windows.Forms.TextBox();
            this.labelPanelName = new System.Windows.Forms.Label();
            this.PatientLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRegistered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLabExaminations = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabExaminations)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonExaminationDisplay
            // 
            this.buttonExaminationDisplay.Location = new System.Drawing.Point(700, 269);
            this.buttonExaminationDisplay.Name = "buttonExaminationDisplay";
            this.buttonExaminationDisplay.Size = new System.Drawing.Size(120, 23);
            this.buttonExaminationDisplay.TabIndex = 22;
            this.buttonExaminationDisplay.Text = "View";
            this.buttonExaminationDisplay.UseVisualStyleBackColor = true;
            this.buttonExaminationDisplay.Click += new System.EventHandler(this.buttonExaminationDisplay_Click);
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(556, 28);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 23;
            this.labelLastName.Text = "Last Name";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.labelLastName);
            this.groupBoxSearch.Controls.Add(this.labelDateRegistered);
            this.groupBoxSearch.Controls.Add(this.dateTimePickerDateRegistered);
            this.groupBoxSearch.Controls.Add(this.labelFirstName);
            this.groupBoxSearch.Controls.Add(this.textBoxLastName);
            this.groupBoxSearch.Controls.Add(this.comboBoxStatus);
            this.groupBoxSearch.Controls.Add(this.labelStatus);
            this.groupBoxSearch.Controls.Add(this.labelExaminationName);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.textBoxFirstName);
            this.groupBoxSearch.Controls.Add(this.textBoxExaminationName);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 57);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(838, 89);
            this.groupBoxSearch.TabIndex = 21;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // labelDateRegistered
            // 
            this.labelDateRegistered.AutoSize = true;
            this.labelDateRegistered.Location = new System.Drawing.Point(22, 28);
            this.labelDateRegistered.Name = "labelDateRegistered";
            this.labelDateRegistered.Size = new System.Drawing.Size(81, 13);
            this.labelDateRegistered.TabIndex = 19;
            this.labelDateRegistered.Text = "DateRegistered";
            // 
            // dateTimePickerDateRegistered
            // 
            this.dateTimePickerDateRegistered.Checked = false;
            this.dateTimePickerDateRegistered.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateRegistered.Location = new System.Drawing.Point(25, 44);
            this.dateTimePickerDateRegistered.Name = "dateTimePickerDateRegistered";
            this.dateTimePickerDateRegistered.ShowCheckBox = true;
            this.dateTimePickerDateRegistered.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDateRegistered.TabIndex = 18;
            this.dateTimePickerDateRegistered.Value = new System.DateTime(2019, 4, 5, 19, 12, 43, 0);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(421, 28);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 22;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(557, 44);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 21;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            " ",
            "REG",
            "BEG",
            "CANC_T",
            "CANC_M",
            "COMP",
            "APP"});
            this.comboBoxStatus.Location = new System.Drawing.Point(291, 44);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStatus.TabIndex = 17;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(288, 28);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Status";
            // 
            // labelExaminationName
            // 
            this.labelExaminationName.AutoSize = true;
            this.labelExaminationName.Location = new System.Drawing.Point(155, 28);
            this.labelExaminationName.Name = "labelExaminationName";
            this.labelExaminationName.Size = new System.Drawing.Size(95, 13);
            this.labelExaminationName.TabIndex = 7;
            this.labelExaminationName.Text = "Examination Name";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(688, 42);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(120, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(424, 44);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 20;
            // 
            // textBoxExaminationName
            // 
            this.textBoxExaminationName.Location = new System.Drawing.Point(158, 44);
            this.textBoxExaminationName.Name = "textBoxExaminationName";
            this.textBoxExaminationName.Size = new System.Drawing.Size(100, 20);
            this.textBoxExaminationName.TabIndex = 4;
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(232, 9);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(427, 48);
            this.labelPanelName.TabIndex = 20;
            this.labelPanelName.Text = "Lab Technician Panel";
            // 
            // PatientLastName
            // 
            this.PatientLastName.HeaderText = "PatientLastName";
            this.PatientLastName.Name = "PatientLastName";
            this.PatientLastName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 70;
            // 
            // Examination
            // 
            this.Examination.HeaderText = "Examination";
            this.Examination.Name = "Examination";
            this.Examination.ReadOnly = true;
            // 
            // DateCompleted
            // 
            this.DateCompleted.HeaderText = "DateCompleted";
            this.DateCompleted.Name = "DateCompleted";
            this.DateCompleted.ReadOnly = true;
            // 
            // DateRegistered
            // 
            this.DateRegistered.HeaderText = "DateRegistered";
            this.DateRegistered.Name = "DateRegistered";
            this.DateRegistered.ReadOnly = true;
            // 
            // PatientFirstName
            // 
            this.PatientFirstName.HeaderText = "PatientFirstName";
            this.PatientFirstName.Name = "PatientFirstName";
            this.PatientFirstName.ReadOnly = true;
            // 
            // dataGridViewLabExaminations
            // 
            this.dataGridViewLabExaminations.AllowUserToAddRows = false;
            this.dataGridViewLabExaminations.AllowUserToDeleteRows = false;
            this.dataGridViewLabExaminations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLabExaminations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateRegistered,
            this.DateCompleted,
            this.Examination,
            this.Status,
            this.PatientFirstName,
            this.PatientLastName});
            this.dataGridViewLabExaminations.Location = new System.Drawing.Point(12, 152);
            this.dataGridViewLabExaminations.Name = "dataGridViewLabExaminations";
            this.dataGridViewLabExaminations.ReadOnly = true;
            this.dataGridViewLabExaminations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewLabExaminations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLabExaminations.Size = new System.Drawing.Size(638, 250);
            this.dataGridViewLabExaminations.TabIndex = 19;
            // 
            // FormLabTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 415);
            this.Controls.Add(this.buttonExaminationDisplay);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.labelPanelName);
            this.Controls.Add(this.dataGridViewLabExaminations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLabTechnician";
            this.Text = "FormLabTechnician";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabExaminations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExaminationDisplay;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label labelDateRegistered;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateRegistered;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelExaminationName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxExaminationName;
        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examination;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRegistered;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientFirstName;
        private System.Windows.Forms.DataGridView dataGridViewLabExaminations;
    }
}