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
            this.buttonPreviousVisit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEndVisit = new System.Windows.Forms.Button();
            this.buttonCancelVisit = new System.Windows.Forms.Button();
            this.labelFisrtName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonNextVisit = new System.Windows.Forms.Button();
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBoxOldDescription = new System.Windows.Forms.RichTextBox();
            this.labelOldDescription = new System.Windows.Forms.Label();
            this.dataGridViewOldExaminations = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBoxNewDescription = new System.Windows.Forms.RichTextBox();
            this.labelNewDescription = new System.Windows.Forms.Label();
            this.dataGridViewExaminationsList = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddExamination = new System.Windows.Forms.Button();
            this.groupBoxExaminationsList = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonDeleteExamination = new System.Windows.Forms.Button();
            this.textBoxExamination = new System.Windows.Forms.TextBox();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOldExaminations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExaminationsList)).BeginInit();
            this.groupBoxExaminationsList.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPreviousVisit
            // 
            this.buttonPreviousVisit.Location = new System.Drawing.Point(184, 212);
            this.buttonPreviousVisit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPreviousVisit.Name = "buttonPreviousVisit";
            this.buttonPreviousVisit.Size = new System.Drawing.Size(86, 19);
            this.buttonPreviousVisit.TabIndex = 0;
            this.buttonPreviousVisit.Text = "Previous Visit";
            this.buttonPreviousVisit.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(557, 389);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(86, 19);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEndVisit
            // 
            this.buttonEndVisit.Location = new System.Drawing.Point(557, 315);
            this.buttonEndVisit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEndVisit.Name = "buttonEndVisit";
            this.buttonEndVisit.Size = new System.Drawing.Size(86, 19);
            this.buttonEndVisit.TabIndex = 2;
            this.buttonEndVisit.Text = "End Visit";
            this.buttonEndVisit.UseVisualStyleBackColor = true;
            // 
            // buttonCancelVisit
            // 
            this.buttonCancelVisit.Location = new System.Drawing.Point(557, 353);
            this.buttonCancelVisit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelVisit.Name = "buttonCancelVisit";
            this.buttonCancelVisit.Size = new System.Drawing.Size(86, 19);
            this.buttonCancelVisit.TabIndex = 3;
            this.buttonCancelVisit.Text = "Cancel Visit";
            this.buttonCancelVisit.UseVisualStyleBackColor = true;
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
            this.labelLastName.Location = new System.Drawing.Point(93, 21);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name";
            // 
            // buttonNextVisit
            // 
            this.buttonNextVisit.Location = new System.Drawing.Point(275, 212);
            this.buttonNextVisit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNextVisit.Name = "buttonNextVisit";
            this.buttonNextVisit.Size = new System.Drawing.Size(86, 19);
            this.buttonNextVisit.TabIndex = 6;
            this.buttonNextVisit.Text = "Next Visit";
            this.buttonNextVisit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.AllowUserToAddRows = false;
            this.dataGridViewVisits.AllowUserToDeleteRows = false;
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date});
            this.dataGridViewVisits.Location = new System.Drawing.Point(10, 11);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.ReadOnly = true;
            this.dataGridViewVisits.Size = new System.Drawing.Size(110, 220);
            this.dataGridViewVisits.TabIndex = 10;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // richTextBoxOldDescription
            // 
            this.richTextBoxOldDescription.Location = new System.Drawing.Point(140, 27);
            this.richTextBoxOldDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxOldDescription.Name = "richTextBoxOldDescription";
            this.richTextBoxOldDescription.Size = new System.Drawing.Size(284, 175);
            this.richTextBoxOldDescription.TabIndex = 11;
            this.richTextBoxOldDescription.Text = "";
            // 
            // labelOldDescription
            // 
            this.labelOldDescription.AutoSize = true;
            this.labelOldDescription.Location = new System.Drawing.Point(137, 11);
            this.labelOldDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOldDescription.Name = "labelOldDescription";
            this.labelOldDescription.Size = new System.Drawing.Size(79, 13);
            this.labelOldDescription.TabIndex = 12;
            this.labelOldDescription.Text = "Old Description";
            // 
            // dataGridViewOldExaminations
            // 
            this.dataGridViewOldExaminations.AllowUserToAddRows = false;
            this.dataGridViewOldExaminations.AllowUserToDeleteRows = false;
            this.dataGridViewOldExaminations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOldExaminations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Examination});
            this.dataGridViewOldExaminations.Location = new System.Drawing.Point(438, 82);
            this.dataGridViewOldExaminations.Name = "dataGridViewOldExaminations";
            this.dataGridViewOldExaminations.ReadOnly = true;
            this.dataGridViewOldExaminations.Size = new System.Drawing.Size(185, 149);
            this.dataGridViewOldExaminations.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Examination
            // 
            this.Examination.HeaderText = "Examination";
            this.Examination.Name = "Examination";
            this.Examination.ReadOnly = true;
            // 
            // richTextBoxNewDescription
            // 
            this.richTextBoxNewDescription.Location = new System.Drawing.Point(9, 262);
            this.richTextBoxNewDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxNewDescription.Name = "richTextBoxNewDescription";
            this.richTextBoxNewDescription.Size = new System.Drawing.Size(284, 175);
            this.richTextBoxNewDescription.TabIndex = 14;
            this.richTextBoxNewDescription.Text = "";
            // 
            // labelNewDescription
            // 
            this.labelNewDescription.AutoSize = true;
            this.labelNewDescription.Location = new System.Drawing.Point(9, 246);
            this.labelNewDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewDescription.Name = "labelNewDescription";
            this.labelNewDescription.Size = new System.Drawing.Size(85, 13);
            this.labelNewDescription.TabIndex = 15;
            this.labelNewDescription.Text = "New Description";
            // 
            // dataGridViewExaminationsList
            // 
            this.dataGridViewExaminationsList.AllowUserToAddRows = false;
            this.dataGridViewExaminationsList.AllowUserToDeleteRows = false;
            this.dataGridViewExaminationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExaminationsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.dataGridViewExaminationsList.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewExaminationsList.Name = "dataGridViewExaminationsList";
            this.dataGridViewExaminationsList.ReadOnly = true;
            this.dataGridViewExaminationsList.Size = new System.Drawing.Size(121, 150);
            this.dataGridViewExaminationsList.TabIndex = 16;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Medical Examinations";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // buttonAddExamination
            // 
            this.buttonAddExamination.Location = new System.Drawing.Point(142, 126);
            this.buttonAddExamination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddExamination.Name = "buttonAddExamination";
            this.buttonAddExamination.Size = new System.Drawing.Size(108, 19);
            this.buttonAddExamination.TabIndex = 17;
            this.buttonAddExamination.Text = "Add Examination";
            this.buttonAddExamination.UseVisualStyleBackColor = true;
            // 
            // groupBoxExaminationsList
            // 
            this.groupBoxExaminationsList.Controls.Add(this.listBox1);
            this.groupBoxExaminationsList.Controls.Add(this.buttonDeleteExamination);
            this.groupBoxExaminationsList.Controls.Add(this.textBoxExamination);
            this.groupBoxExaminationsList.Controls.Add(this.buttonAddExamination);
            this.groupBoxExaminationsList.Controls.Add(this.dataGridViewExaminationsList);
            this.groupBoxExaminationsList.Location = new System.Drawing.Point(296, 262);
            this.groupBoxExaminationsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxExaminationsList.Name = "groupBoxExaminationsList";
            this.groupBoxExaminationsList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxExaminationsList.Size = new System.Drawing.Size(256, 174);
            this.groupBoxExaminationsList.TabIndex = 18;
            this.groupBoxExaminationsList.TabStop = false;
            this.groupBoxExaminationsList.Text = "Examination List";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Blood Test",
            "Urine Test",
            "Echocardiography",
            "Electrocardiography",
            "Item 5",
            "Item 6",
            "Item 7",
            "Item 8"});
            this.listBox1.Location = new System.Drawing.Point(131, 53);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(122, 69);
            this.listBox1.TabIndex = 20;
            // 
            // buttonDeleteExamination
            // 
            this.buttonDeleteExamination.Location = new System.Drawing.Point(142, 150);
            this.buttonDeleteExamination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDeleteExamination.Name = "buttonDeleteExamination";
            this.buttonDeleteExamination.Size = new System.Drawing.Size(108, 19);
            this.buttonDeleteExamination.TabIndex = 20;
            this.buttonDeleteExamination.Text = "Delete Examination";
            this.buttonDeleteExamination.UseVisualStyleBackColor = true;
            // 
            // textBoxExamination
            // 
            this.textBoxExamination.Location = new System.Drawing.Point(154, 22);
            this.textBoxExamination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxExamination.Name = "textBoxExamination";
            this.textBoxExamination.Size = new System.Drawing.Size(76, 20);
            this.textBoxExamination.TabIndex = 0;
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.textBoxLastName);
            this.groupBoxPatient.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatient.Controls.Add(this.labelFisrtName);
            this.groupBoxPatient.Controls.Add(this.labelLastName);
            this.groupBoxPatient.Location = new System.Drawing.Point(438, 11);
            this.groupBoxPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPatient.Size = new System.Drawing.Size(185, 66);
            this.groupBoxPatient.TabIndex = 19;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(95, 37);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(76, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(7, 37);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(76, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // FormDoctorVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 446);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.groupBoxExaminationsList);
            this.Controls.Add(this.labelNewDescription);
            this.Controls.Add(this.richTextBoxNewDescription);
            this.Controls.Add(this.dataGridViewOldExaminations);
            this.Controls.Add(this.labelOldDescription);
            this.Controls.Add(this.richTextBoxOldDescription);
            this.Controls.Add(this.dataGridViewVisits);
            this.Controls.Add(this.buttonNextVisit);
            this.Controls.Add(this.buttonCancelVisit);
            this.Controls.Add(this.buttonEndVisit);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonPreviousVisit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDoctorVisit";
            this.Text = "FormDoctorVisit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOldExaminations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExaminationsList)).EndInit();
            this.groupBoxExaminationsList.ResumeLayout(false);
            this.groupBoxExaminationsList.PerformLayout();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreviousVisit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEndVisit;
        private System.Windows.Forms.Button buttonCancelVisit;
        private System.Windows.Forms.Label labelFisrtName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonNextVisit;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.RichTextBox richTextBoxOldDescription;
        private System.Windows.Forms.Label labelOldDescription;
        private System.Windows.Forms.DataGridView dataGridViewOldExaminations;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examination;
        private System.Windows.Forms.RichTextBox richTextBoxNewDescription;
        private System.Windows.Forms.Label labelNewDescription;
        private System.Windows.Forms.DataGridView dataGridViewExaminationsList;
        private System.Windows.Forms.Button buttonAddExamination;
        private System.Windows.Forms.GroupBox groupBoxExaminationsList;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button buttonDeleteExamination;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxExamination;
    }
}