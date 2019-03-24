namespace GUILayer
{
    partial class FormReceptionistNewAppointment
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
            this.buttonAddAppointment = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelPanelName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.Location = new System.Drawing.Point(38, 316);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(110, 23);
            this.buttonAddAppointment.TabIndex = 0;
            this.buttonAddAppointment.Text = "Add Appointment";
            this.buttonAddAppointment.UseVisualStyleBackColor = true;
            this.buttonAddAppointment.Click += new System.EventHandler(this.buttonAddAppointment_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(306, 316);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(110, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(72, 21);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(344, 37);
            this.labelPanelName.TabIndex = 2;
            this.labelPanelName.Text = "Add New Appointment";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(35, 107);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(167, 107);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(303, 107);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(41, 13);
            this.labelPESEL.TabIndex = 5;
            this.labelPESEL.Text = "PESEL";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(38, 123);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(170, 123);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 7;
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(306, 123);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.ReadOnly = true;
            this.textBoxPESEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPESEL.TabIndex = 8;
            // 
            // FormReceptionistNewAppointment
            // 
            this.AcceptButton = this.buttonAddAppointment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(493, 387);
            this.Controls.Add(this.textBoxPESEL);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelPESEL);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelPanelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormReceptionistNewAppointment";
            this.Text = "FormReceptionistNewAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPESEL;
    }
}