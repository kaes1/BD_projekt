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
            this.buttonBeginTest = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLabTestID = new System.Windows.Forms.TextBox();
            this.labelLabTestID = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.buttonViewAllForToday = new System.Windows.Forms.Button();
            this.labelLoggedInAs = new System.Windows.Forms.Label();
            this.labelReceptionistName = new System.Windows.Forms.Label();
            this.buttonEditTest = new System.Windows.Forms.Button();
            this.DateRegistered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcedureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBeginTest
            // 
            this.buttonBeginTest.Location = new System.Drawing.Point(883, 304);
            this.buttonBeginTest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBeginTest.Name = "buttonBeginTest";
            this.buttonBeginTest.Size = new System.Drawing.Size(140, 28);
            this.buttonBeginTest.TabIndex = 16;
            this.buttonBeginTest.Text = "Begin Test";
            this.buttonBeginTest.UseVisualStyleBackColor = true;
            this.buttonBeginTest.Click += new System.EventHandler(this.buttonBeginExamination_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateRegistered,
            this.DateComplete,
            this.LabTestID,
            this.FirstName,
            this.LastName,
            this.ProcedureName,
            this.Status});
            this.dataGridViewPatients.Location = new System.Drawing.Point(41, 174);
            this.dataGridViewPatients.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.Size = new System.Drawing.Size(795, 356);
            this.dataGridViewPatients.TabIndex = 17;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(635, 66);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(140, 28);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(8, 69);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(132, 22);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(185, 69);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(132, 22);
            this.textBoxLastName.TabIndex = 4;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(4, 49);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 17);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(181, 49);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 17);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Last Name";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(341, 69);
            this.textBoxDate.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(132, 22);
            this.textBoxDate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Date DD-MM-YYYY";
            // 
            // textBoxLabTestID
            // 
            this.textBoxLabTestID.Location = new System.Drawing.Point(495, 69);
            this.textBoxLabTestID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLabTestID.Name = "textBoxLabTestID";
            this.textBoxLabTestID.Size = new System.Drawing.Size(132, 22);
            this.textBoxLabTestID.TabIndex = 11;
            // 
            // labelLabTestID
            // 
            this.labelLabTestID.AutoSize = true;
            this.labelLabTestID.Location = new System.Drawing.Point(495, 48);
            this.labelLabTestID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLabTestID.Name = "labelLabTestID";
            this.labelLabTestID.Size = new System.Drawing.Size(81, 17);
            this.labelLabTestID.TabIndex = 12;
            this.labelLabTestID.Text = "Lab Test ID";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.labelLabTestID);
            this.groupBoxSearch.Controls.Add(this.textBoxLabTestID);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Controls.Add(this.textBoxDate);
            this.groupBoxSearch.Controls.Add(this.labelLastName);
            this.groupBoxSearch.Controls.Add(this.labelFirstName);
            this.groupBoxSearch.Controls.Add(this.textBoxLastName);
            this.groupBoxSearch.Controls.Add(this.textBoxFirstName);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(41, 26);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSearch.Size = new System.Drawing.Size(795, 140);
            this.groupBoxSearch.TabIndex = 18;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // buttonViewAllForToday
            // 
            this.buttonViewAllForToday.Location = new System.Drawing.Point(883, 245);
            this.buttonViewAllForToday.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewAllForToday.Name = "buttonViewAllForToday";
            this.buttonViewAllForToday.Size = new System.Drawing.Size(140, 28);
            this.buttonViewAllForToday.TabIndex = 19;
            this.buttonViewAllForToday.Text = "View all for today";
            this.buttonViewAllForToday.UseVisualStyleBackColor = true;
            // 
            // labelLoggedInAs
            // 
            this.labelLoggedInAs.AutoSize = true;
            this.labelLoggedInAs.Location = new System.Drawing.Point(909, 455);
            this.labelLoggedInAs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoggedInAs.Name = "labelLoggedInAs";
            this.labelLoggedInAs.Size = new System.Drawing.Size(95, 17);
            this.labelLoggedInAs.TabIndex = 20;
            this.labelLoggedInAs.Text = "Logged In As:";
            // 
            // labelReceptionistName
            // 
            this.labelReceptionistName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReceptionistName.Location = new System.Drawing.Point(858, 488);
            this.labelReceptionistName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelReceptionistName.Name = "labelReceptionistName";
            this.labelReceptionistName.Size = new System.Drawing.Size(196, 16);
            this.labelReceptionistName.TabIndex = 21;
            this.labelReceptionistName.Text = "Name Surname";
            this.labelReceptionistName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEditTest
            // 
            this.buttonEditTest.Location = new System.Drawing.Point(883, 363);
            this.buttonEditTest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditTest.Name = "buttonEditTest";
            this.buttonEditTest.Size = new System.Drawing.Size(140, 28);
            this.buttonEditTest.TabIndex = 23;
            this.buttonEditTest.Text = "Edit Test";
            this.buttonEditTest.UseVisualStyleBackColor = true;
            // 
            // DateRegistered
            // 
            this.DateRegistered.HeaderText = "Date Registered";
            this.DateRegistered.Name = "DateRegistered";
            this.DateRegistered.ReadOnly = true;
            // 
            // DateComplete
            // 
            this.DateComplete.HeaderText = "Date Complete";
            this.DateComplete.Name = "DateComplete";
            this.DateComplete.ReadOnly = true;
            // 
            // LabTestID
            // 
            this.LabTestID.HeaderText = "Lab Test ID";
            this.LabTestID.Name = "LabTestID";
            this.LabTestID.ReadOnly = true;
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
            // ProcedureName
            // 
            this.ProcedureName.HeaderText = "Procedure Name";
            this.ProcedureName.Name = "ProcedureName";
            this.ProcedureName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // FormLabTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.buttonEditTest);
            this.Controls.Add(this.labelReceptionistName);
            this.Controls.Add(this.labelLoggedInAs);
            this.Controls.Add(this.buttonViewAllForToday);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.buttonBeginTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLabTechnician";
            this.Text = "FormLabTechnician";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBeginTest;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLabTestID;
        private System.Windows.Forms.Label labelLabTestID;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonViewAllForToday;
        private System.Windows.Forms.Label labelLoggedInAs;
        private System.Windows.Forms.Label labelReceptionistName;
        private System.Windows.Forms.Button buttonEditTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRegistered;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateComplete;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcedureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}