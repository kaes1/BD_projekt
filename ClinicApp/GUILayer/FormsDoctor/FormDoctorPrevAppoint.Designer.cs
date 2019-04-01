namespace GUILayer.FormsDoctor
{
    partial class FormDoctorPrevAppoint
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
            this.textBoxDiagnosis = new System.Windows.Forms.TextBox();
            this.labelDiagnosis = new System.Windows.Forms.Label();
            this.labelOldDescription = new System.Windows.Forms.Label();
            this.buttonPreviousVisit = new System.Windows.Forms.Button();
            this.buttonNextVisit = new System.Windows.Forms.Button();
            this.richTextBoxOldDescription = new System.Windows.Forms.RichTextBox();
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.DateOfPreviousAppointment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonBackToAppointment = new System.Windows.Forms.Button();
            this.buttonPreviousExaminations = new System.Windows.Forms.Button();
            this.groupBoxPreviousComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPreviousComments
            // 
            this.groupBoxPreviousComments.Controls.Add(this.groupBox1);
            this.groupBoxPreviousComments.Controls.Add(this.textBoxDiagnosis);
            this.groupBoxPreviousComments.Controls.Add(this.labelDiagnosis);
            this.groupBoxPreviousComments.Controls.Add(this.labelOldDescription);
            this.groupBoxPreviousComments.Controls.Add(this.buttonPreviousVisit);
            this.groupBoxPreviousComments.Controls.Add(this.buttonNextVisit);
            this.groupBoxPreviousComments.Controls.Add(this.richTextBoxOldDescription);
            this.groupBoxPreviousComments.Controls.Add(this.dataGridViewVisits);
            this.groupBoxPreviousComments.Location = new System.Drawing.Point(12, 11);
            this.groupBoxPreviousComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPreviousComments.Name = "groupBoxPreviousComments";
            this.groupBoxPreviousComments.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPreviousComments.Size = new System.Drawing.Size(707, 561);
            this.groupBoxPreviousComments.TabIndex = 22;
            this.groupBoxPreviousComments.TabStop = false;
            this.groupBoxPreviousComments.Text = "Previous Appointments";
            // 
            // textBoxDiagnosis
            // 
            this.textBoxDiagnosis.Location = new System.Drawing.Point(295, 219);
            this.textBoxDiagnosis.Name = "textBoxDiagnosis";
            this.textBoxDiagnosis.Size = new System.Drawing.Size(100, 22);
            this.textBoxDiagnosis.TabIndex = 14;
            // 
            // labelDiagnosis
            // 
            this.labelDiagnosis.AutoSize = true;
            this.labelDiagnosis.Location = new System.Drawing.Point(292, 194);
            this.labelDiagnosis.Name = "labelDiagnosis";
            this.labelDiagnosis.Size = new System.Drawing.Size(70, 17);
            this.labelDiagnosis.TabIndex = 13;
            this.labelDiagnosis.Text = "Diagnosis";
            // 
            // labelOldDescription
            // 
            this.labelOldDescription.AutoSize = true;
            this.labelOldDescription.Location = new System.Drawing.Point(292, 249);
            this.labelOldDescription.Name = "labelOldDescription";
            this.labelOldDescription.Size = new System.Drawing.Size(79, 17);
            this.labelOldDescription.TabIndex = 12;
            this.labelOldDescription.Text = "Description";
            // 
            // buttonPreviousVisit
            // 
            this.buttonPreviousVisit.Location = new System.Drawing.Point(331, 496);
            this.buttonPreviousVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousVisit.Name = "buttonPreviousVisit";
            this.buttonPreviousVisit.Size = new System.Drawing.Size(139, 45);
            this.buttonPreviousVisit.TabIndex = 0;
            this.buttonPreviousVisit.Text = "Previous Visit";
            this.buttonPreviousVisit.UseVisualStyleBackColor = true;
            // 
            // buttonNextVisit
            // 
            this.buttonNextVisit.Location = new System.Drawing.Point(495, 496);
            this.buttonNextVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextVisit.Name = "buttonNextVisit";
            this.buttonNextVisit.Size = new System.Drawing.Size(139, 45);
            this.buttonNextVisit.TabIndex = 6;
            this.buttonNextVisit.Text = "Next Visit";
            this.buttonNextVisit.UseVisualStyleBackColor = true;
            // 
            // richTextBoxOldDescription
            // 
            this.richTextBoxOldDescription.Location = new System.Drawing.Point(295, 273);
            this.richTextBoxOldDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxOldDescription.Name = "richTextBoxOldDescription";
            this.richTextBoxOldDescription.ReadOnly = true;
            this.richTextBoxOldDescription.Size = new System.Drawing.Size(377, 214);
            this.richTextBoxOldDescription.TabIndex = 11;
            this.richTextBoxOldDescription.Text = "Pacjent skarży się na bóle głowe.\nWykonano badania fizykalne. Zlecono badanie krw" +
    "i.";
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.AllowUserToAddRows = false;
            this.dataGridViewVisits.AllowUserToDeleteRows = false;
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateOfPreviousAppointment});
            this.dataGridViewVisits.Location = new System.Drawing.Point(17, 21);
            this.dataGridViewVisits.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.ReadOnly = true;
            this.dataGridViewVisits.Size = new System.Drawing.Size(271, 520);
            this.dataGridViewVisits.TabIndex = 10;
            // 
            // DateOfPreviousAppointment
            // 
            this.DateOfPreviousAppointment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfPreviousAppointment.HeaderText = "Date of previous appointment";
            this.DateOfPreviousAppointment.Name = "DateOfPreviousAppointment";
            this.DateOfPreviousAppointment.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBackToAppointment);
            this.groupBox1.Controls.Add(this.buttonPreviousExaminations);
            this.groupBox1.Location = new System.Drawing.Point(413, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(196, 118);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // buttonBackToAppointment
            // 
            this.buttonBackToAppointment.Location = new System.Drawing.Point(6, 19);
            this.buttonBackToAppointment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBackToAppointment.Name = "buttonBackToAppointment";
            this.buttonBackToAppointment.Size = new System.Drawing.Size(184, 41);
            this.buttonBackToAppointment.TabIndex = 26;
            this.buttonBackToAppointment.Text = "Back to appointment";
            this.buttonBackToAppointment.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousExaminations
            // 
            this.buttonPreviousExaminations.Location = new System.Drawing.Point(6, 68);
            this.buttonPreviousExaminations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousExaminations.Name = "buttonPreviousExaminations";
            this.buttonPreviousExaminations.Size = new System.Drawing.Size(184, 41);
            this.buttonPreviousExaminations.TabIndex = 27;
            this.buttonPreviousExaminations.Text = "Previous examinations";
            this.buttonPreviousExaminations.UseVisualStyleBackColor = true;
            // 
            // FormDoctorPrevAppoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 583);
            this.Controls.Add(this.groupBoxPreviousComments);
            this.Name = "FormDoctorPrevAppoint";
            this.Text = "FormDoctorHistory";
            this.groupBoxPreviousComments.ResumeLayout(false);
            this.groupBoxPreviousComments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPreviousComments;
        private System.Windows.Forms.Label labelOldDescription;
        private System.Windows.Forms.Button buttonPreviousVisit;
        private System.Windows.Forms.Button buttonNextVisit;
        private System.Windows.Forms.RichTextBox richTextBoxOldDescription;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private System.Windows.Forms.TextBox textBoxDiagnosis;
        private System.Windows.Forms.Label labelDiagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPreviousAppointment;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBackToAppointment;
        private System.Windows.Forms.Button buttonPreviousExaminations;
    }
}