namespace GUILayer.FormsDoctor
{
    partial class FormDoctorManageExaminations
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
            this.groupBoxPhysicalExaminations = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.richTextBoxResult = new System.Windows.Forms.RichTextBox();
            this.buttonAddPhysExamination = new System.Windows.Forms.Button();
            this.dataGridPhysExamList = new System.Windows.Forms.DataGridView();
            this.groupBoxLabTestsList = new System.Windows.Forms.GroupBox();
            this.labelCommentToLaborant = new System.Windows.Forms.Label();
            this.richTextBoxCommentToLaborant = new System.Windows.Forms.RichTextBox();
            this.buttonAddLabExamination = new System.Windows.Forms.Button();
            this.dataGridViewLabExamList = new System.Windows.Forms.DataGridView();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFisrtName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.buttonBackToAppointment = new System.Windows.Forms.Button();
            this.groupBoxPhysicalExaminations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhysExamList)).BeginInit();
            this.groupBoxLabTestsList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabExamList)).BeginInit();
            this.groupBoxPatient.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPhysicalExaminations
            // 
            this.groupBoxPhysicalExaminations.Controls.Add(this.labelResult);
            this.groupBoxPhysicalExaminations.Controls.Add(this.richTextBoxResult);
            this.groupBoxPhysicalExaminations.Controls.Add(this.buttonAddPhysExamination);
            this.groupBoxPhysicalExaminations.Controls.Add(this.dataGridPhysExamList);
            this.groupBoxPhysicalExaminations.Location = new System.Drawing.Point(12, 96);
            this.groupBoxPhysicalExaminations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPhysicalExaminations.Name = "groupBoxPhysicalExaminations";
            this.groupBoxPhysicalExaminations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPhysicalExaminations.Size = new System.Drawing.Size(747, 323);
            this.groupBoxPhysicalExaminations.TabIndex = 25;
            this.groupBoxPhysicalExaminations.TabStop = false;
            this.groupBoxPhysicalExaminations.Text = "Physical examinations";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(516, 25);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(48, 17);
            this.labelResult.TabIndex = 19;
            this.labelResult.Text = "Result";
            // 
            // richTextBoxResult
            // 
            this.richTextBoxResult.Location = new System.Drawing.Point(519, 44);
            this.richTextBoxResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxResult.Name = "richTextBoxResult";
            this.richTextBoxResult.ReadOnly = true;
            this.richTextBoxResult.Size = new System.Drawing.Size(215, 216);
            this.richTextBoxResult.TabIndex = 18;
            this.richTextBoxResult.Text = "";
            // 
            // buttonAddPhysExamination
            // 
            this.buttonAddPhysExamination.Location = new System.Drawing.Point(539, 268);
            this.buttonAddPhysExamination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPhysExamination.Name = "buttonAddPhysExamination";
            this.buttonAddPhysExamination.Size = new System.Drawing.Size(177, 41);
            this.buttonAddPhysExamination.TabIndex = 17;
            this.buttonAddPhysExamination.Text = "Add Physical Examination";
            this.buttonAddPhysExamination.UseVisualStyleBackColor = true;
            this.buttonAddPhysExamination.Click += new System.EventHandler(this.buttonAddPhysExamination_Click);
            // 
            // dataGridPhysExamList
            // 
            this.dataGridPhysExamList.AllowUserToAddRows = false;
            this.dataGridPhysExamList.AllowUserToDeleteRows = false;
            this.dataGridPhysExamList.AllowUserToResizeColumns = false;
            this.dataGridPhysExamList.AllowUserToResizeRows = false;
            this.dataGridPhysExamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPhysExamList.Location = new System.Drawing.Point(7, 22);
            this.dataGridPhysExamList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridPhysExamList.Name = "dataGridPhysExamList";
            this.dataGridPhysExamList.ReadOnly = true;
            this.dataGridPhysExamList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPhysExamList.Size = new System.Drawing.Size(500, 289);
            this.dataGridPhysExamList.TabIndex = 16;
            this.dataGridPhysExamList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridPhysExamList_CellContentClick);
            // 
            // groupBoxLabTestsList
            // 
            this.groupBoxLabTestsList.Controls.Add(this.labelCommentToLaborant);
            this.groupBoxLabTestsList.Controls.Add(this.richTextBoxCommentToLaborant);
            this.groupBoxLabTestsList.Controls.Add(this.buttonAddLabExamination);
            this.groupBoxLabTestsList.Controls.Add(this.dataGridViewLabExamList);
            this.groupBoxLabTestsList.Location = new System.Drawing.Point(20, 423);
            this.groupBoxLabTestsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLabTestsList.Name = "groupBoxLabTestsList";
            this.groupBoxLabTestsList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLabTestsList.Size = new System.Drawing.Size(739, 323);
            this.groupBoxLabTestsList.TabIndex = 24;
            this.groupBoxLabTestsList.TabStop = false;
            this.groupBoxLabTestsList.Text = "Laboratory examinations";
            // 
            // labelCommentToLaborant
            // 
            this.labelCommentToLaborant.AutoSize = true;
            this.labelCommentToLaborant.Location = new System.Drawing.Point(506, 22);
            this.labelCommentToLaborant.Name = "labelCommentToLaborant";
            this.labelCommentToLaborant.Size = new System.Drawing.Size(151, 17);
            this.labelCommentToLaborant.TabIndex = 22;
            this.labelCommentToLaborant.Text = "Comment to laboratory";
            // 
            // richTextBoxCommentToLaborant
            // 
            this.richTextBoxCommentToLaborant.Location = new System.Drawing.Point(510, 41);
            this.richTextBoxCommentToLaborant.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxCommentToLaborant.Name = "richTextBoxCommentToLaborant";
            this.richTextBoxCommentToLaborant.ReadOnly = true;
            this.richTextBoxCommentToLaborant.Size = new System.Drawing.Size(216, 216);
            this.richTextBoxCommentToLaborant.TabIndex = 21;
            this.richTextBoxCommentToLaborant.Text = "";
            // 
            // buttonAddLabExamination
            // 
            this.buttonAddLabExamination.Location = new System.Drawing.Point(531, 265);
            this.buttonAddLabExamination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddLabExamination.Name = "buttonAddLabExamination";
            this.buttonAddLabExamination.Size = new System.Drawing.Size(177, 41);
            this.buttonAddLabExamination.TabIndex = 17;
            this.buttonAddLabExamination.Text = "Add Lab Examination";
            this.buttonAddLabExamination.UseVisualStyleBackColor = true;
            this.buttonAddLabExamination.Click += new System.EventHandler(this.buttonAddLabExamination_Click);
            // 
            // dataGridViewLabExamList
            // 
            this.dataGridViewLabExamList.AllowUserToAddRows = false;
            this.dataGridViewLabExamList.AllowUserToDeleteRows = false;
            this.dataGridViewLabExamList.AllowUserToResizeColumns = false;
            this.dataGridViewLabExamList.AllowUserToResizeRows = false;
            this.dataGridViewLabExamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLabExamList.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewLabExamList.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewLabExamList.Name = "dataGridViewLabExamList";
            this.dataGridViewLabExamList.ReadOnly = true;
            this.dataGridViewLabExamList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLabExamList.Size = new System.Drawing.Size(492, 289);
            this.dataGridViewLabExamList.TabIndex = 16;
            this.dataGridViewLabExamList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLabExamList_CellContentClick);
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
            this.groupBoxPatient.TabIndex = 26;
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
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonBackToAppointment);
            this.groupBoxControls.Location = new System.Drawing.Point(563, 17);
            this.groupBoxControls.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxControls.Size = new System.Drawing.Size(196, 75);
            this.groupBoxControls.TabIndex = 27;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Menu";
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
            // FormDoctorManageExaminations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 759);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.groupBoxPhysicalExaminations);
            this.Controls.Add(this.groupBoxLabTestsList);
            this.Name = "FormDoctorManageExaminations";
            this.Text = "FormDoctorManageExaminations";
            this.groupBoxPhysicalExaminations.ResumeLayout(false);
            this.groupBoxPhysicalExaminations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPhysExamList)).EndInit();
            this.groupBoxLabTestsList.ResumeLayout(false);
            this.groupBoxLabTestsList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLabExamList)).EndInit();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.groupBoxControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPhysicalExaminations;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.RichTextBox richTextBoxResult;
        private System.Windows.Forms.Button buttonAddPhysExamination;
        private System.Windows.Forms.DataGridView dataGridPhysExamList;
        private System.Windows.Forms.GroupBox groupBoxLabTestsList;
        private System.Windows.Forms.Label labelCommentToLaborant;
        private System.Windows.Forms.RichTextBox richTextBoxCommentToLaborant;
        private System.Windows.Forms.Button buttonAddLabExamination;
        private System.Windows.Forms.DataGridView dataGridViewLabExamList;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFisrtName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonBackToAppointment;
    }
}