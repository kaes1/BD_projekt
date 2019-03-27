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
            this.buttonEditExamination = new System.Windows.Forms.Button();
            this.buttonCheckExamination = new System.Windows.Forms.Button();
            this.labelReceptionistName = new System.Windows.Forms.Label();
            this.labelLoggedInAs = new System.Windows.Forms.Label();
            this.buttonViewAllForToday = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.buttonBeginExamination = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxExaminationID = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEditExamination
            // 
            this.buttonEditExamination.Location = new System.Drawing.Point(617, 287);
            this.buttonEditExamination.Name = "buttonEditExamination";
            this.buttonEditExamination.Size = new System.Drawing.Size(105, 23);
            this.buttonEditExamination.TabIndex = 23;
            this.buttonEditExamination.Text = "Edit Examination";
            this.buttonEditExamination.UseVisualStyleBackColor = true;
            // 
            // buttonCheckExamination
            // 
            this.buttonCheckExamination.Location = new System.Drawing.Point(617, 333);
            this.buttonCheckExamination.Name = "buttonCheckExamination";
            this.buttonCheckExamination.Size = new System.Drawing.Size(105, 23);
            this.buttonCheckExamination.TabIndex = 22;
            this.buttonCheckExamination.Text = "Check Examination";
            this.buttonCheckExamination.UseVisualStyleBackColor = true;
            // 
            // labelReceptionistName
            // 
            this.labelReceptionistName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReceptionistName.Location = new System.Drawing.Point(575, 408);
            this.labelReceptionistName.Name = "labelReceptionistName";
            this.labelReceptionistName.Size = new System.Drawing.Size(195, 13);
            this.labelReceptionistName.TabIndex = 21;
            this.labelReceptionistName.Text = "Name Surname";
            this.labelReceptionistName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoggedInAs
            // 
            this.labelLoggedInAs.AutoSize = true;
            this.labelLoggedInAs.Location = new System.Drawing.Point(637, 375);
            this.labelLoggedInAs.Name = "labelLoggedInAs";
            this.labelLoggedInAs.Size = new System.Drawing.Size(73, 13);
            this.labelLoggedInAs.TabIndex = 20;
            this.labelLoggedInAs.Text = "Logged In As:";
            // 
            // buttonViewAllForToday
            // 
            this.buttonViewAllForToday.Location = new System.Drawing.Point(617, 191);
            this.buttonViewAllForToday.Name = "buttonViewAllForToday";
            this.buttonViewAllForToday.Size = new System.Drawing.Size(105, 23);
            this.buttonViewAllForToday.TabIndex = 19;
            this.buttonViewAllForToday.Text = "View all for today";
            this.buttonViewAllForToday.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.label2);
            this.groupBoxSearch.Controls.Add(this.textBoxExaminationID);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Controls.Add(this.textBoxDate);
            this.groupBoxSearch.Controls.Add(this.labelPESEL);
            this.groupBoxSearch.Controls.Add(this.labelLastName);
            this.groupBoxSearch.Controls.Add(this.labelFirstName);
            this.groupBoxSearch.Controls.Add(this.textBoxPESEL);
            this.groupBoxSearch.Controls.Add(this.textBoxLastName);
            this.groupBoxSearch.Controls.Add(this.textBoxFirstName);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(31, 21);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(739, 114);
            this.groupBoxSearch.TabIndex = 18;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(397, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date DD-MM-YYYY";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(395, 56);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDate.TabIndex = 9;
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(270, 40);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(41, 13);
            this.labelPESEL.TabIndex = 8;
            this.labelPESEL.Text = "PESEL";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(136, 40);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(3, 40);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(273, 56);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPESEL.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(139, 56);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(6, 56);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(628, 56);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.LastName,
            this.FirstName,
            this.Examination,
            this.PESEL,
            this.State});
            this.dataGridViewPatients.Location = new System.Drawing.Point(31, 141);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.Size = new System.Drawing.Size(517, 289);
            this.dataGridViewPatients.TabIndex = 17;
            // 
            // buttonBeginExamination
            // 
            this.buttonBeginExamination.Location = new System.Drawing.Point(617, 239);
            this.buttonBeginExamination.Name = "buttonBeginExamination";
            this.buttonBeginExamination.Size = new System.Drawing.Size(105, 23);
            this.buttonBeginExamination.TabIndex = 16;
            this.buttonBeginExamination.Text = "Begin examination";
            this.buttonBeginExamination.UseVisualStyleBackColor = true;
            this.buttonBeginExamination.Click += new System.EventHandler(this.buttonBeginExamination_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Examination ID";
            // 
            // textBoxExaminationID
            // 
            this.textBoxExaminationID.Location = new System.Drawing.Point(511, 56);
            this.textBoxExaminationID.Name = "textBoxExaminationID";
            this.textBoxExaminationID.Size = new System.Drawing.Size(100, 20);
            this.textBoxExaminationID.TabIndex = 11;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 124;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 124;
            // 
            // Examination
            // 
            this.Examination.HeaderText = "Examination";
            this.Examination.Name = "Examination";
            this.Examination.ReadOnly = true;
            // 
            // PESEL
            // 
            this.PESEL.HeaderText = "PESEL";
            this.PESEL.Name = "PESEL";
            this.PESEL.ReadOnly = true;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // FormLabTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEditExamination);
            this.Controls.Add(this.buttonCheckExamination);
            this.Controls.Add(this.labelReceptionistName);
            this.Controls.Add(this.labelLoggedInAs);
            this.Controls.Add(this.buttonViewAllForToday);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.buttonBeginExamination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLabTechnician";
            this.Text = "FormLabTechnician";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditExamination;
        private System.Windows.Forms.Button buttonCheckExamination;
        private System.Windows.Forms.Label labelReceptionistName;
        private System.Windows.Forms.Label labelLoggedInAs;
        private System.Windows.Forms.Button buttonViewAllForToday;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Button buttonBeginExamination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxExaminationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examination;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESEL;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
    }
}