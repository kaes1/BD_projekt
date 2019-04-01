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
            this.richTextBoxNewDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.dataGridViewExaminationsList = new System.Windows.Forms.DataGridView();
            this.buttonAddLabTest = new System.Windows.Forms.Button();
            this.groupBoxLabTestsList = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.groupBoxPhysicalExaminations = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.buttonAddPhysExamination = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelDiagnosis = new System.Windows.Forms.Label();
            this.richTextBoxDiagnosis = new System.Windows.Forms.RichTextBox();
            this.buttonBeginAppointment = new System.Windows.Forms.Button();
            this.PhysicalExamination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPreviousAppointments = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExaminationsList)).BeginInit();
            this.groupBoxLabTestsList.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.groupBoxPhysicalExaminations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(6, 118);
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
            this.buttonEndAppointment.Location = new System.Drawing.Point(669, 295);
            this.buttonEndAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEndAppointment.Name = "buttonEndAppointment";
            this.buttonEndAppointment.Size = new System.Drawing.Size(184, 42);
            this.buttonEndAppointment.TabIndex = 2;
            this.buttonEndAppointment.Text = "End ";
            this.buttonEndAppointment.UseVisualStyleBackColor = true;
            // 
            // buttonCancelAppointment
            // 
            this.buttonCancelAppointment.Location = new System.Drawing.Point(6, 70);
            this.buttonCancelAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelAppointment.Name = "buttonCancelAppointment";
            this.buttonCancelAppointment.Size = new System.Drawing.Size(184, 41);
            this.buttonCancelAppointment.TabIndex = 3;
            this.buttonCancelAppointment.Text = "Cancel ";
            this.buttonCancelAppointment.UseVisualStyleBackColor = true;
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
            // richTextBoxNewDescription
            // 
            this.richTextBoxNewDescription.Location = new System.Drawing.Point(464, 444);
            this.richTextBoxNewDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxNewDescription.Name = "richTextBoxNewDescription";
            this.richTextBoxNewDescription.Size = new System.Drawing.Size(377, 298);
            this.richTextBoxNewDescription.TabIndex = 14;
            this.richTextBoxNewDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(461, 424);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(79, 17);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "Description";
            // 
            // dataGridViewExaminationsList
            // 
            this.dataGridViewExaminationsList.AllowUserToAddRows = false;
            this.dataGridViewExaminationsList.AllowUserToDeleteRows = false;
            this.dataGridViewExaminationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExaminationsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LabTest});
            this.dataGridViewExaminationsList.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewExaminationsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewExaminationsList.Name = "dataGridViewExaminationsList";
            this.dataGridViewExaminationsList.ReadOnly = true;
            this.dataGridViewExaminationsList.Size = new System.Drawing.Size(189, 289);
            this.dataGridViewExaminationsList.TabIndex = 16;
            // 
            // buttonAddLabTest
            // 
            this.buttonAddLabTest.Location = new System.Drawing.Point(224, 265);
            this.buttonAddLabTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddLabTest.Name = "buttonAddLabTest";
            this.buttonAddLabTest.Size = new System.Drawing.Size(177, 41);
            this.buttonAddLabTest.TabIndex = 17;
            this.buttonAddLabTest.Text = "Add Test";
            this.buttonAddLabTest.UseVisualStyleBackColor = true;
            this.buttonAddLabTest.Click += new System.EventHandler(this.buttonAddLabTest_Click);
            // 
            // groupBoxLabTestsList
            // 
            this.groupBoxLabTestsList.Controls.Add(this.label3);
            this.groupBoxLabTestsList.Controls.Add(this.richTextBox3);
            this.groupBoxLabTestsList.Controls.Add(this.buttonAddLabTest);
            this.groupBoxLabTestsList.Controls.Add(this.dataGridViewExaminationsList);
            this.groupBoxLabTestsList.Location = new System.Drawing.Point(17, 424);
            this.groupBoxLabTestsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLabTestsList.Name = "groupBoxLabTestsList";
            this.groupBoxLabTestsList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLabTestsList.Size = new System.Drawing.Size(430, 318);
            this.groupBoxLabTestsList.TabIndex = 18;
            this.groupBoxLabTestsList.TabStop = false;
            this.groupBoxLabTestsList.Text = "Today\'s laboratory tests";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Comment to laboratory";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(203, 41);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(216, 216);
            this.richTextBox3.TabIndex = 21;
            this.richTextBox3.Text = "";
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
            this.groupBoxPatient.TabIndex = 19;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
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
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonBeginAppointment);
            this.groupBoxControls.Controls.Add(this.buttonBack);
            this.groupBoxControls.Controls.Add(this.buttonCancelAppointment);
            this.groupBoxControls.Location = new System.Drawing.Point(564, 57);
            this.groupBoxControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxControls.Size = new System.Drawing.Size(196, 175);
            this.groupBoxControls.TabIndex = 20;
            this.groupBoxControls.TabStop = false;
            // 
            // groupBoxPhysicalExaminations
            // 
            this.groupBoxPhysicalExaminations.Controls.Add(this.label2);
            this.groupBoxPhysicalExaminations.Controls.Add(this.richTextBox2);
            this.groupBoxPhysicalExaminations.Controls.Add(this.buttonAddPhysExamination);
            this.groupBoxPhysicalExaminations.Controls.Add(this.dataGridView2);
            this.groupBoxPhysicalExaminations.Location = new System.Drawing.Point(12, 96);
            this.groupBoxPhysicalExaminations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPhysicalExaminations.Name = "groupBoxPhysicalExaminations";
            this.groupBoxPhysicalExaminations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPhysicalExaminations.Size = new System.Drawing.Size(435, 323);
            this.groupBoxPhysicalExaminations.TabIndex = 23;
            this.groupBoxPhysicalExaminations.TabStop = false;
            this.groupBoxPhysicalExaminations.Text = "Today\'s physical examinations";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Result";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(208, 37);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(215, 216);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "";
            // 
            // buttonAddPhysExamination
            // 
            this.buttonAddPhysExamination.Location = new System.Drawing.Point(229, 262);
            this.buttonAddPhysExamination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPhysExamination.Name = "buttonAddPhysExamination";
            this.buttonAddPhysExamination.Size = new System.Drawing.Size(177, 41);
            this.buttonAddPhysExamination.TabIndex = 17;
            this.buttonAddPhysExamination.Text = "Add Examination";
            this.buttonAddPhysExamination.UseVisualStyleBackColor = true;
            this.buttonAddPhysExamination.Click += new System.EventHandler(this.buttonAddPhysExamination_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhysicalExamination});
            this.dataGridView2.Location = new System.Drawing.Point(7, 22);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(194, 289);
            this.dataGridView2.TabIndex = 16;
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
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(287, 26);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(33, 17);
            this.labelAge.TabIndex = 7;
            this.labelAge.Text = "Age";
            // 
            // labelDiagnosis
            // 
            this.labelDiagnosis.AutoSize = true;
            this.labelDiagnosis.Location = new System.Drawing.Point(669, 345);
            this.labelDiagnosis.Name = "labelDiagnosis";
            this.labelDiagnosis.Size = new System.Drawing.Size(70, 17);
            this.labelDiagnosis.TabIndex = 25;
            this.labelDiagnosis.Text = "Diagnosis";
            // 
            // richTextBoxDiagnosis
            // 
            this.richTextBoxDiagnosis.Location = new System.Drawing.Point(669, 364);
            this.richTextBoxDiagnosis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxDiagnosis.Name = "richTextBoxDiagnosis";
            this.richTextBoxDiagnosis.Size = new System.Drawing.Size(184, 41);
            this.richTextBoxDiagnosis.TabIndex = 24;
            this.richTextBoxDiagnosis.Text = "";
            // 
            // buttonBeginAppointment
            // 
            this.buttonBeginAppointment.Location = new System.Drawing.Point(6, 19);
            this.buttonBeginAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBeginAppointment.Name = "buttonBeginAppointment";
            this.buttonBeginAppointment.Size = new System.Drawing.Size(184, 42);
            this.buttonBeginAppointment.TabIndex = 26;
            this.buttonBeginAppointment.Text = "Begin";
            this.buttonBeginAppointment.UseVisualStyleBackColor = true;
            // 
            // PhysicalExamination
            // 
            this.PhysicalExamination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PhysicalExamination.HeaderText = "Physical examination";
            this.PhysicalExamination.Name = "PhysicalExamination";
            this.PhysicalExamination.ReadOnly = true;
            // 
            // LabTest
            // 
            this.LabTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LabTest.HeaderText = "Lab test";
            this.LabTest.Name = "LabTest";
            this.LabTest.ReadOnly = true;
            // 
            // buttonPreviousAppointments
            // 
            this.buttonPreviousAppointments.Location = new System.Drawing.Point(6, 19);
            this.buttonPreviousAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousAppointments.Name = "buttonPreviousAppointments";
            this.buttonPreviousAppointments.Size = new System.Drawing.Size(184, 41);
            this.buttonPreviousAppointments.TabIndex = 26;
            this.buttonPreviousAppointments.Text = "Previous appointments";
            this.buttonPreviousAppointments.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 41);
            this.button1.TabIndex = 27;
            this.button1.Text = "Previous examinations";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPreviousAppointments);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(467, 277);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(196, 142);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // FormDoctorVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 761);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelDiagnosis);
            this.Controls.Add(this.buttonEndAppointment);
            this.Controls.Add(this.richTextBoxDiagnosis);
            this.Controls.Add(this.groupBoxPhysicalExaminations);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.groupBoxLabTestsList);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxNewDescription);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDoctorVisit";
            this.Text = "FormDoctorVisit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExaminationsList)).EndInit();
            this.groupBoxLabTestsList.ResumeLayout(false);
            this.groupBoxLabTestsList.PerformLayout();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxPhysicalExaminations.ResumeLayout(false);
            this.groupBoxPhysicalExaminations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEndAppointment;
        private System.Windows.Forms.Button buttonCancelAppointment;
        private System.Windows.Forms.Label labelFisrtName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.RichTextBox richTextBoxNewDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.DataGridView dataGridViewExaminationsList;
        private System.Windows.Forms.Button buttonAddLabTest;
        private System.Windows.Forms.GroupBox groupBoxLabTestsList;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.GroupBox groupBoxPhysicalExaminations;
        private System.Windows.Forms.Button buttonAddPhysExamination;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonBeginAppointment;
        private System.Windows.Forms.Label labelDiagnosis;
        private System.Windows.Forms.RichTextBox richTextBoxDiagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhysicalExamination;
        private System.Windows.Forms.Button buttonPreviousAppointments;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}