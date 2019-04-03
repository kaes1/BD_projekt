namespace GUILayer
{
    partial class FormDoctorVisit
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEndAppointment = new System.Windows.Forms.Button();
            this.buttonCancelAppointment = new System.Windows.Forms.Button();
            this.labelFisrtName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.buttonManageExaminations = new System.Windows.Forms.Button();
            this.buttonPatientHistory = new System.Windows.Forms.Button();
            this.buttonBeginAppointment = new System.Windows.Forms.Button();
            this.labelDiagnosis = new System.Windows.Forms.Label();
            this.richTextBoxDiagnosis = new System.Windows.Forms.RichTextBox();
            this.groupBoxPatient.SuspendLayout();
            this.groupBoxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(6, 170);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(184, 41);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEndAppointment
            // 
            this.buttonEndAppointment.Enabled = false;
            this.buttonEndAppointment.Location = new System.Drawing.Point(6, 70);
            this.buttonEndAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEndAppointment.Name = "buttonEndAppointment";
            this.buttonEndAppointment.Size = new System.Drawing.Size(184, 42);
            this.buttonEndAppointment.TabIndex = 2;
            this.buttonEndAppointment.Text = "End ";
            this.buttonEndAppointment.UseVisualStyleBackColor = true;
            this.buttonEndAppointment.Click += new System.EventHandler(this.buttonEndAppointment_Click);
            // 
            // buttonCancelAppointment
            // 
            this.buttonCancelAppointment.Enabled = false;
            this.buttonCancelAppointment.Location = new System.Drawing.Point(6, 121);
            this.buttonCancelAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelAppointment.Name = "buttonCancelAppointment";
            this.buttonCancelAppointment.Size = new System.Drawing.Size(184, 41);
            this.buttonCancelAppointment.TabIndex = 3;
            this.buttonCancelAppointment.Text = "Cancel ";
            this.buttonCancelAppointment.UseVisualStyleBackColor = true;
            this.buttonCancelAppointment.Click += new System.EventHandler(this.buttonCancelAppointment_Click);
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
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Enabled = false;
            this.richTextBoxDescription.Location = new System.Drawing.Point(21, 203);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(377, 298);
            this.richTextBoxDescription.TabIndex = 14;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(18, 183);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(79, 17);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "Description";
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.textBoxLastName);
            this.groupBoxPatient.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatient.Controls.Add(this.labelFisrtName);
            this.groupBoxPatient.Controls.Add(this.labelLastName);
            this.groupBoxPatient.Location = new System.Drawing.Point(12, 11);
            this.groupBoxPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPatient.Size = new System.Drawing.Size(299, 81);
            this.groupBoxPatient.TabIndex = 19;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Location = new System.Drawing.Point(151, 46);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(133, 22);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Location = new System.Drawing.Point(9, 46);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(136, 22);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.buttonManageExaminations);
            this.groupBoxMenu.Controls.Add(this.buttonPatientHistory);
            this.groupBoxMenu.Controls.Add(this.buttonBeginAppointment);
            this.groupBoxMenu.Controls.Add(this.buttonBack);
            this.groupBoxMenu.Controls.Add(this.buttonEndAppointment);
            this.groupBoxMenu.Controls.Add(this.buttonCancelAppointment);
            this.groupBoxMenu.Location = new System.Drawing.Point(458, 175);
            this.groupBoxMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxMenu.Size = new System.Drawing.Size(196, 326);
            this.groupBoxMenu.TabIndex = 20;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // buttonManageExaminations
            // 
            this.buttonManageExaminations.Enabled = false;
            this.buttonManageExaminations.Location = new System.Drawing.Point(6, 270);
            this.buttonManageExaminations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonManageExaminations.Name = "buttonManageExaminations";
            this.buttonManageExaminations.Size = new System.Drawing.Size(184, 41);
            this.buttonManageExaminations.TabIndex = 28;
            this.buttonManageExaminations.Text = "Manage examinations";
            this.buttonManageExaminations.UseVisualStyleBackColor = true;
            this.buttonManageExaminations.Click += new System.EventHandler(this.buttonManageExaminations_Click);
            // 
            // buttonPatientHistory
            // 
            this.buttonPatientHistory.Enabled = false;
            this.buttonPatientHistory.Location = new System.Drawing.Point(6, 220);
            this.buttonPatientHistory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPatientHistory.Name = "buttonPatientHistory";
            this.buttonPatientHistory.Size = new System.Drawing.Size(184, 41);
            this.buttonPatientHistory.TabIndex = 27;
            this.buttonPatientHistory.Text = "Patient history";
            this.buttonPatientHistory.UseVisualStyleBackColor = true;
            this.buttonPatientHistory.Click += new System.EventHandler(this.buttonPatientHistory_Click);
            // 
            // buttonBeginAppointment
            // 
            this.buttonBeginAppointment.Location = new System.Drawing.Point(6, 19);
            this.buttonBeginAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBeginAppointment.Name = "buttonBeginAppointment";
            this.buttonBeginAppointment.Size = new System.Drawing.Size(184, 42);
            this.buttonBeginAppointment.TabIndex = 26;
            this.buttonBeginAppointment.Text = "Begin appointment";
            this.buttonBeginAppointment.UseVisualStyleBackColor = true;
            this.buttonBeginAppointment.Click += new System.EventHandler(this.buttonBeginAppointment_Click);
            // 
            // labelDiagnosis
            // 
            this.labelDiagnosis.AutoSize = true;
            this.labelDiagnosis.Location = new System.Drawing.Point(21, 107);
            this.labelDiagnosis.Name = "labelDiagnosis";
            this.labelDiagnosis.Size = new System.Drawing.Size(70, 17);
            this.labelDiagnosis.TabIndex = 25;
            this.labelDiagnosis.Text = "Diagnosis";
            // 
            // richTextBoxDiagnosis
            // 
            this.richTextBoxDiagnosis.Enabled = false;
            this.richTextBoxDiagnosis.Location = new System.Drawing.Point(21, 126);
            this.richTextBoxDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDiagnosis.Name = "richTextBoxDiagnosis";
            this.richTextBoxDiagnosis.Size = new System.Drawing.Size(184, 41);
            this.richTextBoxDiagnosis.TabIndex = 24;
            this.richTextBoxDiagnosis.Text = "";
            // 
            // FormDoctorVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 534);
            this.Controls.Add(this.labelDiagnosis);
            this.Controls.Add(this.richTextBoxDiagnosis);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDoctorVisit";
            this.Text = "FormDoctorVisit";
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.groupBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEndAppointment;
        private System.Windows.Forms.Button buttonCancelAppointment;
        private System.Windows.Forms.Label labelFisrtName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.Button buttonBeginAppointment;
        private System.Windows.Forms.Label labelDiagnosis;
        private System.Windows.Forms.RichTextBox richTextBoxDiagnosis;
        private System.Windows.Forms.Button buttonPatientHistory;
        private System.Windows.Forms.Button buttonManageExaminations;
    }
}