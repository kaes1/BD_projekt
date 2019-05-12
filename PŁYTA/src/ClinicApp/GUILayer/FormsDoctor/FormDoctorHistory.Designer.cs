namespace GUILayer.FormsDoctor
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
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.richTextBoxDiagnosis = new System.Windows.Forms.RichTextBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.buttonPreviousExaminations = new System.Windows.Forms.Button();
            this.buttonBackToAppointment = new System.Windows.Forms.Button();
            this.buttonPreviousAppointments = new System.Windows.Forms.Button();
            this.labelResultDiagnosis = new System.Windows.Forms.Label();
            this.richTextBoxExaminationResult = new System.Windows.Forms.RichTextBox();
            this.dataGridViewAppoinmentsExaminations = new System.Windows.Forms.DataGridView();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
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
            this.groupBoxPreviousComments.Controls.Add(this.labelDescription);
            this.groupBoxPreviousComments.Controls.Add(this.richTextBoxDescription);
            this.groupBoxPreviousComments.Controls.Add(this.richTextBoxDiagnosis);
            this.groupBoxPreviousComments.Controls.Add(this.groupBoxControls);
            this.groupBoxPreviousComments.Controls.Add(this.labelResultDiagnosis);
            this.groupBoxPreviousComments.Controls.Add(this.richTextBoxExaminationResult);
            this.groupBoxPreviousComments.Controls.Add(this.dataGridViewAppoinmentsExaminations);
            this.groupBoxPreviousComments.Location = new System.Drawing.Point(9, 78);
            this.groupBoxPreviousComments.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPreviousComments.Name = "groupBoxPreviousComments";
            this.groupBoxPreviousComments.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPreviousComments.Size = new System.Drawing.Size(698, 456);
            this.groupBoxPreviousComments.TabIndex = 24;
            this.groupBoxPreviousComments.TabStop = false;
            this.groupBoxPreviousComments.Text = "Previous Appointments";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(396, 258);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 31;
            this.labelDescription.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(399, 273);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.Size = new System.Drawing.Size(284, 168);
            this.richTextBoxDescription.TabIndex = 30;
            this.richTextBoxDescription.Text = "";
            // 
            // richTextBoxDiagnosis
            // 
            this.richTextBoxDiagnosis.Location = new System.Drawing.Point(399, 182);
            this.richTextBoxDiagnosis.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxDiagnosis.Name = "richTextBoxDiagnosis";
            this.richTextBoxDiagnosis.ReadOnly = true;
            this.richTextBoxDiagnosis.Size = new System.Drawing.Size(284, 66);
            this.richTextBoxDiagnosis.TabIndex = 29;
            this.richTextBoxDiagnosis.Text = "";
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonPreviousExaminations);
            this.groupBoxControls.Controls.Add(this.buttonBackToAppointment);
            this.groupBoxControls.Controls.Add(this.buttonPreviousAppointments);
            this.groupBoxControls.Location = new System.Drawing.Point(469, 17);
            this.groupBoxControls.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxControls.Size = new System.Drawing.Size(147, 141);
            this.groupBoxControls.TabIndex = 28;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Menu";
            // 
            // buttonPreviousExaminations
            // 
            this.buttonPreviousExaminations.Location = new System.Drawing.Point(4, 58);
            this.buttonPreviousExaminations.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPreviousExaminations.Name = "buttonPreviousExaminations";
            this.buttonPreviousExaminations.Size = new System.Drawing.Size(138, 33);
            this.buttonPreviousExaminations.TabIndex = 28;
            this.buttonPreviousExaminations.Text = "Examinations";
            this.buttonPreviousExaminations.UseVisualStyleBackColor = true;
            this.buttonPreviousExaminations.Click += new System.EventHandler(this.buttonPreviousExaminations_Click);
            // 
            // buttonBackToAppointment
            // 
            this.buttonBackToAppointment.Location = new System.Drawing.Point(4, 98);
            this.buttonBackToAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBackToAppointment.Name = "buttonBackToAppointment";
            this.buttonBackToAppointment.Size = new System.Drawing.Size(138, 33);
            this.buttonBackToAppointment.TabIndex = 1;
            this.buttonBackToAppointment.Text = "Back";
            this.buttonBackToAppointment.UseVisualStyleBackColor = true;
            this.buttonBackToAppointment.Click += new System.EventHandler(this.buttonBackToAppointment_Click);
            // 
            // buttonPreviousAppointments
            // 
            this.buttonPreviousAppointments.Location = new System.Drawing.Point(4, 17);
            this.buttonPreviousAppointments.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPreviousAppointments.Name = "buttonPreviousAppointments";
            this.buttonPreviousAppointments.Size = new System.Drawing.Size(138, 33);
            this.buttonPreviousAppointments.TabIndex = 27;
            this.buttonPreviousAppointments.Text = "Appointments";
            this.buttonPreviousAppointments.UseVisualStyleBackColor = true;
            this.buttonPreviousAppointments.Click += new System.EventHandler(this.buttonPreviousAppointments_Click);
            // 
            // labelResultDiagnosis
            // 
            this.labelResultDiagnosis.AutoSize = true;
            this.labelResultDiagnosis.Location = new System.Drawing.Point(396, 167);
            this.labelResultDiagnosis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResultDiagnosis.Name = "labelResultDiagnosis";
            this.labelResultDiagnosis.Size = new System.Drawing.Size(53, 13);
            this.labelResultDiagnosis.TabIndex = 12;
            this.labelResultDiagnosis.Text = "Diagnosis";
            // 
            // richTextBoxExaminationResult
            // 
            this.richTextBoxExaminationResult.Location = new System.Drawing.Point(399, 182);
            this.richTextBoxExaminationResult.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxExaminationResult.Name = "richTextBoxExaminationResult";
            this.richTextBoxExaminationResult.ReadOnly = true;
            this.richTextBoxExaminationResult.Size = new System.Drawing.Size(284, 259);
            this.richTextBoxExaminationResult.TabIndex = 11;
            this.richTextBoxExaminationResult.Text = "";
            this.richTextBoxExaminationResult.Visible = false;
            // 
            // dataGridViewAppoinmentsExaminations
            // 
            this.dataGridViewAppoinmentsExaminations.AllowUserToAddRows = false;
            this.dataGridViewAppoinmentsExaminations.AllowUserToDeleteRows = false;
            this.dataGridViewAppoinmentsExaminations.AllowUserToResizeColumns = false;
            this.dataGridViewAppoinmentsExaminations.AllowUserToResizeRows = false;
            this.dataGridViewAppoinmentsExaminations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppoinmentsExaminations.Location = new System.Drawing.Point(13, 17);
            this.dataGridViewAppoinmentsExaminations.MultiSelect = false;
            this.dataGridViewAppoinmentsExaminations.Name = "dataGridViewAppoinmentsExaminations";
            this.dataGridViewAppoinmentsExaminations.ReadOnly = true;
            this.dataGridViewAppoinmentsExaminations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAppoinmentsExaminations.Size = new System.Drawing.Size(370, 422);
            this.dataGridViewAppoinmentsExaminations.TabIndex = 10;
            this.dataGridViewAppoinmentsExaminations.SelectionChanged += new System.EventHandler(this.dataGridViewAppoinmentsExaminations_SelectionChanged);
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.textBoxLastName);
            this.groupBoxPatient.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatient.Controls.Add(this.labelFisrtName);
            this.groupBoxPatient.Controls.Add(this.labelLastName);
            this.groupBoxPatient.Location = new System.Drawing.Point(9, 9);
            this.groupBoxPatient.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPatient.Size = new System.Drawing.Size(221, 66);
            this.groupBoxPatient.TabIndex = 25;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(113, 37);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(101, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(7, 37);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(103, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // labelFisrtName
            // 
            this.labelFisrtName.AutoSize = true;
            this.labelFisrtName.Location = new System.Drawing.Point(4, 21);
            this.labelFisrtName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFisrtName.Name = "labelFisrtName";
            this.labelFisrtName.Size = new System.Drawing.Size(57, 13);
            this.labelFisrtName.TabIndex = 4;
            this.labelFisrtName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(111, 21);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name";
            // 
            // FormDoctorHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 542);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.groupBoxPreviousComments);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label labelResultDiagnosis;
        private System.Windows.Forms.RichTextBox richTextBoxExaminationResult;
        private System.Windows.Forms.DataGridView dataGridViewAppoinmentsExaminations;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonPreviousAppointments;
        private System.Windows.Forms.Button buttonBackToAppointment;
        private System.Windows.Forms.Button buttonPreviousExaminations;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFisrtName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.RichTextBox richTextBoxDiagnosis;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
    }
}