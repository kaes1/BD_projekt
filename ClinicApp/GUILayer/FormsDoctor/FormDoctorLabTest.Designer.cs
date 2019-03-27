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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProcedureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcedureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSearchByName = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelComment = new System.Windows.Forms.Label();
            this.textBoxChoosenExamination = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelChoosenTest = new System.Windows.Forms.Label();
            this.groupBoxPhysicalExaminations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPhysicalExaminations
            // 
            this.groupBoxPhysicalExaminations.Controls.Add(this.label1);
            this.groupBoxPhysicalExaminations.Controls.Add(this.textBox2);
            this.groupBoxPhysicalExaminations.Controls.Add(this.dataGridView1);
            this.groupBoxPhysicalExaminations.Controls.Add(this.labelSearchByName);
            this.groupBoxPhysicalExaminations.Controls.Add(this.buttonCancel);
            this.groupBoxPhysicalExaminations.Controls.Add(this.buttonConfirm);
            this.groupBoxPhysicalExaminations.Controls.Add(this.textBox1);
            this.groupBoxPhysicalExaminations.Controls.Add(this.labelComment);
            this.groupBoxPhysicalExaminations.Controls.Add(this.textBoxChoosenExamination);
            this.groupBoxPhysicalExaminations.Controls.Add(this.richTextBox1);
            this.groupBoxPhysicalExaminations.Controls.Add(this.labelChoosenTest);
            this.groupBoxPhysicalExaminations.Location = new System.Drawing.Point(12, 11);
            this.groupBoxPhysicalExaminations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPhysicalExaminations.Name = "groupBoxPhysicalExaminations";
            this.groupBoxPhysicalExaminations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPhysicalExaminations.Size = new System.Drawing.Size(583, 410);
            this.groupBoxPhysicalExaminations.TabIndex = 25;
            this.groupBoxPhysicalExaminations.TabStop = false;
            this.groupBoxPhysicalExaminations.Text = "Lab Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Search by ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(165, 56);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 22);
            this.textBox2.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProcedureID,
            this.ProcedureName});
            this.dataGridView1.Location = new System.Drawing.Point(18, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(280, 301);
            this.dataGridView1.TabIndex = 22;
            // 
            // ProcedureID
            // 
            this.ProcedureID.HeaderText = "Procedure ID";
            this.ProcedureID.Name = "ProcedureID";
            this.ProcedureID.ReadOnly = true;
            // 
            // ProcedureName
            // 
            this.ProcedureName.HeaderText = "Procedure Name";
            this.ProcedureName.Name = "ProcedureName";
            this.ProcedureName.ReadOnly = true;
            // 
            // labelSearchByName
            // 
            this.labelSearchByName.AutoSize = true;
            this.labelSearchByName.Location = new System.Drawing.Point(18, 34);
            this.labelSearchByName.Name = "labelSearchByName";
            this.labelSearchByName.Size = new System.Drawing.Size(113, 17);
            this.labelSearchByName.TabIndex = 21;
            this.labelSearchByName.Text = "Search by Name";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(454, 302);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(105, 38);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(343, 302);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(105, 38);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 56);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 22);
            this.textBox1.TabIndex = 0;
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(424, 100);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(67, 17);
            this.labelComment.TabIndex = 1;
            this.labelComment.Text = "Comment";
            // 
            // textBoxChoosenExamination
            // 
            this.textBoxChoosenExamination.Location = new System.Drawing.Point(382, 54);
            this.textBoxChoosenExamination.Name = "textBoxChoosenExamination";
            this.textBoxChoosenExamination.ReadOnly = true;
            this.textBoxChoosenExamination.Size = new System.Drawing.Size(141, 22);
            this.textBoxChoosenExamination.TabIndex = 5;
            this.textBoxChoosenExamination.Text = "Pomiar ciśnienia";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(329, 120);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(243, 153);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // labelChoosenTest
            // 
            this.labelChoosenTest.AutoSize = true;
            this.labelChoosenTest.Location = new System.Drawing.Point(395, 34);
            this.labelChoosenTest.Name = "labelChoosenTest";
            this.labelChoosenTest.Size = new System.Drawing.Size(96, 17);
            this.labelChoosenTest.TabIndex = 4;
            this.labelChoosenTest.Text = "Choosen Test";
            // 
            // FormDoctorLabTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxPhysicalExaminations);
            this.Name = "FormDoctorLabTest";
            this.Text = "FormDoctorLabTest";
            this.groupBoxPhysicalExaminations.ResumeLayout(false);
            this.groupBoxPhysicalExaminations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPhysicalExaminations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcedureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcedureName;
        private System.Windows.Forms.Label labelSearchByName;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.TextBox textBoxChoosenExamination;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelChoosenTest;
    }
}