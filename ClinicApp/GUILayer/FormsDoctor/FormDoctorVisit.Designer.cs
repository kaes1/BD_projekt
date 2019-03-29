namespace GUILayer
{
    partial class FormDoctorVisit
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
            this.buttonPreviousVisit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonEndVisit = new System.Windows.Forms.Button();
            this.buttonCancelVisit = new System.Windows.Forms.Button();
            this.labelFisrtName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.buttonNextVisit = new System.Windows.Forms.Button();
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.DateOfPreviousVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBoxOldDescription = new System.Windows.Forms.RichTextBox();
            this.labelOldDescription = new System.Windows.Forms.Label();
            this.richTextBoxNewDescription = new System.Windows.Forms.RichTextBox();
            this.labelNewDescription = new System.Windows.Forms.Label();
            this.dataGridViewExaminationsList = new System.Windows.Forms.DataGridView();
            this.LabTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddLabTest = new System.Windows.Forms.Button();
            this.groupBoxLabTestsList = new System.Windows.Forms.GroupBox();
            this.buttonEditLabTest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.groupBoxPreviousComments = new System.Windows.Forms.GroupBox();
            this.groupBoxOldTests = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateOfTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcedureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPreviousTest = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonNextTest = new System.Windows.Forms.Button();
            this.groupBoxPhysicalExaminations = new System.Windows.Forms.GroupBox();
            this.buttonEditPhysExamination = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.buttonAddPhysExamination = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.PhysicalExamination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExaminationsList)).BeginInit();
            this.groupBoxLabTestsList.SuspendLayout();
            this.groupBoxPatient.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.groupBoxPreviousComments.SuspendLayout();
            this.groupBoxOldTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxPhysicalExaminations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPreviousVisit
            // 
            this.buttonPreviousVisit.Location = new System.Drawing.Point(193, 272);
            this.buttonPreviousVisit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPreviousVisit.Name = "buttonPreviousVisit";
            this.buttonPreviousVisit.Size = new System.Drawing.Size(86, 19);
            this.buttonPreviousVisit.TabIndex = 0;
            this.buttonPreviousVisit.Text = "Previous Visit";
            this.buttonPreviousVisit.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(4, 116);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(138, 33);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEndVisit
            // 
            this.buttonEndVisit.Location = new System.Drawing.Point(4, 16);
            this.buttonEndVisit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEndVisit.Name = "buttonEndVisit";
            this.buttonEndVisit.Size = new System.Drawing.Size(138, 34);
            this.buttonEndVisit.TabIndex = 2;
            this.buttonEndVisit.Text = "End Visit";
            this.buttonEndVisit.UseVisualStyleBackColor = true;
            // 
            // buttonCancelVisit
            // 
            this.buttonCancelVisit.Location = new System.Drawing.Point(4, 68);
            this.buttonCancelVisit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelVisit.Name = "buttonCancelVisit";
            this.buttonCancelVisit.Size = new System.Drawing.Size(138, 33);
            this.buttonCancelVisit.TabIndex = 3;
            this.buttonCancelVisit.Text = "Cancel Visit";
            this.buttonCancelVisit.UseVisualStyleBackColor = true;
            // 
            // labelFisrtName
            // 
            this.labelFisrtName.AutoSize = true;
            this.labelFisrtName.Location = new System.Drawing.Point(4, 21);
            this.labelFisrtName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFisrtName.Name = "labelFisrtName";
            this.labelFisrtName.Size = new System.Drawing.Size(57, 13);
            this.labelFisrtName.TabIndex = 4;
            this.labelFisrtName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(111, 21);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name";
            // 
            // buttonNextVisit
            // 
            this.buttonNextVisit.Location = new System.Drawing.Point(284, 272);
            this.buttonNextVisit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNextVisit.Name = "buttonNextVisit";
            this.buttonNextVisit.Size = new System.Drawing.Size(86, 19);
            this.buttonNextVisit.TabIndex = 6;
            this.buttonNextVisit.Text = "Next Visit";
            this.buttonNextVisit.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.AllowUserToAddRows = false;
            this.dataGridViewVisits.AllowUserToDeleteRows = false;
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateOfPreviousVisits});
            this.dataGridViewVisits.Location = new System.Drawing.Point(13, 17);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.ReadOnly = true;
            this.dataGridViewVisits.Size = new System.Drawing.Size(116, 274);
            this.dataGridViewVisits.TabIndex = 10;
            // 
            // DateOfPreviousVisits
            // 
            this.DateOfPreviousVisits.HeaderText = "Date Of Previous Visits";
            this.DateOfPreviousVisits.Name = "DateOfPreviousVisits";
            this.DateOfPreviousVisits.ReadOnly = true;
            // 
            // richTextBoxOldDescription
            // 
            this.richTextBoxOldDescription.Location = new System.Drawing.Point(141, 88);
            this.richTextBoxOldDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxOldDescription.Name = "richTextBoxOldDescription";
            this.richTextBoxOldDescription.ReadOnly = true;
            this.richTextBoxOldDescription.Size = new System.Drawing.Size(284, 175);
            this.richTextBoxOldDescription.TabIndex = 11;
            this.richTextBoxOldDescription.Text = "Pacjent skarży się na bóle głowe.\nWykonano badania fizykalne. Zlecono badanie krw" +
    "i.";
            // 
            // labelOldDescription
            // 
            this.labelOldDescription.AutoSize = true;
            this.labelOldDescription.Location = new System.Drawing.Point(139, 72);
            this.labelOldDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelOldDescription.Name = "labelOldDescription";
            this.labelOldDescription.Size = new System.Drawing.Size(79, 13);
            this.labelOldDescription.TabIndex = 12;
            this.labelOldDescription.Text = "Old Description";
            // 
            // richTextBoxNewDescription
            // 
            this.richTextBoxNewDescription.Location = new System.Drawing.Point(468, 98);
            this.richTextBoxNewDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBoxNewDescription.Name = "richTextBoxNewDescription";
            this.richTextBoxNewDescription.Size = new System.Drawing.Size(284, 175);
            this.richTextBoxNewDescription.TabIndex = 14;
            this.richTextBoxNewDescription.Text = "";
            // 
            // labelNewDescription
            // 
            this.labelNewDescription.AutoSize = true;
            this.labelNewDescription.Location = new System.Drawing.Point(466, 82);
            this.labelNewDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNewDescription.Name = "labelNewDescription";
            this.labelNewDescription.Size = new System.Drawing.Size(85, 13);
            this.labelNewDescription.TabIndex = 15;
            this.labelNewDescription.Text = "New Description";
            // 
            // dataGridViewExaminationsList
            // 
            this.dataGridViewExaminationsList.AllowUserToAddRows = false;
            this.dataGridViewExaminationsList.AllowUserToDeleteRows = false;
            this.dataGridViewExaminationsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExaminationsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LabTest});
            this.dataGridViewExaminationsList.Location = new System.Drawing.Point(5, 18);
            this.dataGridViewExaminationsList.Name = "dataGridViewExaminationsList";
            this.dataGridViewExaminationsList.ReadOnly = true;
            this.dataGridViewExaminationsList.Size = new System.Drawing.Size(121, 235);
            this.dataGridViewExaminationsList.TabIndex = 16;
            // 
            // LabTest
            // 
            this.LabTest.HeaderText = "Lab Test";
            this.LabTest.Name = "LabTest";
            this.LabTest.ReadOnly = true;
            // 
            // buttonAddLabTest
            // 
            this.buttonAddLabTest.Location = new System.Drawing.Point(162, 177);
            this.buttonAddLabTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddLabTest.Name = "buttonAddLabTest";
            this.buttonAddLabTest.Size = new System.Drawing.Size(77, 20);
            this.buttonAddLabTest.TabIndex = 17;
            this.buttonAddLabTest.Text = "Add Test";
            this.buttonAddLabTest.UseVisualStyleBackColor = true;
            this.buttonAddLabTest.Click += new System.EventHandler(this.buttonAddLabTest_Click);
            // 
            // groupBoxLabTestsList
            // 
            this.groupBoxLabTestsList.Controls.Add(this.buttonEditLabTest);
            this.groupBoxLabTestsList.Controls.Add(this.label3);
            this.groupBoxLabTestsList.Controls.Add(this.richTextBox3);
            this.groupBoxLabTestsList.Controls.Add(this.buttonAddLabTest);
            this.groupBoxLabTestsList.Controls.Add(this.dataGridViewExaminationsList);
            this.groupBoxLabTestsList.Location = new System.Drawing.Point(775, 318);
            this.groupBoxLabTestsList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLabTestsList.Name = "groupBoxLabTestsList";
            this.groupBoxLabTestsList.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxLabTestsList.Size = new System.Drawing.Size(279, 258);
            this.groupBoxLabTestsList.TabIndex = 18;
            this.groupBoxLabTestsList.TabStop = false;
            this.groupBoxLabTestsList.Text = "Lab Tests List";
            // 
            // buttonEditLabTest
            // 
            this.buttonEditLabTest.Location = new System.Drawing.Point(162, 205);
            this.buttonEditLabTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditLabTest.Name = "buttonEditLabTest";
            this.buttonEditLabTest.Size = new System.Drawing.Size(77, 20);
            this.buttonEditLabTest.TabIndex = 24;
            this.buttonEditLabTest.Text = "Edit Test";
            this.buttonEditLabTest.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Comment to laboratory";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(131, 32);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(139, 133);
            this.richTextBox3.TabIndex = 21;
            this.richTextBox3.Text = "";
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.textBoxLastName);
            this.groupBoxPatient.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatient.Controls.Add(this.labelFisrtName);
            this.groupBoxPatient.Controls.Add(this.labelLastName);
            this.groupBoxPatient.Location = new System.Drawing.Point(468, 10);
            this.groupBoxPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPatient.Size = new System.Drawing.Size(218, 66);
            this.groupBoxPatient.TabIndex = 19;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(113, 37);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(101, 20);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(7, 37);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(103, 20);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonBack);
            this.groupBoxControls.Controls.Add(this.buttonEndVisit);
            this.groupBoxControls.Controls.Add(this.buttonCancelVisit);
            this.groupBoxControls.Location = new System.Drawing.Point(849, 82);
            this.groupBoxControls.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxControls.Size = new System.Drawing.Size(147, 163);
            this.groupBoxControls.TabIndex = 20;
            this.groupBoxControls.TabStop = false;
            // 
            // groupBoxPreviousComments
            // 
            this.groupBoxPreviousComments.Controls.Add(this.labelOldDescription);
            this.groupBoxPreviousComments.Controls.Add(this.buttonPreviousVisit);
            this.groupBoxPreviousComments.Controls.Add(this.buttonNextVisit);
            this.groupBoxPreviousComments.Controls.Add(this.richTextBoxOldDescription);
            this.groupBoxPreviousComments.Controls.Add(this.dataGridViewVisits);
            this.groupBoxPreviousComments.Location = new System.Drawing.Point(9, 10);
            this.groupBoxPreviousComments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPreviousComments.Name = "groupBoxPreviousComments";
            this.groupBoxPreviousComments.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPreviousComments.Size = new System.Drawing.Size(436, 301);
            this.groupBoxPreviousComments.TabIndex = 21;
            this.groupBoxPreviousComments.TabStop = false;
            this.groupBoxPreviousComments.Text = "Old Visits";
            // 
            // groupBoxOldTests
            // 
            this.groupBoxOldTests.Controls.Add(this.label1);
            this.groupBoxOldTests.Controls.Add(this.dataGridView1);
            this.groupBoxOldTests.Controls.Add(this.buttonPreviousTest);
            this.groupBoxOldTests.Controls.Add(this.richTextBox1);
            this.groupBoxOldTests.Controls.Add(this.buttonNextTest);
            this.groupBoxOldTests.Location = new System.Drawing.Point(9, 318);
            this.groupBoxOldTests.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOldTests.Name = "groupBoxOldTests";
            this.groupBoxOldTests.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOldTests.Size = new System.Drawing.Size(436, 258);
            this.groupBoxOldTests.TabIndex = 22;
            this.groupBoxOldTests.TabStop = false;
            this.groupBoxOldTests.Text = "Old Tests";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Result";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateOfTest,
            this.ProcedureName,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(13, 17);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(256, 236);
            this.dataGridView1.TabIndex = 0;
            // 
            // DateOfTest
            // 
            this.DateOfTest.HeaderText = "Date Of Test";
            this.DateOfTest.Name = "DateOfTest";
            this.DateOfTest.ReadOnly = true;
            // 
            // ProcedureName
            // 
            this.ProcedureName.HeaderText = "Procedure Name";
            this.ProcedureName.Name = "ProcedureName";
            this.ProcedureName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // buttonPreviousTest
            // 
            this.buttonPreviousTest.Location = new System.Drawing.Point(277, 234);
            this.buttonPreviousTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPreviousTest.Name = "buttonPreviousTest";
            this.buttonPreviousTest.Size = new System.Drawing.Size(77, 19);
            this.buttonPreviousTest.TabIndex = 23;
            this.buttonPreviousTest.Text = "Previous Test";
            this.buttonPreviousTest.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(284, 50);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(141, 175);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "Krwinki czerwone 1.1/L\nKrwinki białe 0.2/L\nOsocze 300g/L";
            // 
            // buttonNextTest
            // 
            this.buttonNextTest.Location = new System.Drawing.Point(358, 234);
            this.buttonNextTest.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNextTest.Name = "buttonNextTest";
            this.buttonNextTest.Size = new System.Drawing.Size(77, 19);
            this.buttonNextTest.TabIndex = 24;
            this.buttonNextTest.Text = "Next Test";
            this.buttonNextTest.UseVisualStyleBackColor = true;
            // 
            // groupBoxPhysicalExaminations
            // 
            this.groupBoxPhysicalExaminations.Controls.Add(this.buttonEditPhysExamination);
            this.groupBoxPhysicalExaminations.Controls.Add(this.label2);
            this.groupBoxPhysicalExaminations.Controls.Add(this.richTextBox2);
            this.groupBoxPhysicalExaminations.Controls.Add(this.buttonAddPhysExamination);
            this.groupBoxPhysicalExaminations.Controls.Add(this.dataGridView2);
            this.groupBoxPhysicalExaminations.Location = new System.Drawing.Point(468, 318);
            this.groupBoxPhysicalExaminations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPhysicalExaminations.Name = "groupBoxPhysicalExaminations";
            this.groupBoxPhysicalExaminations.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxPhysicalExaminations.Size = new System.Drawing.Size(283, 258);
            this.groupBoxPhysicalExaminations.TabIndex = 23;
            this.groupBoxPhysicalExaminations.TabStop = false;
            this.groupBoxPhysicalExaminations.Text = "Physical Examinations";
            // 
            // buttonEditPhysExamination
            // 
            this.buttonEditPhysExamination.Location = new System.Drawing.Point(140, 219);
            this.buttonEditPhysExamination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonEditPhysExamination.Name = "buttonEditPhysExamination";
            this.buttonEditPhysExamination.Size = new System.Drawing.Size(133, 33);
            this.buttonEditPhysExamination.TabIndex = 24;
            this.buttonEditPhysExamination.Text = "Edit Examination";
            this.buttonEditPhysExamination.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Result";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(140, 32);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(134, 133);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "";
            // 
            // buttonAddPhysExamination
            // 
            this.buttonAddPhysExamination.Location = new System.Drawing.Point(140, 171);
            this.buttonAddPhysExamination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAddPhysExamination.Name = "buttonAddPhysExamination";
            this.buttonAddPhysExamination.Size = new System.Drawing.Size(133, 33);
            this.buttonAddPhysExamination.TabIndex = 17;
            this.buttonAddPhysExamination.Text = "Add Examination";
            this.buttonAddPhysExamination.UseVisualStyleBackColor = true;
            this.buttonAddPhysExamination.Click += new System.EventHandler(this.buttonAddPhysExamination_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhysicalExamination});
            this.dataGridView2.Location = new System.Drawing.Point(5, 18);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(121, 235);
            this.dataGridView2.TabIndex = 16;
            // 
            // PhysicalExamination
            // 
            this.PhysicalExamination.HeaderText = "Physical Examination";
            this.PhysicalExamination.Name = "PhysicalExamination";
            this.PhysicalExamination.ReadOnly = true;
            // 
            // FormDoctorVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 586);
            this.Controls.Add(this.groupBoxPhysicalExaminations);
            this.Controls.Add(this.groupBoxOldTests);
            this.Controls.Add(this.groupBoxPreviousComments);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.groupBoxLabTestsList);
            this.Controls.Add(this.labelNewDescription);
            this.Controls.Add(this.richTextBoxNewDescription);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDoctorVisit";
            this.Text = "FormDoctorVisit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExaminationsList)).EndInit();
            this.groupBoxLabTestsList.ResumeLayout(false);
            this.groupBoxLabTestsList.PerformLayout();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.groupBoxControls.ResumeLayout(false);
            this.groupBoxPreviousComments.ResumeLayout(false);
            this.groupBoxPreviousComments.PerformLayout();
            this.groupBoxOldTests.ResumeLayout(false);
            this.groupBoxOldTests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxPhysicalExaminations.ResumeLayout(false);
            this.groupBoxPhysicalExaminations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPreviousVisit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonEndVisit;
        private System.Windows.Forms.Button buttonCancelVisit;
        private System.Windows.Forms.Label labelFisrtName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Button buttonNextVisit;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private System.Windows.Forms.RichTextBox richTextBoxOldDescription;
        private System.Windows.Forms.Label labelOldDescription;
        private System.Windows.Forms.RichTextBox richTextBoxNewDescription;
        private System.Windows.Forms.Label labelNewDescription;
        private System.Windows.Forms.DataGridView dataGridViewExaminationsList;
        private System.Windows.Forms.Button buttonAddLabTest;
        private System.Windows.Forms.GroupBox groupBoxLabTestsList;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.GroupBox groupBoxPreviousComments;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPreviousVisits;
        private System.Windows.Forms.GroupBox groupBoxOldTests;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcedureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPreviousTest;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonNextTest;
        private System.Windows.Forms.GroupBox groupBoxPhysicalExaminations;
        private System.Windows.Forms.Button buttonAddPhysExamination;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabTest;
        private System.Windows.Forms.Button buttonEditLabTest;
        private System.Windows.Forms.Button buttonEditPhysExamination;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhysicalExamination;
    }
}