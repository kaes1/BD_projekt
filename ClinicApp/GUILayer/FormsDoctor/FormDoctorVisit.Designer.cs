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
            this.richTextBoxOldDescription = new System.Windows.Forms.RichTextBox();
            this.labelOldDescription = new System.Windows.Forms.Label();
            this.richTextBoxNewDescription = new System.Windows.Forms.RichTextBox();
            this.labelNewDescription = new System.Windows.Forms.Label();
            this.dataGridViewExaminationsList = new System.Windows.Forms.DataGridView();
            this.buttonAddLabTest = new System.Windows.Forms.Button();
            this.groupBoxLabTestsList = new System.Windows.Forms.GroupBox();
            this.buttonDeleteLabTest = new System.Windows.Forms.Button();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.groupBoxPreviousComments = new System.Windows.Forms.GroupBox();
            this.DateOfPreviousVisits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxOldTests = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateOfTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProcedureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPreviousTest = new System.Windows.Forms.Button();
            this.buttonNextTest = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBoxPhysicalExaminations = new System.Windows.Forms.GroupBox();
            this.buttonAddPhysExamination = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEditLabTest = new System.Windows.Forms.Button();
            this.buttonEditPhysExamination = new System.Windows.Forms.Button();
            this.LabTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.buttonPreviousVisit.Location = new System.Drawing.Point(257, 335);
            this.buttonPreviousVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousVisit.Name = "buttonPreviousVisit";
            this.buttonPreviousVisit.Size = new System.Drawing.Size(115, 23);
            this.buttonPreviousVisit.TabIndex = 0;
            this.buttonPreviousVisit.Text = "Previous Visit";
            this.buttonPreviousVisit.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(6, 143);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(184, 41);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonEndVisit
            // 
            this.buttonEndVisit.Location = new System.Drawing.Point(6, 20);
            this.buttonEndVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEndVisit.Name = "buttonEndVisit";
            this.buttonEndVisit.Size = new System.Drawing.Size(184, 42);
            this.buttonEndVisit.TabIndex = 2;
            this.buttonEndVisit.Text = "End Visit";
            this.buttonEndVisit.UseVisualStyleBackColor = true;
            // 
            // buttonCancelVisit
            // 
            this.buttonCancelVisit.Location = new System.Drawing.Point(6, 84);
            this.buttonCancelVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCancelVisit.Name = "buttonCancelVisit";
            this.buttonCancelVisit.Size = new System.Drawing.Size(184, 41);
            this.buttonCancelVisit.TabIndex = 3;
            this.buttonCancelVisit.Text = "Cancel Visit";
            this.buttonCancelVisit.UseVisualStyleBackColor = true;
            // 
            // labelFisrtName
            // 
            this.labelFisrtName.AutoSize = true;
            this.labelFisrtName.Location = new System.Drawing.Point(5, 26);
            this.labelFisrtName.Name = "labelFisrtName";
            this.labelFisrtName.Size = new System.Drawing.Size(76, 17);
            this.labelFisrtName.TabIndex = 4;
            this.labelFisrtName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(148, 26);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 17);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "Last Name";
            // 
            // buttonNextVisit
            // 
            this.buttonNextVisit.Location = new System.Drawing.Point(379, 335);
            this.buttonNextVisit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextVisit.Name = "buttonNextVisit";
            this.buttonNextVisit.Size = new System.Drawing.Size(115, 23);
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
            this.dataGridViewVisits.Location = new System.Drawing.Point(17, 21);
            this.dataGridViewVisits.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.ReadOnly = true;
            this.dataGridViewVisits.Size = new System.Drawing.Size(154, 337);
            this.dataGridViewVisits.TabIndex = 10;
            // 
            // richTextBoxOldDescription
            // 
            this.richTextBoxOldDescription.Location = new System.Drawing.Point(188, 108);
            this.richTextBoxOldDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxOldDescription.Name = "richTextBoxOldDescription";
            this.richTextBoxOldDescription.ReadOnly = true;
            this.richTextBoxOldDescription.Size = new System.Drawing.Size(377, 214);
            this.richTextBoxOldDescription.TabIndex = 11;
            this.richTextBoxOldDescription.Text = "Pacjent skarży się na bóle głowe.\nWykonano badania fizykalne. Zlecono badanie krw" +
    "i.";
            // 
            // labelOldDescription
            // 
            this.labelOldDescription.AutoSize = true;
            this.labelOldDescription.Location = new System.Drawing.Point(185, 89);
            this.labelOldDescription.Name = "labelOldDescription";
            this.labelOldDescription.Size = new System.Drawing.Size(105, 17);
            this.labelOldDescription.TabIndex = 12;
            this.labelOldDescription.Text = "Old Description";
            // 
            // richTextBoxNewDescription
            // 
            this.richTextBoxNewDescription.Location = new System.Drawing.Point(624, 120);
            this.richTextBoxNewDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBoxNewDescription.Name = "richTextBoxNewDescription";
            this.richTextBoxNewDescription.Size = new System.Drawing.Size(377, 214);
            this.richTextBoxNewDescription.TabIndex = 14;
            this.richTextBoxNewDescription.Text = "";
            // 
            // labelNewDescription
            // 
            this.labelNewDescription.AutoSize = true;
            this.labelNewDescription.Location = new System.Drawing.Point(621, 101);
            this.labelNewDescription.Name = "labelNewDescription";
            this.labelNewDescription.Size = new System.Drawing.Size(110, 17);
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
            this.dataGridViewExaminationsList.Location = new System.Drawing.Point(7, 22);
            this.dataGridViewExaminationsList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewExaminationsList.Name = "dataGridViewExaminationsList";
            this.dataGridViewExaminationsList.ReadOnly = true;
            this.dataGridViewExaminationsList.Size = new System.Drawing.Size(161, 289);
            this.dataGridViewExaminationsList.TabIndex = 16;
            // 
            // buttonAddLabTest
            // 
            this.buttonAddLabTest.Location = new System.Drawing.Point(216, 218);
            this.buttonAddLabTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddLabTest.Name = "buttonAddLabTest";
            this.buttonAddLabTest.Size = new System.Drawing.Size(103, 24);
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
            this.groupBoxLabTestsList.Controls.Add(this.buttonDeleteLabTest);
            this.groupBoxLabTestsList.Controls.Add(this.buttonAddLabTest);
            this.groupBoxLabTestsList.Controls.Add(this.dataGridViewExaminationsList);
            this.groupBoxLabTestsList.Location = new System.Drawing.Point(1033, 392);
            this.groupBoxLabTestsList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLabTestsList.Name = "groupBoxLabTestsList";
            this.groupBoxLabTestsList.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxLabTestsList.Size = new System.Drawing.Size(372, 318);
            this.groupBoxLabTestsList.TabIndex = 18;
            this.groupBoxLabTestsList.TabStop = false;
            this.groupBoxLabTestsList.Text = "Lab Tests List";
            // 
            // buttonDeleteLabTest
            // 
            this.buttonDeleteLabTest.Location = new System.Drawing.Point(216, 288);
            this.buttonDeleteLabTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteLabTest.Name = "buttonDeleteLabTest";
            this.buttonDeleteLabTest.Size = new System.Drawing.Size(103, 23);
            this.buttonDeleteLabTest.TabIndex = 20;
            this.buttonDeleteLabTest.Text = "Delete Test";
            this.buttonDeleteLabTest.UseVisualStyleBackColor = true;
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.textBoxLastName);
            this.groupBoxPatient.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatient.Controls.Add(this.labelFisrtName);
            this.groupBoxPatient.Controls.Add(this.labelLastName);
            this.groupBoxPatient.Location = new System.Drawing.Point(624, 12);
            this.groupBoxPatient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPatient.Size = new System.Drawing.Size(290, 81);
            this.groupBoxPatient.TabIndex = 19;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(151, 46);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(133, 22);
            this.textBoxLastName.TabIndex = 1;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(9, 46);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(136, 22);
            this.textBoxFirstName.TabIndex = 0;
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonBack);
            this.groupBoxControls.Controls.Add(this.buttonEndVisit);
            this.groupBoxControls.Controls.Add(this.buttonCancelVisit);
            this.groupBoxControls.Location = new System.Drawing.Point(1132, 101);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(196, 201);
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
            this.groupBoxPreviousComments.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPreviousComments.Name = "groupBoxPreviousComments";
            this.groupBoxPreviousComments.Size = new System.Drawing.Size(582, 371);
            this.groupBoxPreviousComments.TabIndex = 21;
            this.groupBoxPreviousComments.TabStop = false;
            this.groupBoxPreviousComments.Text = "Old Visits";
            // 
            // DateOfPreviousVisits
            // 
            this.DateOfPreviousVisits.HeaderText = "Date Of Previous Visits";
            this.DateOfPreviousVisits.Name = "DateOfPreviousVisits";
            this.DateOfPreviousVisits.ReadOnly = true;
            // 
            // groupBoxOldTests
            // 
            this.groupBoxOldTests.Controls.Add(this.label1);
            this.groupBoxOldTests.Controls.Add(this.dataGridView1);
            this.groupBoxOldTests.Controls.Add(this.buttonPreviousTest);
            this.groupBoxOldTests.Controls.Add(this.richTextBox1);
            this.groupBoxOldTests.Controls.Add(this.buttonNextTest);
            this.groupBoxOldTests.Location = new System.Drawing.Point(12, 392);
            this.groupBoxOldTests.Name = "groupBoxOldTests";
            this.groupBoxOldTests.Size = new System.Drawing.Size(582, 317);
            this.groupBoxOldTests.TabIndex = 22;
            this.groupBoxOldTests.TabStop = false;
            this.groupBoxOldTests.Text = "Old Tests";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateOfTest,
            this.ProcedureName,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(17, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(342, 290);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Result";
            // 
            // buttonPreviousTest
            // 
            this.buttonPreviousTest.Location = new System.Drawing.Point(369, 288);
            this.buttonPreviousTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPreviousTest.Name = "buttonPreviousTest";
            this.buttonPreviousTest.Size = new System.Drawing.Size(103, 23);
            this.buttonPreviousTest.TabIndex = 23;
            this.buttonPreviousTest.Text = "Previous Test";
            this.buttonPreviousTest.UseVisualStyleBackColor = true;
            // 
            // buttonNextTest
            // 
            this.buttonNextTest.Location = new System.Drawing.Point(478, 288);
            this.buttonNextTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextTest.Name = "buttonNextTest";
            this.buttonNextTest.Size = new System.Drawing.Size(103, 23);
            this.buttonNextTest.TabIndex = 24;
            this.buttonNextTest.Text = "Next Test";
            this.buttonNextTest.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(378, 62);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(187, 214);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "Krwinki czerwone 1.1/L\nKrwinki białe 0.2/L\nOsocze 300g/L";
            // 
            // groupBoxPhysicalExaminations
            // 
            this.groupBoxPhysicalExaminations.Controls.Add(this.buttonEditPhysExamination);
            this.groupBoxPhysicalExaminations.Controls.Add(this.label2);
            this.groupBoxPhysicalExaminations.Controls.Add(this.richTextBox2);
            this.groupBoxPhysicalExaminations.Controls.Add(this.buttonAddPhysExamination);
            this.groupBoxPhysicalExaminations.Controls.Add(this.dataGridView2);
            this.groupBoxPhysicalExaminations.Location = new System.Drawing.Point(624, 392);
            this.groupBoxPhysicalExaminations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPhysicalExaminations.Name = "groupBoxPhysicalExaminations";
            this.groupBoxPhysicalExaminations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxPhysicalExaminations.Size = new System.Drawing.Size(377, 318);
            this.groupBoxPhysicalExaminations.TabIndex = 23;
            this.groupBoxPhysicalExaminations.TabStop = false;
            this.groupBoxPhysicalExaminations.Text = "Physical Examinations";
            // 
            // buttonAddPhysExamination
            // 
            this.buttonAddPhysExamination.Location = new System.Drawing.Point(186, 210);
            this.buttonAddPhysExamination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddPhysExamination.Name = "buttonAddPhysExamination";
            this.buttonAddPhysExamination.Size = new System.Drawing.Size(177, 41);
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
            this.dataGridView2.Location = new System.Drawing.Point(7, 22);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(161, 289);
            this.dataGridView2.TabIndex = 16;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(186, 40);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(177, 163);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Result";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(175, 40);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(184, 163);
            this.richTextBox3.TabIndex = 21;
            this.richTextBox3.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Comment to laboratory";
            // 
            // buttonEditLabTest
            // 
            this.buttonEditLabTest.Location = new System.Drawing.Point(216, 252);
            this.buttonEditLabTest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditLabTest.Name = "buttonEditLabTest";
            this.buttonEditLabTest.Size = new System.Drawing.Size(103, 24);
            this.buttonEditLabTest.TabIndex = 24;
            this.buttonEditLabTest.Text = "Edit Test";
            this.buttonEditLabTest.UseVisualStyleBackColor = true;
            // 
            // buttonEditPhysExamination
            // 
            this.buttonEditPhysExamination.Location = new System.Drawing.Point(186, 270);
            this.buttonEditPhysExamination.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEditPhysExamination.Name = "buttonEditPhysExamination";
            this.buttonEditPhysExamination.Size = new System.Drawing.Size(177, 41);
            this.buttonEditPhysExamination.TabIndex = 24;
            this.buttonEditPhysExamination.Text = "Edit Examination";
            this.buttonEditPhysExamination.UseVisualStyleBackColor = true;
            // 
            // LabTest
            // 
            this.LabTest.HeaderText = "Lab Test";
            this.LabTest.Name = "LabTest";
            this.LabTest.ReadOnly = true;
            // 
            // PhysicalExamination
            // 
            this.PhysicalExamination.HeaderText = "Physical Examination";
            this.PhysicalExamination.Name = "PhysicalExamination";
            this.PhysicalExamination.ReadOnly = true;
            // 
            // FormDoctorVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 721);
            this.Controls.Add(this.groupBoxPhysicalExaminations);
            this.Controls.Add(this.groupBoxOldTests);
            this.Controls.Add(this.groupBoxPreviousComments);
            this.Controls.Add(this.groupBoxControls);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.groupBoxLabTestsList);
            this.Controls.Add(this.labelNewDescription);
            this.Controls.Add(this.richTextBoxNewDescription);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button buttonDeleteLabTest;
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