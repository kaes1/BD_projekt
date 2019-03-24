namespace GUILayer
{
    partial class FormReceptionist
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
            this.buttonNewPatient = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.buttonViewAllPatients = new System.Windows.Forms.Button();
            this.labelLoggedInAs = new System.Windows.Forms.Label();
            this.labelReceptionistName = new System.Windows.Forms.Label();
            this.buttonRegisterVisit = new System.Windows.Forms.Button();
            this.labelPanelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewPatient
            // 
            this.buttonNewPatient.Location = new System.Drawing.Point(489, 237);
            this.buttonNewPatient.Name = "buttonNewPatient";
            this.buttonNewPatient.Size = new System.Drawing.Size(105, 23);
            this.buttonNewPatient.TabIndex = 0;
            this.buttonNewPatient.Text = "New Patient";
            this.buttonNewPatient.UseVisualStyleBackColor = true;
            this.buttonNewPatient.Click += new System.EventHandler(this.buttonNewPatient_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.PESEL});
            this.dataGridViewPatients.Location = new System.Drawing.Point(29, 194);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.Size = new System.Drawing.Size(415, 230);
            this.dataGridViewPatients.TabIndex = 1;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 124;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 124;
            // 
            // PESEL
            // 
            this.PESEL.HeaderText = "PESEL";
            this.PESEL.Name = "PESEL";
            this.PESEL.ReadOnly = true;
            this.PESEL.Width = 124;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(477, 56);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(105, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.labelPESEL);
            this.groupBoxSearch.Controls.Add(this.labelLastName);
            this.groupBoxSearch.Controls.Add(this.labelFirstName);
            this.groupBoxSearch.Controls.Add(this.textBoxPESEL);
            this.groupBoxSearch.Controls.Add(this.textBoxLastName);
            this.groupBoxSearch.Controls.Add(this.textBoxFirstName);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 60);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(630, 114);
            this.groupBoxSearch.TabIndex = 3;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(311, 40);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(41, 13);
            this.labelPESEL.TabIndex = 8;
            this.labelPESEL.Text = "PESEL";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(177, 40);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 7;
            this.labelLastName.Text = "Last Name";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(41, 40);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 6;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(314, 56);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPESEL.TabIndex = 5;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(180, 56);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 4;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(44, 56);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // buttonViewAllPatients
            // 
            this.buttonViewAllPatients.Location = new System.Drawing.Point(489, 277);
            this.buttonViewAllPatients.Name = "buttonViewAllPatients";
            this.buttonViewAllPatients.Size = new System.Drawing.Size(105, 23);
            this.buttonViewAllPatients.TabIndex = 4;
            this.buttonViewAllPatients.Text = "View all";
            this.buttonViewAllPatients.UseVisualStyleBackColor = true;
            this.buttonViewAllPatients.Click += new System.EventHandler(this.buttonViewAllPatients_Click);
            // 
            // labelLoggedInAs
            // 
            this.labelLoggedInAs.AutoSize = true;
            this.labelLoggedInAs.Location = new System.Drawing.Point(506, 377);
            this.labelLoggedInAs.Name = "labelLoggedInAs";
            this.labelLoggedInAs.Size = new System.Drawing.Size(73, 13);
            this.labelLoggedInAs.TabIndex = 5;
            this.labelLoggedInAs.Text = "Logged In As:";
            // 
            // labelReceptionistName
            // 
            this.labelReceptionistName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelReceptionistName.Location = new System.Drawing.Point(445, 411);
            this.labelReceptionistName.Name = "labelReceptionistName";
            this.labelReceptionistName.Size = new System.Drawing.Size(195, 13);
            this.labelReceptionistName.TabIndex = 6;
            this.labelReceptionistName.Text = "Name Surname";
            this.labelReceptionistName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRegisterVisit
            // 
            this.buttonRegisterVisit.Location = new System.Drawing.Point(489, 320);
            this.buttonRegisterVisit.Name = "buttonRegisterVisit";
            this.buttonRegisterVisit.Size = new System.Drawing.Size(105, 23);
            this.buttonRegisterVisit.TabIndex = 7;
            this.buttonRegisterVisit.Text = "Register Visit";
            this.buttonRegisterVisit.UseVisualStyleBackColor = true;
            this.buttonRegisterVisit.Click += new System.EventHandler(this.buttonRegisterVisit_Click);
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(143, 9);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(363, 48);
            this.labelPanelName.TabIndex = 8;
            this.labelPanelName.Text = "Receptionist Panel";
            // 
            // FormReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 450);
            this.Controls.Add(this.labelPanelName);
            this.Controls.Add(this.buttonRegisterVisit);
            this.Controls.Add(this.labelReceptionistName);
            this.Controls.Add(this.labelLoggedInAs);
            this.Controls.Add(this.buttonViewAllPatients);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.dataGridViewPatients);
            this.Controls.Add(this.buttonNewPatient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormReceptionist";
            this.Text = "FormReceptionist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNewPatient;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Button buttonViewAllPatients;
        private System.Windows.Forms.Label labelLoggedInAs;
        private System.Windows.Forms.Label labelReceptionistName;
        private System.Windows.Forms.Button buttonRegisterVisit;
        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESEL;
    }
}