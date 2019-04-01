namespace GUILayer.FormsDoctor
{
    partial class FormDoctorPrevExaminations
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
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcedureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPreviousTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBoxOldDescription = new System.Windows.Forms.RichTextBox();
            this.buttonNextVisit = new System.Windows.Forms.Button();
            this.buttonPreviousVisit = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPreviousAppointments = new System.Windows.Forms.Button();
            this.buttonBackToAppointment = new System.Windows.Forms.Button();
            this.groupBoxPreviousComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPreviousComments
            // 
            this.groupBoxPreviousComments.Controls.Add(this.groupBox1);
            this.groupBoxPreviousComments.Controls.Add(this.labelResult);
            this.groupBoxPreviousComments.Controls.Add(this.buttonPreviousVisit);
            this.groupBoxPreviousComments.Controls.Add(this.buttonNextVisit);
            this.groupBoxPreviousComments.Controls.Add(this.richTextBoxOldDescription);
            this.groupBoxPreviousComments.Controls.Add(this.dataGridViewVisits);
            this.groupBoxPreviousComments.Location = new System.Drawing.Point(12, 11);
            this.groupBoxPreviousComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPreviousComments.Name = "groupBoxPreviousComments";
            this.groupBoxPreviousComments.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPreviousComments.Size = new System.Drawing.Size(911, 561);
            this.groupBoxPreviousComments.TabIndex = 24;
            this.groupBoxPreviousComments.TabStop = false;
            this.groupBoxPreviousComments.Text = "Previous Appointments";
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.AllowUserToAddRows = false;
            this.dataGridViewVisits.AllowUserToDeleteRows = false;
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateOfPreviousTest,
            this.ProcedureName,
            this.Status});
            this.dataGridViewVisits.Location = new System.Drawing.Point(17, 21);
            this.dataGridViewVisits.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.ReadOnly = true;
            this.dataGridViewVisits.Size = new System.Drawing.Size(463, 520);
            this.dataGridViewVisits.TabIndex = 10;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ProcedureName
            // 
            this.ProcedureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProcedureName.HeaderText = "Procedute name";
            this.ProcedureName.Name = "ProcedureName";
            this.ProcedureName.ReadOnly = true;
            // 
            // DateOfPreviousTest
            // 
            this.DateOfPreviousTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfPreviousTest.HeaderText = "Date of test";
            this.DateOfPreviousTest.Name = "DateOfPreviousTest";
            this.DateOfPreviousTest.ReadOnly = true;
            // 
            // richTextBoxOldDescription
            // 
            this.richTextBoxOldDescription.Location = new System.Drawing.Point(512, 285);
            this.richTextBoxOldDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxOldDescription.Name = "richTextBoxOldDescription";
            this.richTextBoxOldDescription.ReadOnly = true;
            this.richTextBoxOldDescription.Size = new System.Drawing.Size(377, 214);
            this.richTextBoxOldDescription.TabIndex = 11;
            this.richTextBoxOldDescription.Text = "Pacjent skarży się na bóle głowe.\nWykonano badania fizykalne. Zlecono badanie krw" +
    "i.";
            // 
            // buttonNextVisit
            // 
            this.buttonNextVisit.Location = new System.Drawing.Point(712, 508);
            this.buttonNextVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextVisit.Name = "buttonNextVisit";
            this.buttonNextVisit.Size = new System.Drawing.Size(139, 45);
            this.buttonNextVisit.TabIndex = 6;
            this.buttonNextVisit.Text = "Next test";
            this.buttonNextVisit.UseVisualStyleBackColor = true;
            // 
            // buttonPreviousVisit
            // 
            this.buttonPreviousVisit.Location = new System.Drawing.Point(548, 508);
            this.buttonPreviousVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousVisit.Name = "buttonPreviousVisit";
            this.buttonPreviousVisit.Size = new System.Drawing.Size(139, 45);
            this.buttonPreviousVisit.TabIndex = 0;
            this.buttonPreviousVisit.Text = "Previous test";
            this.buttonPreviousVisit.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(509, 261);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(48, 17);
            this.labelResult.TabIndex = 12;
            this.labelResult.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonBackToAppointment);
            this.groupBox1.Controls.Add(this.buttonPreviousAppointments);
            this.groupBox1.Location = new System.Drawing.Point(630, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(196, 118);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            // 
            // buttonPreviousAppointments
            // 
            this.buttonPreviousAppointments.Location = new System.Drawing.Point(6, 68);
            this.buttonPreviousAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousAppointments.Name = "buttonPreviousAppointments";
            this.buttonPreviousAppointments.Size = new System.Drawing.Size(184, 41);
            this.buttonPreviousAppointments.TabIndex = 27;
            this.buttonPreviousAppointments.Text = "Previous appointments";
            this.buttonPreviousAppointments.UseVisualStyleBackColor = true;
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
            // FormDoctorPrevExaminations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 879);
            this.Controls.Add(this.groupBoxPreviousComments);
            this.Name = "FormDoctorPrevExaminations";
            this.Text = "FormDoctorPrevExaminations";
            this.groupBoxPreviousComments.ResumeLayout(false);
            this.groupBoxPreviousComments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPreviousComments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBackToAppointment;
        private System.Windows.Forms.Button buttonPreviousAppointments;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonPreviousVisit;
        private System.Windows.Forms.Button buttonNextVisit;
        private System.Windows.Forms.RichTextBox richTextBoxOldDescription;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPreviousTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcedureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}