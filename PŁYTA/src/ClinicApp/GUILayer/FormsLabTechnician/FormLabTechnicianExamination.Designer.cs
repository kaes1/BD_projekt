namespace GUILayer
{
    partial class FormLabTechnicianExamination
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
            this.buttonComplete = new System.Windows.Forms.Button();
            this.buttonCancelExamination = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelLabManagerComments = new System.Windows.Forms.Label();
            this.textBoxDateCompleted = new System.Windows.Forms.TextBox();
            this.labelDateCompleted = new System.Windows.Forms.Label();
            this.labelExaminationName = new System.Windows.Forms.Label();
            this.textBoxLabManagerComments = new System.Windows.Forms.TextBox();
            this.textBoxDateRegistered = new System.Windows.Forms.TextBox();
            this.labelDoctorComments = new System.Windows.Forms.Label();
            this.labelPanelName = new System.Windows.Forms.Label();
            this.textBoxExaminationName = new System.Windows.Forms.TextBox();
            this.textBoxDoctorComments = new System.Windows.Forms.TextBox();
            this.textBoxExaminationCode = new System.Windows.Forms.TextBox();
            this.labelExaminationCode = new System.Windows.Forms.Label();
            this.textBoxPatientFirstName = new System.Windows.Forms.TextBox();
            this.labelPatientFirstName = new System.Windows.Forms.Label();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxPatientLastName = new System.Windows.Forms.TextBox();
            this.labelPatientLastName = new System.Windows.Forms.Label();
            this.groupBoxLabExamination = new System.Windows.Forms.GroupBox();
            this.labelDateRegistered = new System.Windows.Forms.Label();
            this.groupBoxLabExamination.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonComplete
            // 
            this.buttonComplete.Enabled = false;
            this.buttonComplete.Location = new System.Drawing.Point(14, 546);
            this.buttonComplete.Name = "buttonComplete";
            this.buttonComplete.Size = new System.Drawing.Size(120, 23);
            this.buttonComplete.TabIndex = 1;
            this.buttonComplete.Text = "Complete";
            this.buttonComplete.UseVisualStyleBackColor = true;
            this.buttonComplete.Click += new System.EventHandler(this.buttonComplete_Click);
            // 
            // buttonCancelExamination
            // 
            this.buttonCancelExamination.Enabled = false;
            this.buttonCancelExamination.Location = new System.Drawing.Point(241, 546);
            this.buttonCancelExamination.Name = "buttonCancelExamination";
            this.buttonCancelExamination.Size = new System.Drawing.Size(120, 23);
            this.buttonCancelExamination.TabIndex = 2;
            this.buttonCancelExamination.Text = "Cancel";
            this.buttonCancelExamination.UseVisualStyleBackColor = true;
            this.buttonCancelExamination.Click += new System.EventHandler(this.buttonCancelExamination_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(458, 546);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 23);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Back";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(17, 244);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 13);
            this.labelResult.TabIndex = 24;
            this.labelResult.Text = "Result";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(22, 260);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(527, 80);
            this.textBoxResult.TabIndex = 23;
            // 
            // labelLabManagerComments
            // 
            this.labelLabManagerComments.AutoSize = true;
            this.labelLabManagerComments.Location = new System.Drawing.Point(17, 350);
            this.labelLabManagerComments.Name = "labelLabManagerComments";
            this.labelLabManagerComments.Size = new System.Drawing.Size(122, 13);
            this.labelLabManagerComments.TabIndex = 22;
            this.labelLabManagerComments.Text = "Lab Manager Comments";
            // 
            // textBoxDateCompleted
            // 
            this.textBoxDateCompleted.Location = new System.Drawing.Point(157, 99);
            this.textBoxDateCompleted.Name = "textBoxDateCompleted";
            this.textBoxDateCompleted.ReadOnly = true;
            this.textBoxDateCompleted.Size = new System.Drawing.Size(120, 20);
            this.textBoxDateCompleted.TabIndex = 16;
            // 
            // labelDateCompleted
            // 
            this.labelDateCompleted.AutoSize = true;
            this.labelDateCompleted.Location = new System.Drawing.Point(154, 83);
            this.labelDateCompleted.Name = "labelDateCompleted";
            this.labelDateCompleted.Size = new System.Drawing.Size(83, 13);
            this.labelDateCompleted.TabIndex = 15;
            this.labelDateCompleted.Text = "Date Completed";
            // 
            // labelExaminationName
            // 
            this.labelExaminationName.AutoSize = true;
            this.labelExaminationName.Location = new System.Drawing.Point(19, 25);
            this.labelExaminationName.Name = "labelExaminationName";
            this.labelExaminationName.Size = new System.Drawing.Size(35, 13);
            this.labelExaminationName.TabIndex = 11;
            this.labelExaminationName.Text = "Name";
            // 
            // textBoxLabManagerComments
            // 
            this.textBoxLabManagerComments.Location = new System.Drawing.Point(20, 366);
            this.textBoxLabManagerComments.Multiline = true;
            this.textBoxLabManagerComments.Name = "textBoxLabManagerComments";
            this.textBoxLabManagerComments.ReadOnly = true;
            this.textBoxLabManagerComments.Size = new System.Drawing.Size(529, 80);
            this.textBoxLabManagerComments.TabIndex = 21;
            // 
            // textBoxDateRegistered
            // 
            this.textBoxDateRegistered.Location = new System.Drawing.Point(21, 99);
            this.textBoxDateRegistered.Name = "textBoxDateRegistered";
            this.textBoxDateRegistered.ReadOnly = true;
            this.textBoxDateRegistered.Size = new System.Drawing.Size(120, 20);
            this.textBoxDateRegistered.TabIndex = 14;
            // 
            // labelDoctorComments
            // 
            this.labelDoctorComments.AutoSize = true;
            this.labelDoctorComments.Location = new System.Drawing.Point(18, 140);
            this.labelDoctorComments.Name = "labelDoctorComments";
            this.labelDoctorComments.Size = new System.Drawing.Size(91, 13);
            this.labelDoctorComments.TabIndex = 20;
            this.labelDoctorComments.Text = "Doctor Comments";
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(111, 9);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(370, 37);
            this.labelPanelName.TabIndex = 35;
            this.labelPanelName.Text = "Lab Examination Details";
            // 
            // textBoxExaminationName
            // 
            this.textBoxExaminationName.Location = new System.Drawing.Point(21, 41);
            this.textBoxExaminationName.Name = "textBoxExaminationName";
            this.textBoxExaminationName.ReadOnly = true;
            this.textBoxExaminationName.Size = new System.Drawing.Size(256, 20);
            this.textBoxExaminationName.TabIndex = 12;
            // 
            // textBoxDoctorComments
            // 
            this.textBoxDoctorComments.Location = new System.Drawing.Point(21, 156);
            this.textBoxDoctorComments.Multiline = true;
            this.textBoxDoctorComments.Name = "textBoxDoctorComments";
            this.textBoxDoctorComments.ReadOnly = true;
            this.textBoxDoctorComments.Size = new System.Drawing.Size(528, 80);
            this.textBoxDoctorComments.TabIndex = 18;
            // 
            // textBoxExaminationCode
            // 
            this.textBoxExaminationCode.Location = new System.Drawing.Point(293, 41);
            this.textBoxExaminationCode.Name = "textBoxExaminationCode";
            this.textBoxExaminationCode.ReadOnly = true;
            this.textBoxExaminationCode.Size = new System.Drawing.Size(120, 20);
            this.textBoxExaminationCode.TabIndex = 10;
            // 
            // labelExaminationCode
            // 
            this.labelExaminationCode.AutoSize = true;
            this.labelExaminationCode.Location = new System.Drawing.Point(290, 25);
            this.labelExaminationCode.Name = "labelExaminationCode";
            this.labelExaminationCode.Size = new System.Drawing.Size(32, 13);
            this.labelExaminationCode.TabIndex = 9;
            this.labelExaminationCode.Text = "Code";
            // 
            // textBoxPatientFirstName
            // 
            this.textBoxPatientFirstName.Location = new System.Drawing.Point(293, 99);
            this.textBoxPatientFirstName.Name = "textBoxPatientFirstName";
            this.textBoxPatientFirstName.ReadOnly = true;
            this.textBoxPatientFirstName.Size = new System.Drawing.Size(120, 20);
            this.textBoxPatientFirstName.TabIndex = 6;
            // 
            // labelPatientFirstName
            // 
            this.labelPatientFirstName.AutoSize = true;
            this.labelPatientFirstName.Location = new System.Drawing.Point(292, 83);
            this.labelPatientFirstName.Name = "labelPatientFirstName";
            this.labelPatientFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelPatientFirstName.TabIndex = 3;
            this.labelPatientFirstName.Text = "First Name";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(429, 41);
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.ReadOnly = true;
            this.textBoxStatus.Size = new System.Drawing.Size(120, 20);
            this.textBoxStatus.TabIndex = 8;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(426, 25);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Status";
            // 
            // textBoxPatientLastName
            // 
            this.textBoxPatientLastName.Location = new System.Drawing.Point(429, 99);
            this.textBoxPatientLastName.Name = "textBoxPatientLastName";
            this.textBoxPatientLastName.ReadOnly = true;
            this.textBoxPatientLastName.Size = new System.Drawing.Size(120, 20);
            this.textBoxPatientLastName.TabIndex = 7;
            // 
            // labelPatientLastName
            // 
            this.labelPatientLastName.AutoSize = true;
            this.labelPatientLastName.Location = new System.Drawing.Point(426, 83);
            this.labelPatientLastName.Name = "labelPatientLastName";
            this.labelPatientLastName.Size = new System.Drawing.Size(58, 13);
            this.labelPatientLastName.TabIndex = 4;
            this.labelPatientLastName.Text = "Last Name";
            // 
            // groupBoxLabExamination
            // 
            this.groupBoxLabExamination.Controls.Add(this.labelResult);
            this.groupBoxLabExamination.Controls.Add(this.textBoxResult);
            this.groupBoxLabExamination.Controls.Add(this.labelLabManagerComments);
            this.groupBoxLabExamination.Controls.Add(this.textBoxDateCompleted);
            this.groupBoxLabExamination.Controls.Add(this.labelDateCompleted);
            this.groupBoxLabExamination.Controls.Add(this.labelExaminationName);
            this.groupBoxLabExamination.Controls.Add(this.textBoxLabManagerComments);
            this.groupBoxLabExamination.Controls.Add(this.textBoxDateRegistered);
            this.groupBoxLabExamination.Controls.Add(this.labelDoctorComments);
            this.groupBoxLabExamination.Controls.Add(this.labelDateRegistered);
            this.groupBoxLabExamination.Controls.Add(this.textBoxExaminationName);
            this.groupBoxLabExamination.Controls.Add(this.textBoxDoctorComments);
            this.groupBoxLabExamination.Controls.Add(this.textBoxExaminationCode);
            this.groupBoxLabExamination.Controls.Add(this.labelExaminationCode);
            this.groupBoxLabExamination.Controls.Add(this.textBoxPatientFirstName);
            this.groupBoxLabExamination.Controls.Add(this.labelPatientFirstName);
            this.groupBoxLabExamination.Controls.Add(this.textBoxStatus);
            this.groupBoxLabExamination.Controls.Add(this.labelStatus);
            this.groupBoxLabExamination.Controls.Add(this.textBoxPatientLastName);
            this.groupBoxLabExamination.Controls.Add(this.labelPatientLastName);
            this.groupBoxLabExamination.Location = new System.Drawing.Point(12, 60);
            this.groupBoxLabExamination.Name = "groupBoxLabExamination";
            this.groupBoxLabExamination.Size = new System.Drawing.Size(566, 467);
            this.groupBoxLabExamination.TabIndex = 36;
            this.groupBoxLabExamination.TabStop = false;
            this.groupBoxLabExamination.Text = "Examination";
            // 
            // labelDateRegistered
            // 
            this.labelDateRegistered.AutoSize = true;
            this.labelDateRegistered.Location = new System.Drawing.Point(18, 83);
            this.labelDateRegistered.Name = "labelDateRegistered";
            this.labelDateRegistered.Size = new System.Drawing.Size(84, 13);
            this.labelDateRegistered.TabIndex = 13;
            this.labelDateRegistered.Text = "Date Registered";
            // 
            // FormLabTechnicianExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 589);
            this.Controls.Add(this.buttonComplete);
            this.Controls.Add(this.buttonCancelExamination);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelPanelName);
            this.Controls.Add(this.groupBoxLabExamination);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLabTechnicianExamination";
            this.Text = "FormLabTechnicianExamination";
            this.groupBoxLabExamination.ResumeLayout(false);
            this.groupBoxLabExamination.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonComplete;
        private System.Windows.Forms.Button buttonCancelExamination;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelLabManagerComments;
        private System.Windows.Forms.TextBox textBoxDateCompleted;
        private System.Windows.Forms.Label labelDateCompleted;
        private System.Windows.Forms.Label labelExaminationName;
        private System.Windows.Forms.TextBox textBoxLabManagerComments;
        private System.Windows.Forms.TextBox textBoxDateRegistered;
        private System.Windows.Forms.Label labelDoctorComments;
        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.TextBox textBoxExaminationName;
        private System.Windows.Forms.TextBox textBoxDoctorComments;
        private System.Windows.Forms.TextBox textBoxExaminationCode;
        private System.Windows.Forms.Label labelExaminationCode;
        private System.Windows.Forms.TextBox textBoxPatientFirstName;
        private System.Windows.Forms.Label labelPatientFirstName;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxPatientLastName;
        private System.Windows.Forms.Label labelPatientLastName;
        private System.Windows.Forms.GroupBox groupBoxLabExamination;
        private System.Windows.Forms.Label labelDateRegistered;
    }
}