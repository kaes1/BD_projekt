namespace GUILayer
{
    partial class FormLabManager
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxManagerComments = new System.Windows.Forms.TextBox();
            this.labelManagerComments = new System.Windows.Forms.Label();
            this.textBoxDoctorComments = new System.Windows.Forms.TextBox();
            this.labelDoctorComments = new System.Windows.Forms.Label();
            this.buttonApproveLabTest = new System.Windows.Forms.Button();
            this.textBoxLabTestResult = new System.Windows.Forms.TextBox();
            this.labelLabTestResult = new System.Windows.Forms.Label();
            this.LabTestID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRegistered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCompleted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddComments = new System.Windows.Forms.Button();
            this.buttonCancelLabTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(206, 8);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(390, 48);
            this.labelPanelName.TabIndex = 1;
            this.labelPanelName.Text = "Lab Manager Panel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LabTestID,
            this.DateRegistered,
            this.DateCompleted,
            this.PatientFirstName,
            this.PatientLastName,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(563, 191);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBoxManagerComments
            // 
            this.textBoxManagerComments.Location = new System.Drawing.Point(512, 311);
            this.textBoxManagerComments.Multiline = true;
            this.textBoxManagerComments.Name = "textBoxManagerComments";
            this.textBoxManagerComments.Size = new System.Drawing.Size(220, 98);
            this.textBoxManagerComments.TabIndex = 3;
            // 
            // labelManagerComments
            // 
            this.labelManagerComments.AutoSize = true;
            this.labelManagerComments.Location = new System.Drawing.Point(509, 295);
            this.labelManagerComments.Name = "labelManagerComments";
            this.labelManagerComments.Size = new System.Drawing.Size(122, 13);
            this.labelManagerComments.TabIndex = 4;
            this.labelManagerComments.Text = "Lab Manager Comments";
            // 
            // textBoxDoctorComments
            // 
            this.textBoxDoctorComments.Location = new System.Drawing.Point(263, 311);
            this.textBoxDoctorComments.Multiline = true;
            this.textBoxDoctorComments.Name = "textBoxDoctorComments";
            this.textBoxDoctorComments.ReadOnly = true;
            this.textBoxDoctorComments.Size = new System.Drawing.Size(220, 98);
            this.textBoxDoctorComments.TabIndex = 5;
            // 
            // labelDoctorComments
            // 
            this.labelDoctorComments.AutoSize = true;
            this.labelDoctorComments.Location = new System.Drawing.Point(260, 295);
            this.labelDoctorComments.Name = "labelDoctorComments";
            this.labelDoctorComments.Size = new System.Drawing.Size(91, 13);
            this.labelDoctorComments.TabIndex = 6;
            this.labelDoctorComments.Text = "Doctor Comments";
            // 
            // buttonApproveLabTest
            // 
            this.buttonApproveLabTest.Location = new System.Drawing.Point(608, 115);
            this.buttonApproveLabTest.Name = "buttonApproveLabTest";
            this.buttonApproveLabTest.Size = new System.Drawing.Size(110, 23);
            this.buttonApproveLabTest.TabIndex = 7;
            this.buttonApproveLabTest.Text = "Approve Lab Test";
            this.buttonApproveLabTest.UseVisualStyleBackColor = true;
            // 
            // textBoxLabTestResult
            // 
            this.textBoxLabTestResult.Location = new System.Drawing.Point(15, 311);
            this.textBoxLabTestResult.Multiline = true;
            this.textBoxLabTestResult.Name = "textBoxLabTestResult";
            this.textBoxLabTestResult.ReadOnly = true;
            this.textBoxLabTestResult.Size = new System.Drawing.Size(220, 98);
            this.textBoxLabTestResult.TabIndex = 8;
            // 
            // labelLabTestResult
            // 
            this.labelLabTestResult.AutoSize = true;
            this.labelLabTestResult.Location = new System.Drawing.Point(12, 295);
            this.labelLabTestResult.Name = "labelLabTestResult";
            this.labelLabTestResult.Size = new System.Drawing.Size(82, 13);
            this.labelLabTestResult.TabIndex = 9;
            this.labelLabTestResult.Text = "Lab Test Result";
            // 
            // LabTestID
            // 
            this.LabTestID.HeaderText = "LabTestID";
            this.LabTestID.Name = "LabTestID";
            this.LabTestID.ReadOnly = true;
            this.LabTestID.Width = 70;
            // 
            // DateRegistered
            // 
            this.DateRegistered.HeaderText = "DateRegistered";
            this.DateRegistered.Name = "DateRegistered";
            this.DateRegistered.ReadOnly = true;
            this.DateRegistered.Width = 90;
            // 
            // DateCompleted
            // 
            this.DateCompleted.HeaderText = "DateCompleted";
            this.DateCompleted.Name = "DateCompleted";
            this.DateCompleted.ReadOnly = true;
            this.DateCompleted.Width = 90;
            // 
            // PatientFirstName
            // 
            this.PatientFirstName.HeaderText = "PatientFirstName";
            this.PatientFirstName.Name = "PatientFirstName";
            this.PatientFirstName.ReadOnly = true;
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
            // buttonAddComments
            // 
            this.buttonAddComments.Location = new System.Drawing.Point(608, 227);
            this.buttonAddComments.Name = "buttonAddComments";
            this.buttonAddComments.Size = new System.Drawing.Size(110, 23);
            this.buttonAddComments.TabIndex = 10;
            this.buttonAddComments.Text = "Add Comments";
            this.buttonAddComments.UseVisualStyleBackColor = true;
            // 
            // buttonCancelLabTest
            // 
            this.buttonCancelLabTest.Location = new System.Drawing.Point(608, 171);
            this.buttonCancelLabTest.Name = "buttonCancelLabTest";
            this.buttonCancelLabTest.Size = new System.Drawing.Size(110, 23);
            this.buttonCancelLabTest.TabIndex = 11;
            this.buttonCancelLabTest.Text = "Cancel Lab Test";
            this.buttonCancelLabTest.UseVisualStyleBackColor = true;
            // 
            // FormLabManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 424);
            this.Controls.Add(this.buttonCancelLabTest);
            this.Controls.Add(this.buttonAddComments);
            this.Controls.Add(this.labelLabTestResult);
            this.Controls.Add(this.textBoxLabTestResult);
            this.Controls.Add(this.buttonApproveLabTest);
            this.Controls.Add(this.labelDoctorComments);
            this.Controls.Add(this.textBoxDoctorComments);
            this.Controls.Add(this.labelManagerComments);
            this.Controls.Add(this.textBoxManagerComments);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelPanelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormLabManager";
            this.Text = "FormLabManager";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxManagerComments;
        private System.Windows.Forms.Label labelManagerComments;
        private System.Windows.Forms.TextBox textBoxDoctorComments;
        private System.Windows.Forms.Label labelDoctorComments;
        private System.Windows.Forms.Button buttonApproveLabTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTestID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRegistered;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCompleted;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TextBox textBoxLabTestResult;
        private System.Windows.Forms.Label labelLabTestResult;
        private System.Windows.Forms.Button buttonAddComments;
        private System.Windows.Forms.Button buttonCancelLabTest;
    }
}