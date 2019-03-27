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
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.labelProcedureName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxProcedureID = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelTestID = new System.Windows.Forms.Label();
            this.labelProcedureID = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.richTextBoxNewDescription = new System.Windows.Forms.RichTextBox();
            this.buttonCancelTest = new System.Windows.Forms.Button();
            this.buttonEndTest = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.richTextBoxDoctorComments = new System.Windows.Forms.RichTextBox();
            this.labelDoctorComments = new System.Windows.Forms.Label();
            this.groupBoxPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.labelProcedureName);
            this.groupBoxPatient.Controls.Add(this.textBox1);
            this.groupBoxPatient.Controls.Add(this.labelLastName);
            this.groupBoxPatient.Controls.Add(this.labelFirstName);
            this.groupBoxPatient.Controls.Add(this.textBoxLastName);
            this.groupBoxPatient.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatient.Controls.Add(this.textBoxProcedureID);
            this.groupBoxPatient.Controls.Add(this.textBoxID);
            this.groupBoxPatient.Controls.Add(this.labelTestID);
            this.groupBoxPatient.Controls.Add(this.labelProcedureID);
            this.groupBoxPatient.Location = new System.Drawing.Point(31, 27);
            this.groupBoxPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPatient.Size = new System.Drawing.Size(550, 146);
            this.groupBoxPatient.TabIndex = 32;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Lab Test";
            // 
            // labelProcedureName
            // 
            this.labelProcedureName.AutoSize = true;
            this.labelProcedureName.Location = new System.Drawing.Point(373, 27);
            this.labelProcedureName.Name = "labelProcedureName";
            this.labelProcedureName.Size = new System.Drawing.Size(115, 17);
            this.labelProcedureName.TabIndex = 11;
            this.labelProcedureName.Text = "Procedure Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(376, 46);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 22);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Blood Test";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(196, 78);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 17);
            this.labelLastName.TabIndex = 9;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(7, 78);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(76, 17);
            this.labelFirstName.TabIndex = 8;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(200, 97);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(153, 22);
            this.textBoxLastName.TabIndex = 7;
            this.textBoxLastName.Text = "Jaskowski";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(11, 97);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(153, 22);
            this.textBoxFirstName.TabIndex = 6;
            this.textBoxFirstName.Text = "Jas";
            // 
            // textBoxProcedureID
            // 
            this.textBoxProcedureID.Location = new System.Drawing.Point(200, 46);
            this.textBoxProcedureID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxProcedureID.Name = "textBoxProcedureID";
            this.textBoxProcedureID.Size = new System.Drawing.Size(153, 22);
            this.textBoxProcedureID.TabIndex = 1;
            this.textBoxProcedureID.Text = "H01";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(9, 46);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(155, 22);
            this.textBoxID.TabIndex = 0;
            this.textBoxID.Text = "1234567890";
            // 
            // labelTestID
            // 
            this.labelTestID.AutoSize = true;
            this.labelTestID.Location = new System.Drawing.Point(5, 26);
            this.labelTestID.Name = "labelTestID";
            this.labelTestID.Size = new System.Drawing.Size(53, 17);
            this.labelTestID.TabIndex = 4;
            this.labelTestID.Text = "Test ID";
            // 
            // labelProcedureID
            // 
            this.labelProcedureID.AutoSize = true;
            this.labelProcedureID.Location = new System.Drawing.Point(196, 26);
            this.labelProcedureID.Name = "labelProcedureID";
            this.labelProcedureID.Size = new System.Drawing.Size(91, 17);
            this.labelProcedureID.TabIndex = 5;
            this.labelProcedureID.Text = "Procedure ID";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(27, 187);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(48, 17);
            this.labelResult.TabIndex = 30;
            this.labelResult.Text = "Result";
            // 
            // richTextBoxNewDescription
            // 
            this.richTextBoxNewDescription.Location = new System.Drawing.Point(27, 207);
            this.richTextBoxNewDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxNewDescription.Name = "richTextBoxNewDescription";
            this.richTextBoxNewDescription.Size = new System.Drawing.Size(276, 270);
            this.richTextBoxNewDescription.TabIndex = 29;
            this.richTextBoxNewDescription.Text = "Krwinki czerwone 0.05/L Norma <0.05 - 1.0>\nKrwinki białe 2.2/L\n\n\n\n";
            // 
            // buttonCancelTest
            // 
            this.buttonCancelTest.Location = new System.Drawing.Point(390, 412);
            this.buttonCancelTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelTest.Name = "buttonCancelTest";
            this.buttonCancelTest.Size = new System.Drawing.Size(129, 23);
            this.buttonCancelTest.TabIndex = 23;
            this.buttonCancelTest.Text = "Cancel Test";
            this.buttonCancelTest.UseVisualStyleBackColor = true;
            // 
            // buttonEndTest
            // 
            this.buttonEndTest.Location = new System.Drawing.Point(390, 367);
            this.buttonEndTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEndTest.Name = "buttonEndTest";
            this.buttonEndTest.Size = new System.Drawing.Size(129, 23);
            this.buttonEndTest.TabIndex = 22;
            this.buttonEndTest.Text = "End Test";
            this.buttonEndTest.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(390, 454);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(129, 23);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "Go Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // richTextBoxDoctorComments
            // 
            this.richTextBoxDoctorComments.Location = new System.Drawing.Point(323, 207);
            this.richTextBoxDoctorComments.Name = "richTextBoxDoctorComments";
            this.richTextBoxDoctorComments.ReadOnly = true;
            this.richTextBoxDoctorComments.Size = new System.Drawing.Size(258, 144);
            this.richTextBoxDoctorComments.TabIndex = 33;
            this.richTextBoxDoctorComments.Text = "";
            // 
            // labelDoctorComments
            // 
            this.labelDoctorComments.AutoSize = true;
            this.labelDoctorComments.Location = new System.Drawing.Point(320, 187);
            this.labelDoctorComments.Name = "labelDoctorComments";
            this.labelDoctorComments.Size = new System.Drawing.Size(120, 17);
            this.labelDoctorComments.TabIndex = 34;
            this.labelDoctorComments.Text = "Doctor Comments";
            // 
            // FormLabTechExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 506);
            this.Controls.Add(this.labelDoctorComments);
            this.Controls.Add(this.richTextBoxDoctorComments);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.richTextBoxNewDescription);
            this.Controls.Add(this.buttonCancelTest);
            this.Controls.Add(this.buttonEndTest);
            this.Controls.Add(this.buttonBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLabTechExam";
            this.Text = "FormLabTechExam";
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.TextBox textBoxProcedureID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelTestID;
        private System.Windows.Forms.Label labelProcedureID;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.RichTextBox richTextBoxNewDescription;
        private System.Windows.Forms.Button buttonCancelTest;
        private System.Windows.Forms.Button buttonEndTest;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelProcedureName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBoxDoctorComments;
        private System.Windows.Forms.Label labelDoctorComments;
    }
}