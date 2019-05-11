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
            this.buttonAccept.Location = new System.Drawing.Point(11, 169);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(85, 20);
            this.buttonAccept.TabIndex = 0;
            this.buttonAccept.Text = "Confirm";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(155, 169);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(85, 20);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Back";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // richTextBoxReason
            // 
            this.richTextBoxReason.Location = new System.Drawing.Point(11, 24);
            this.richTextBoxReason.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxReason.Name = "richTextBoxReason";
            this.richTextBoxReason.Size = new System.Drawing.Size(229, 132);
            this.richTextBoxReason.TabIndex = 2;
            this.richTextBoxReason.Text = "";
            // 
            // labelCancellation
            // 
            this.labelCancellation.AutoSize = true;
            this.labelCancellation.Location = new System.Drawing.Point(67, 6);
            this.labelCancellation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCancellation.Name = "labelCancellation";
            this.labelCancellation.Size = new System.Drawing.Size(119, 13);
            this.labelCancellation.TabIndex = 3;
            this.labelCancellation.Text = "Reason of cancellation:";
            // 
            // FormDoctorAppCancelled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 200);
            this.Controls.Add(this.labelCancellation);
            this.Controls.Add(this.richTextBoxReason);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDoctorAppCancelled";
            this.Text = "Cancel Appointment";
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