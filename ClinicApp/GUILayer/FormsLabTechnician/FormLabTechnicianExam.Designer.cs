namespace GUILayer.FormsLab
{
    partial class FormLabTechExam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLabTechExam));
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelFisrtName = new System.Windows.Forms.Label();
            this.labelTest = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.richTextBoxNewDescription = new System.Windows.Forms.RichTextBox();
            this.buttonCancelExamination = new System.Windows.Forms.Button();
            this.buttonEndExamination = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.groupBoxPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.labelLastName);
            this.groupBoxPatient.Controls.Add(this.labelFirstName);
            this.groupBoxPatient.Controls.Add(this.textBoxLastName);
            this.groupBoxPatient.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatient.Controls.Add(this.textBoxTest);
            this.groupBoxPatient.Controls.Add(this.textBoxID);
            this.groupBoxPatient.Controls.Add(this.labelFisrtName);
            this.groupBoxPatient.Controls.Add(this.labelTest);
            this.groupBoxPatient.Location = new System.Drawing.Point(23, 22);
            this.groupBoxPatient.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxPatient.Size = new System.Drawing.Size(281, 119);
            this.groupBoxPatient.TabIndex = 32;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Examination";
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(150, 37);
            this.textBoxTest.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(116, 20);
            this.textBoxTest.TabIndex = 1;
            this.textBoxTest.Text = "Blood Test ";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(7, 37);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(117, 20);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.Text = "1234567890";
            // 
            // labelFisrtName
            // 
            this.labelFisrtName.AutoSize = true;
            this.labelFisrtName.Location = new System.Drawing.Point(4, 21);
            this.labelFisrtName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFisrtName.Name = "labelFisrtName";
            this.labelFisrtName.Size = new System.Drawing.Size(18, 13);
            this.labelFisrtName.TabIndex = 4;
            this.labelFisrtName.Text = "ID";
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(147, 21);
            this.labelTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(28, 13);
            this.labelTest.TabIndex = 5;
            this.labelTest.Text = "Test";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(20, 152);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 30;
            this.labelDescription.Text = "Description";
            // 
            // richTextBoxNewDescription
            // 
            this.richTextBoxNewDescription.Location = new System.Drawing.Point(20, 168);
            this.richTextBoxNewDescription.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBoxNewDescription.Name = "richTextBoxNewDescription";
            this.richTextBoxNewDescription.Size = new System.Drawing.Size(284, 220);
            this.richTextBoxNewDescription.TabIndex = 29;
            this.richTextBoxNewDescription.Text = resources.GetString("richTextBoxNewDescription.Text");
            // 
            // buttonCancelExamination
            // 
            this.buttonCancelExamination.Location = new System.Drawing.Point(334, 333);
            this.buttonCancelExamination.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelExamination.Name = "buttonCancelExamination";
            this.buttonCancelExamination.Size = new System.Drawing.Size(97, 19);
            this.buttonCancelExamination.TabIndex = 23;
            this.buttonCancelExamination.Text = "Cancel Examination";
            this.buttonCancelExamination.UseVisualStyleBackColor = true;
            // 
            // buttonEndExamination
            // 
            this.buttonEndExamination.Location = new System.Drawing.Point(334, 295);
            this.buttonEndExamination.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEndExamination.Name = "buttonEndExamination";
            this.buttonEndExamination.Size = new System.Drawing.Size(97, 19);
            this.buttonEndExamination.TabIndex = 22;
            this.buttonEndExamination.Text = "End Examination";
            this.buttonEndExamination.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(334, 369);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(97, 19);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(8, 79);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(116, 20);
            this.textBoxFirstName.TabIndex = 6;
            this.textBoxFirstName.Text = "Jas";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(150, 79);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(116, 20);
            this.textBoxLastName.TabIndex = 7;
            this.textBoxLastName.Text = "Jaskowski";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(5, 63);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 8;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(147, 63);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 9;
            this.labelLastName.Text = "Last Name";
            // 
            // FormLabTechExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 411);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.richTextBoxNewDescription);
            this.Controls.Add(this.buttonCancelExamination);
            this.Controls.Add(this.buttonEndExamination);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormLabTechExam";
            this.Text = "FormLabTechExam";
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.TextBox textBoxTest;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelFisrtName;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.RichTextBox richTextBoxNewDescription;
        private System.Windows.Forms.Button buttonCancelExamination;
        private System.Windows.Forms.Button buttonEndExamination;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
    }
}