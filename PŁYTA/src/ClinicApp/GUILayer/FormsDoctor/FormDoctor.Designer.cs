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
            this.buttonViewAllForToday = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.DateOfAppointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientPESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBeginVisit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelPanelName = new System.Windows.Forms.Label();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonViewAllForToday
            // 
            this.buttonViewAllForToday.Location = new System.Drawing.Point(651, 244);
            this.buttonViewAllForToday.Name = "buttonViewAllForToday";
            this.buttonViewAllForToday.Size = new System.Drawing.Size(120, 23);
            this.buttonViewAllForToday.TabIndex = 11;
            this.buttonViewAllForToday.Text = "View all for today";
            this.buttonViewAllForToday.UseVisualStyleBackColor = true;
            this.buttonViewAllForToday.Click += new System.EventHandler(this.buttonViewAllForToday_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.comboBoxStatus);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.dateTimePicker);
            this.groupBoxSearch.Controls.Add(this.labelStatus);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Controls.Add(this.labelPESEL);
            this.groupBoxSearch.Controls.Add(this.labelLastName);
            this.groupBoxSearch.Controls.Add(this.labelFirstName);
            this.groupBoxSearch.Controls.Add(this.textBoxPESEL);
            this.groupBoxSearch.Controls.Add(this.textBoxLastName);
            this.groupBoxSearch.Controls.Add(this.textBoxFirstName);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 57);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(783, 89);
            this.groupBoxSearch.TabIndex = 10;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search Appointments";
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
            this.comboBoxStatus.Location = new System.Drawing.Point(501, 43);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStatus.TabIndex = 19;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(639, 40);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(120, 23);
            this.buttonSearch.TabIndex = 14;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(383, 44);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowCheckBox = true;
            this.dateTimePicker.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker.TabIndex = 13;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(498, 28);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(261, 29);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(41, 13);
            this.labelPESEL.TabIndex = 8;
            this.labelPESEL.Text = "PESEL";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(142, 28);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(23, 29);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(264, 44);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPESEL.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(145, 44);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(26, 44);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // dataGridViewAppointments
            // 
            this.dataGridViewAppointments.AllowUserToAddRows = false;
            this.dataGridViewAppointments.AllowUserToDeleteRows = false;
            this.dataGridViewAppointments.AllowUserToResizeColumns = false;
            this.dataGridViewAppointments.AllowUserToResizeRows = false;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateOfAppointment,
            this.PatientFirstName,
            this.PatientLastName,
            this.PatientPESEL,
            this.Status});
            this.dataGridViewAppointments.Location = new System.Drawing.Point(12, 152);
            this.dataGridViewAppointments.MultiSelect = false;
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.ReadOnly = true;
            this.dataGridViewAppointments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(601, 316);
            this.dataGridViewAppointments.TabIndex = 9;
            // 
            // DateOfAppointment
            // 
            this.DateOfAppointment.HeaderText = "DateOfAppointment";
            this.DateOfAppointment.Name = "DateOfAppointment";
            this.DateOfAppointment.ReadOnly = true;
            this.DateOfAppointment.Width = 120;
            // 
            // PatientFirstName
            // 
            this.PatientFirstName.HeaderText = "PatientFirstName";
            this.PatientFirstName.Name = "PatientFirstName";
            this.PatientFirstName.ReadOnly = true;
            this.PatientFirstName.Width = 110;
            // 
            // PatientLastName
            // 
            this.PatientLastName.HeaderText = "PatientLastName";
            this.PatientLastName.Name = "PatientLastName";
            this.PatientLastName.ReadOnly = true;
            this.PatientLastName.Width = 110;
            // 
            // PatientPESEL
            // 
            this.PatientPESEL.HeaderText = "PatientPESEL";
            this.PatientPESEL.Name = "PatientPESEL";
            this.PatientPESEL.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // buttonBeginVisit
            // 
            this.buttonBeginVisit.Location = new System.Drawing.Point(651, 339);
            this.buttonBeginVisit.Name = "buttonBeginVisit";
            this.buttonBeginVisit.Size = new System.Drawing.Size(120, 23);
            this.buttonBeginVisit.TabIndex = 8;
            this.buttonBeginVisit.Text = "View appointment";
            this.buttonBeginVisit.UseVisualStyleBackColor = true;
            this.buttonBeginVisit.Click += new System.EventHandler(this.buttonBeginAppointment_Click);
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 36F);
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(276, 9);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(261, 48);
            this.labelPanelName.TabIndex = 16;
            this.labelPanelName.Text = "Doctor Panel";
            // 
            // FormDoctor
            // 
            this.AcceptButton = this.buttonBeginVisit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 480);
            this.Controls.Add(this.labelPanelName);
            this.Controls.Add(this.buttonViewAllForToday);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Controls.Add(this.buttonBeginVisit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDoctor";
            this.Text = "FormDoctor";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonViewAllForToday;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button buttonBeginVisit;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientPESEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}