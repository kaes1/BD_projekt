namespace GUILayer.FormsDoctor
{
    partial class FormDoctorLabTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxChoosenExamination = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelChoosenExamination = new System.Windows.Forms.Label();
            this.groupBoxPhysicalExaminations.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPhysicalExaminations
            // 
            this.groupBoxPhysicalExaminations.Controls.Add(this.button1);
            this.groupBoxPhysicalExaminations.Controls.Add(this.buttonCancel);
            this.groupBoxPhysicalExaminations.Controls.Add(this.buttonConfirm);
            this.groupBoxPhysicalExaminations.Controls.Add(this.labelResult);
            this.groupBoxPhysicalExaminations.Controls.Add(this.textBoxChoosenExamination);
            this.groupBoxPhysicalExaminations.Controls.Add(this.richTextBox1);
            this.groupBoxPhysicalExaminations.Controls.Add(this.labelChoosenExamination);
            this.groupBoxPhysicalExaminations.Location = new System.Drawing.Point(12, 11);
            this.groupBoxPhysicalExaminations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPhysicalExaminations.Name = "groupBoxPhysicalExaminations";
            this.groupBoxPhysicalExaminations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPhysicalExaminations.Size = new System.Drawing.Size(254, 412);
            this.groupBoxPhysicalExaminations.TabIndex = 25;
            this.groupBoxPhysicalExaminations.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "Chooose test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(131, 367);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 38);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(15, 367);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(105, 38);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(55, 134);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(144, 17);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Comment for laborant";
            // 
            // textBoxChoosenExamination
            // 
            this.textBoxChoosenExamination.Location = new System.Drawing.Point(62, 100);
            this.textBoxChoosenExamination.Name = "textBoxChoosenExamination";
            this.textBoxChoosenExamination.ReadOnly = true;
            this.textBoxChoosenExamination.Size = new System.Drawing.Size(141, 22);
            this.textBoxChoosenExamination.TabIndex = 5;
            this.textBoxChoosenExamination.Text = "Pomiar ciśnienia";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(5, 154);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(243, 207);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // labelChoosenExamination
            // 
            this.labelChoosenExamination.AutoSize = true;
            this.labelChoosenExamination.Location = new System.Drawing.Point(59, 80);
            this.labelChoosenExamination.Name = "labelChoosenExamination";
            this.labelChoosenExamination.Size = new System.Drawing.Size(91, 17);
            this.labelChoosenExamination.TabIndex = 4;
            this.labelChoosenExamination.Text = "Choosen test";
            // 
            // FormDoctorLabTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 450);
            this.Controls.Add(this.groupBoxPhysicalExaminations);
            this.Name = "FormDoctorLabTest";
            this.Text = "FormDoctorLabTest";
            this.groupBoxPhysicalExaminations.ResumeLayout(false);
            this.groupBoxPhysicalExaminations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPhysicalExaminations;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxChoosenExamination;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelChoosenExamination;
    }
}