namespace GUILayer.FormsDoctor
{
    partial class FormDoctorAppCancelled
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
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.richTextBoxReason = new System.Windows.Forms.RichTextBox();
            this.labelCancellation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(28, 209);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(109, 209);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // richTextBoxReason
            // 
            this.richTextBoxReason.Location = new System.Drawing.Point(15, 29);
            this.richTextBoxReason.Name = "richTextBoxReason";
            this.richTextBoxReason.Size = new System.Drawing.Size(179, 161);
            this.richTextBoxReason.TabIndex = 2;
            this.richTextBoxReason.Text = "";
            // 
            // labelCancellation
            // 
            this.labelCancellation.AutoSize = true;
            this.labelCancellation.Location = new System.Drawing.Point(25, 9);
            this.labelCancellation.Name = "labelCancellation";
            this.labelCancellation.Size = new System.Drawing.Size(152, 17);
            this.labelCancellation.TabIndex = 3;
            this.labelCancellation.Text = "Reason of cancellation";
            // 
            // FormDoctorAppCancelled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 261);
            this.Controls.Add(this.labelCancellation);
            this.Controls.Add(this.richTextBoxReason);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.Name = "FormDoctorAppCancelled";
            this.Text = "FormDoctorAppCancelled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RichTextBox richTextBoxReason;
        private System.Windows.Forms.Label labelCancellation;
    }
}