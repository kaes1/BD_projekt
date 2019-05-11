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
            this.labelSearchByName = new System.Windows.Forms.Label();
            this.textBoxExamName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExamList)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(235, 396);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(110, 28);
            this.buttonBack.TabIndex = 38;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(9, 395);
            this.buttonAccept.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(110, 28);
            this.buttonAccept.TabIndex = 37;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // labelSearchByID
            // 
            this.labelSearchByID.AutoSize = true;
            this.labelSearchByID.Location = new System.Drawing.Point(42, 9);
            this.labelSearchByID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchByID.Name = "labelSearchByID";
            this.labelSearchByID.Size = new System.Drawing.Size(83, 13);
            this.labelSearchByID.TabIndex = 36;
            this.labelSearchByID.Text = "Search by Code";
            // 
            // textBoxExamID
            // 
            this.textBoxExamID.Location = new System.Drawing.Point(47, 24);
            this.textBoxExamID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxExamID.Name = "textBoxExamID";
            this.textBoxExamID.Size = new System.Drawing.Size(108, 20);
            this.textBoxExamID.TabIndex = 35;
            this.textBoxExamID.TextChanged += new System.EventHandler(this.textBoxExamID_TextChanged);
            // 
            // dataGridViewExamList
            // 
            this.dataGridViewExamList.AllowUserToAddRows = false;
            this.dataGridViewExamList.AllowUserToDeleteRows = false;
            this.dataGridViewExamList.AllowUserToOrderColumns = true;
            this.dataGridViewExamList.AllowUserToResizeColumns = false;
            this.dataGridViewExamList.AllowUserToResizeRows = false;
            this.dataGridViewExamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExamList.Location = new System.Drawing.Point(9, 58);
            this.dataGridViewExamList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewExamList.MultiSelect = false;
            this.dataGridViewExamList.Name = "dataGridViewExamList";
            this.dataGridViewExamList.ReadOnly = true;
            this.dataGridViewExamList.RowTemplate.Height = 24;
            this.dataGridViewExamList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewExamList.Size = new System.Drawing.Size(336, 325);
            this.dataGridViewExamList.TabIndex = 34;
            // 
            // labelSearchByName
            // 
            this.labelSearchByName.AutoSize = true;
            this.labelSearchByName.Location = new System.Drawing.Point(189, 9);
            this.labelSearchByName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSearchByName.Name = "labelSearchByName";
            this.labelSearchByName.Size = new System.Drawing.Size(86, 13);
            this.labelSearchByName.TabIndex = 33;
            this.labelSearchByName.Text = "Search by Name";
            // 
            // textBoxExamName
            // 
            this.textBoxExamName.Location = new System.Drawing.Point(192, 24);
            this.textBoxExamName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxExamName.Name = "textBoxExamName";
            this.textBoxExamName.Size = new System.Drawing.Size(120, 20);
            this.textBoxExamName.TabIndex = 32;
            this.textBoxExamName.TextChanged += new System.EventHandler(this.textBoxExamName_TextChanged);
            // 
            // FormDoctorExamList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 433);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.labelSearchByID);
            this.Controls.Add(this.textBoxExamID);
            this.Controls.Add(this.dataGridViewExamList);
            this.Controls.Add(this.labelSearchByName);
            this.Controls.Add(this.textBoxExamName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDoctorExamList";
            this.Text = "ExamList";
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
        private System.Windows.Forms.Label labelSearchByName;
        private System.Windows.Forms.TextBox textBoxExamName;
    }
}