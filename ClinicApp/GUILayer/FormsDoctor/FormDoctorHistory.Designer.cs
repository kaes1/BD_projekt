﻿namespace GUILayer.FormsDoctor
{
    partial class FormDoctorHistory
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
            this.groupBoxPreviousComments = new System.Windows.Forms.GroupBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.buttonManageExaminations = new System.Windows.Forms.Button();
            this.buttonPreviousExaminations = new System.Windows.Forms.Button();
            this.buttonBackToAppointment = new System.Windows.Forms.Button();
            this.buttonPreviousAppointments = new System.Windows.Forms.Button();
            this.labelResultDescription = new System.Windows.Forms.Label();
            this.buttonPreviousRegistry = new System.Windows.Forms.Button();
            this.buttonNextRegistry = new System.Windows.Forms.Button();
            this.richTextBoxResultDescription = new System.Windows.Forms.RichTextBox();
            this.dataGridViewAppoinmentsExaminations = new System.Windows.Forms.DataGridView();
            this.DateOfPreviousTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcedureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFisrtName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.groupBoxPreviousComments.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppoinmentsExaminations)).BeginInit();
            this.groupBoxPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPreviousComments
            // 
            this.groupBoxPreviousComments.Controls.Add(this.groupBoxControls);
            this.groupBoxPreviousComments.Controls.Add(this.labelResultDescription);
            this.groupBoxPreviousComments.Controls.Add(this.buttonPreviousRegistry);
            this.groupBoxPreviousComments.Controls.Add(this.buttonNextRegistry);
            this.groupBoxPreviousComments.Controls.Add(this.richTextBoxResultDescription);
            this.groupBoxPreviousComments.Controls.Add(this.dataGridViewAppoinmentsExaminations);
            this.groupBoxPreviousComments.Location = new System.Drawing.Point(12, 96);
            this.groupBoxPreviousComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPreviousComments.Name = "groupBoxPreviousComments";
            this.groupBoxPreviousComments.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPreviousComments.Size = new System.Drawing.Size(911, 561);
            this.groupBoxPreviousComments.TabIndex = 24;
            this.groupBoxPreviousComments.TabStop = false;
            this.groupBoxPreviousComments.Text = "Previous Appointments";
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonManageExaminations);
            this.groupBoxControls.Controls.Add(this.buttonPreviousExaminations);
            this.groupBoxControls.Controls.Add(this.buttonBackToAppointment);
            this.groupBoxControls.Controls.Add(this.buttonPreviousAppointments);
            this.groupBoxControls.Location = new System.Drawing.Point(610, 21);
            this.groupBoxControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxControls.Size = new System.Drawing.Size(196, 226);
            this.groupBoxControls.TabIndex = 28;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Menu";
            // 
            // buttonManageExaminations
            // 
            this.buttonManageExaminations.Location = new System.Drawing.Point(6, 70);
            this.buttonManageExaminations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonManageExaminations.Name = "buttonManageExaminations";
            this.buttonManageExaminations.Size = new System.Drawing.Size(184, 41);
            this.buttonManageExaminations.TabIndex = 29;
            this.buttonManageExaminations.Text = "Manage examinations";
            this.buttonManageExaminations.UseVisualStyleBackColor = true;
            this.buttonManageExaminations.Click += new System.EventHandler(this.buttonManageExaminations_Click);
            // 
            // buttonPreviousExaminations
            // 
            this.buttonPreviousExaminations.Location = new System.Drawing.Point(6, 170);
            this.buttonPreviousExaminations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousExaminations.Name = "buttonPreviousExaminations";
            this.buttonPreviousExaminations.Size = new System.Drawing.Size(184, 41);
            this.buttonPreviousExaminations.TabIndex = 28;
            this.buttonPreviousExaminations.Text = "Previous examinations";
            this.buttonPreviousExaminations.UseVisualStyleBackColor = true;
            // 
            // buttonBackToAppointment
            // 
            this.buttonBackToAppointment.Location = new System.Drawing.Point(6, 20);
            this.buttonBackToAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBackToAppointment.Name = "buttonBackToAppointment";
            this.buttonBackToAppointment.Size = new System.Drawing.Size(184, 41);
            this.buttonBackToAppointment.TabIndex = 1;
            this.buttonBackToAppointment.Text = "Back to appointment";
            this.buttonBackToAppointment.UseVisualStyleBackColor = true;
            this.buttonBackToAppointment.Click += new System.EventHandler(this.buttonBackToAppointment_Click);
            // 
            // buttonPreviousAppointments
            // 
            this.buttonPreviousAppointments.Location = new System.Drawing.Point(6, 120);
            this.buttonPreviousAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousAppointments.Name = "buttonPreviousAppointments";
            this.buttonPreviousAppointments.Size = new System.Drawing.Size(184, 41);
            this.buttonPreviousAppointments.TabIndex = 27;
            this.buttonPreviousAppointments.Text = "Previous appointments";
            this.buttonPreviousAppointments.UseVisualStyleBackColor = true;
            // 
            // labelResultDescription
            // 
            this.labelResultDescription.AutoSize = true;
            this.labelResultDescription.Location = new System.Drawing.Point(509, 261);
            this.labelResultDescription.Name = "labelResultDescription";
            this.labelResultDescription.Size = new System.Drawing.Size(48, 17);
            this.labelResultDescription.TabIndex = 12;
            this.labelResultDescription.Text = "Result";
            // 
            // buttonPreviousRegistry
            // 
            this.buttonPreviousRegistry.Location = new System.Drawing.Point(548, 508);
            this.buttonPreviousRegistry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousRegistry.Name = "buttonPreviousRegistry";
            this.buttonPreviousRegistry.Size = new System.Drawing.Size(139, 45);
            this.buttonPreviousRegistry.TabIndex = 0;
            this.buttonPreviousRegistry.Text = "Previous test";
            this.buttonPreviousRegistry.UseVisualStyleBackColor = true;
            // 
            // buttonNextRegistry
            // 
            this.buttonNextRegistry.Location = new System.Drawing.Point(712, 508);
            this.buttonNextRegistry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextRegistry.Name = "buttonNextRegistry";
            this.buttonNextRegistry.Size = new System.Drawing.Size(139, 45);
            this.buttonNextRegistry.TabIndex = 6;
            this.buttonNextRegistry.Text = "Next test";
            this.buttonNextRegistry.UseVisualStyleBackColor = true;
            // 
            // richTextBoxResultDescription
            // 
            this.richTextBoxResultDescription.Location = new System.Drawing.Point(512, 285);
            this.richTextBoxResultDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxResultDescription.Name = "richTextBoxResultDescription";
            this.richTextBoxResultDescription.ReadOnly = true;
            this.richTextBoxResultDescription.Size = new System.Drawing.Size(377, 214);
            this.richTextBoxResultDescription.TabIndex = 11;
            this.richTextBoxResultDescription.Text = "Pacjent skarży się na bóle głowe.\nWykonano badania fizykalne. Zlecono badanie krw" +
    "i.";
            // 
            // dataGridViewAppoinmentsExaminations
            // 
            this.dataGridViewAppoinmentsExaminations.AllowUserToAddRows = false;
            this.dataGridViewAppoinmentsExaminations.AllowUserToDeleteRows = false;
            this.dataGridViewAppoinmentsExaminations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppoinmentsExaminations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateOfPreviousTest,
            this.ProcedureName,
            this.Status});
            this.dataGridViewAppoinmentsExaminations.Location = new System.Drawing.Point(17, 21);
            this.dataGridViewAppoinmentsExaminations.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewAppoinmentsExaminations.Name = "dataGridViewAppoinmentsExaminations";
            this.dataGridViewAppoinmentsExaminations.ReadOnly = true;
            this.dataGridViewAppoinmentsExaminations.Size = new System.Drawing.Size(463, 520);
            this.dataGridViewAppoinmentsExaminations.TabIndex = 10;
            // 
            // DateOfPreviousTest
            // 
            this.DateOfPreviousTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfPreviousTest.HeaderText = "Date of test";
            this.DateOfPreviousTest.Name = "DateOfPreviousTest";
            this.DateOfPreviousTest.ReadOnly = true;
            // 
            // ProcedureName
            // 
            this.ProcedureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProcedureName.HeaderText = "Procedute name";
            this.ProcedureName.Name = "ProcedureName";
            this.ProcedureName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.labelAge);
            this.groupBoxPatient.Controls.Add(this.textBoxAge);
            this.groupBoxPatient.Controls.Add(this.textBoxLastName);
            this.groupBoxPatient.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatient.Controls.Add(this.labelFisrtName);
            this.groupBoxPatient.Controls.Add(this.labelLastName);
            this.groupBoxPatient.Location = new System.Drawing.Point(12, 11);
            this.groupBoxPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPatient.Size = new System.Drawing.Size(435, 81);
            this.groupBoxPatient.TabIndex = 25;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(287, 26);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(33, 17);
            this.labelAge.TabIndex = 7;
            this.labelAge.Text = "Age";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(290, 46);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ReadOnly = true;
            this.textBoxAge.Size = new System.Drawing.Size(133, 22);
            this.textBoxAge.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(151, 46);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(133, 22);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(9, 46);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(136, 22);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // labelFisrtName
            // 
            this.labelFisrtName.AutoSize = true;
            this.labelFisrtName.Location = new System.Drawing.Point(5, 26);
            this.labelFisrtName.Name = "labelFisrtName";
            this.labelFisrtName.Size = new System.Drawing.Size(76, 17);
            this.labelFisrtName.TabIndex = 4;
            this.labelFisrtName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(148, 26);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 17);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name";
            // 
            // FormDoctorHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 667);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.groupBoxPreviousComments);
            this.Name = "FormDoctorHistory";
            this.Text = "FormDoctorPrevExaminations";
            this.groupBoxPreviousComments.ResumeLayout(false);
            this.groupBoxPreviousComments.PerformLayout();
            this.groupBoxControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppoinmentsExaminations)).EndInit();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPreviousComments;
        private System.Windows.Forms.Label labelResultDescription;
        private System.Windows.Forms.Button buttonPreviousRegistry;
        private System.Windows.Forms.Button buttonNextRegistry;
        private System.Windows.Forms.RichTextBox richTextBoxResultDescription;
        private System.Windows.Forms.DataGridView dataGridViewAppoinmentsExaminations;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPreviousTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcedureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonPreviousAppointments;
        private System.Windows.Forms.Button buttonBackToAppointment;
        private System.Windows.Forms.Button buttonManageExaminations;
        private System.Windows.Forms.Button buttonPreviousExaminations;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFisrtName;
        private System.Windows.Forms.Label labelLastName;
    }
}