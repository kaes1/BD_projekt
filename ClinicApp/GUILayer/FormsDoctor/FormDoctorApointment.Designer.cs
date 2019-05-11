namespace GUILayer
{
    partial class FormDoctorAppointment
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
            this.buttonBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonBack.Location = new System.Drawing.Point(4, 97);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(138, 33);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonCancelAppointment
            // 
            this.buttonCancelAppointment.Enabled = false;
            this.buttonCancelAppointment.Location = new System.Drawing.Point(4, 57);
            this.buttonCancelAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelAppointment.Name = "buttonCancelAppointment";
            this.buttonCancelAppointment.Size = new System.Drawing.Size(138, 33);
            this.buttonCancelAppointment.TabIndex = 2;
            this.buttonCancelAppointment.Text = "Cancel ";
            this.buttonCancelAppointment.UseVisualStyleBackColor = true;
            this.buttonCancelAppointment.Click += new System.EventHandler(this.buttonCancelAppointment_Click);
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
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Enabled = false;
            this.richTextBoxDescription.Location = new System.Drawing.Point(16, 165);
            this.richTextBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(284, 243);
            this.richTextBoxDescription.TabIndex = 7;
            this.richTextBoxDescription.Text = "";
            this.richTextBoxDescription.TextChanged += new System.EventHandler(this.richTextBoxDescription_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(14, 149);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "Description";
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
            this.groupBoxPatient.Size = new System.Drawing.Size(224, 66);
            this.groupBoxPatient.TabIndex = 19;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Enabled = false;
            this.textBoxLastName.Location = new System.Drawing.Point(113, 37);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(101, 20);
            this.textBoxLastName.TabIndex = 9;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Enabled = false;
            this.textBoxFirstName.Location = new System.Drawing.Point(7, 37);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(103, 20);
            this.textBoxFirstName.TabIndex = 8;
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.buttonManageExaminations);
            this.groupBoxMenu.Controls.Add(this.buttonPatientHistory);
            this.groupBoxMenu.Controls.Add(this.buttonBeginAppointment);
            this.groupBoxMenu.Controls.Add(this.buttonBack);
            this.groupBoxMenu.Controls.Add(this.buttonCancelAppointment);
            this.groupBoxMenu.Location = new System.Drawing.Point(327, 149);
            this.groupBoxMenu.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMenu.Size = new System.Drawing.Size(147, 223);
            this.groupBoxMenu.TabIndex = 20;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Menu";
            // 
            // buttonManageExaminations
            // 
            this.buttonManageExaminations.Enabled = false;
            this.buttonManageExaminations.Location = new System.Drawing.Point(4, 178);
            this.buttonManageExaminations.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManageExaminations.Name = "buttonManageExaminations";
            this.buttonManageExaminations.Size = new System.Drawing.Size(138, 33);
            this.buttonManageExaminations.TabIndex = 5;
            this.buttonManageExaminations.Text = "Manage examinations";
            this.buttonManageExaminations.UseVisualStyleBackColor = true;
            this.buttonManageExaminations.Click += new System.EventHandler(this.buttonManageExaminations_Click);
            // 
            // buttonPatientHistory
            // 
            this.buttonPatientHistory.Location = new System.Drawing.Point(4, 137);
            this.buttonPatientHistory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPatientHistory.Name = "buttonPatientHistory";
            this.buttonPatientHistory.Size = new System.Drawing.Size(138, 33);
            this.buttonPatientHistory.TabIndex = 4;
            this.buttonPatientHistory.Text = "Patient history";
            this.buttonPatientHistory.UseVisualStyleBackColor = true;
            this.buttonPatientHistory.Click += new System.EventHandler(this.buttonPatientHistory_Click);
            // 
            // buttonBeginAppointment
            // 
            this.buttonBeginAppointment.Location = new System.Drawing.Point(4, 15);
            this.buttonBeginAppointment.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBeginAppointment.Name = "buttonBeginAppointment";
            this.buttonBeginAppointment.Size = new System.Drawing.Size(138, 34);
            this.buttonBeginAppointment.TabIndex = 1;
            this.buttonBeginAppointment.Text = "Begin appointment";
            this.buttonBeginAppointment.UseVisualStyleBackColor = true;
            this.buttonBeginAppointment.Click += new System.EventHandler(this.buttonBeginAppointment_Click);
            // 
            // labelDiagnosis
            // 
            this.labelDiagnosis.AutoSize = true;
            this.labelDiagnosis.Location = new System.Drawing.Point(16, 87);
            this.labelDiagnosis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDiagnosis.Name = "labelDiagnosis";
            this.labelDiagnosis.Size = new System.Drawing.Size(53, 13);
            this.labelDiagnosis.TabIndex = 25;
            this.labelDiagnosis.Text = "Diagnosis";
            // 
            // richTextBoxDiagnosis
            // 
            this.richTextBoxDiagnosis.Enabled = false;
            this.richTextBoxDiagnosis.Location = new System.Drawing.Point(16, 102);
            this.richTextBoxDiagnosis.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxDiagnosis.Name = "richTextBoxDiagnosis";
            this.richTextBoxDiagnosis.Size = new System.Drawing.Size(139, 34);
            this.richTextBoxDiagnosis.TabIndex = 6;
            this.richTextBoxDiagnosis.Text = "";
            this.richTextBoxDiagnosis.TextChanged += new System.EventHandler(this.richTextBoxDiagnosis_TextChanged);
            // 
            // FormDoctorAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonBack;
            this.ClientSize = new System.Drawing.Size(500, 425);
            this.Controls.Add(this.labelDiagnosis);
            this.Controls.Add(this.richTextBoxDiagnosis);
            this.Controls.Add(this.groupBoxMenu);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxDescription);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormDoctorAppointment";
            this.Text = "FormDoctorVisit";
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.groupBoxMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
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