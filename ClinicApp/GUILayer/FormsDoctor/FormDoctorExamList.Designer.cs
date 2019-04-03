namespace GUILayer.FormsDoctor
{
    partial class FormDoctorExamList
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.labelSearchByID = new System.Windows.Forms.Label();
            this.textBoxExamID = new System.Windows.Forms.TextBox();
            this.dataGridViewExamList = new System.Windows.Forms.DataGridView();
            this.ProcedureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcedureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSearchByName = new System.Windows.Forms.Label();
            this.textBoxExamName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(187, 491);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(109, 35);
            this.buttonBack.TabIndex = 38;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(67, 491);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(109, 35);
            this.buttonAccept.TabIndex = 37;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // labelSearchByID
            // 
            this.labelSearchByID.AutoSize = true;
            this.labelSearchByID.Location = new System.Drawing.Point(182, 12);
            this.labelSearchByID.Name = "labelSearchByID";
            this.labelSearchByID.Size = new System.Drawing.Size(89, 17);
            this.labelSearchByID.TabIndex = 36;
            this.labelSearchByID.Text = "Search by ID";
            // 
            // textBoxExamID
            // 
            this.textBoxExamID.Location = new System.Drawing.Point(182, 34);
            this.textBoxExamID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExamID.Name = "textBoxExamID";
            this.textBoxExamID.Size = new System.Drawing.Size(133, 22);
            this.textBoxExamID.TabIndex = 35;
            this.textBoxExamID.TextChanged += new System.EventHandler(this.textBoxExamID_TextChanged);
            // 
            // dataGridViewExamList
            // 
            this.dataGridViewExamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcedureID,
            this.ProcedureName});
            this.dataGridViewExamList.Location = new System.Drawing.Point(12, 71);
            this.dataGridViewExamList.Name = "dataGridViewExamList";
            this.dataGridViewExamList.RowTemplate.Height = 24;
            this.dataGridViewExamList.Size = new System.Drawing.Size(342, 414);
            this.dataGridViewExamList.TabIndex = 34;
            // 
            // ProcedureID
            // 
            this.ProcedureID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProcedureID.HeaderText = "Procedure ID";
            this.ProcedureID.Name = "ProcedureID";
            this.ProcedureID.ReadOnly = true;
            // 
            // ProcedureName
            // 
            this.ProcedureName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProcedureName.HeaderText = "Procedure name";
            this.ProcedureName.Name = "ProcedureName";
            this.ProcedureName.ReadOnly = true;
            // 
            // labelSearchByName
            // 
            this.labelSearchByName.AutoSize = true;
            this.labelSearchByName.Location = new System.Drawing.Point(35, 12);
            this.labelSearchByName.Name = "labelSearchByName";
            this.labelSearchByName.Size = new System.Drawing.Size(113, 17);
            this.labelSearchByName.TabIndex = 33;
            this.labelSearchByName.Text = "Search by Name";
            // 
            // textBoxExamName
            // 
            this.textBoxExamName.Location = new System.Drawing.Point(35, 34);
            this.textBoxExamName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxExamName.Name = "textBoxExamName";
            this.textBoxExamName.Size = new System.Drawing.Size(141, 22);
            this.textBoxExamName.TabIndex = 32;
            this.textBoxExamName.TextChanged += new System.EventHandler(this.textBoxExamName_TextChanged);
            // 
            // FormDoctorExamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 533);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.labelSearchByID);
            this.Controls.Add(this.textBoxExamID);
            this.Controls.Add(this.dataGridViewExamList);
            this.Controls.Add(this.labelSearchByName);
            this.Controls.Add(this.textBoxExamName);
            this.Name = "FormDoctorExamList";
            this.Text = "FormDoctorExamList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label labelSearchByID;
        private System.Windows.Forms.TextBox textBoxExamID;
        private System.Windows.Forms.DataGridView dataGridViewExamList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcedureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcedureName;
        private System.Windows.Forms.Label labelSearchByName;
        private System.Windows.Forms.TextBox textBoxExamName;
    }
}