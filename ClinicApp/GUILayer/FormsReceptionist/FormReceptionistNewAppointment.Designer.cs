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
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PWZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePickerAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxPESEL = new System.Windows.Forms.TextBox();
            this.labelPESEL = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton0 = new System.Windows.Forms.RadioButton();
            this.radioButton27 = new System.Windows.Forms.RadioButton();
            this.radioButton26 = new System.Windows.Forms.RadioButton();
            this.radioButton25 = new System.Windows.Forms.RadioButton();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton23 = new System.Windows.Forms.RadioButton();
            this.radioButton22 = new System.Windows.Forms.RadioButton();
            this.radioButton21 = new System.Windows.Forms.RadioButton();
            this.radioButton20 = new System.Windows.Forms.RadioButton();
            this.radioButton19 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.radioButton17 = new System.Windows.Forms.RadioButton();
            this.radioButton16 = new System.Windows.Forms.RadioButton();
            this.radioButton15 = new System.Windows.Forms.RadioButton();
            this.radioButton14 = new System.Windows.Forms.RadioButton();
            this.radioButton13 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.groupBoxSearchDoctors = new System.Windows.Forms.GroupBox();
            this.buttonSearchDoctors = new System.Windows.Forms.Button();
            this.textBoxDoctorFirstName = new System.Windows.Forms.TextBox();
            this.labelDoctorFirstName = new System.Windows.Forms.Label();
            this.textBoxDoctorLastName = new System.Windows.Forms.TextBox();
            this.labelDoctorLastName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.groupBoxPatient.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.groupBoxSearchDoctors.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddAppointment
            // 
            this.buttonAddAppointment.Location = new System.Drawing.Point(12, 434);
            this.buttonAddAppointment.Name = "buttonAddAppointment";
            this.buttonAddAppointment.Size = new System.Drawing.Size(120, 23);
            this.buttonAddAppointment.TabIndex = 0;
            this.buttonAddAppointment.Text = "Add Appointment";
            this.buttonAddAppointment.UseVisualStyleBackColor = true;
            this.buttonAddAppointment.Click += new System.EventHandler(this.buttonAddAppointment_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(653, 434);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Back";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(306, 9);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(270, 37);
            this.labelPanelName.TabIndex = 2;
            this.labelPanelName.Text = "New Appointment";
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AllowUserToAddRows = false;
            this.dataGridViewDoctors.AllowUserToDeleteRows = false;
            this.dataGridViewDoctors.AllowUserToResizeColumns = false;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.PWZ});
            this.dataGridViewDoctors.Location = new System.Drawing.Point(12, 233);
            this.dataGridViewDoctors.MultiSelect = false;
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.ReadOnly = true;
            this.dataGridViewDoctors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDoctors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(433, 176);
            this.dataGridViewDoctors.TabIndex = 9;
            this.dataGridViewDoctors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDoctors_CellClick);
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 120;
            // 
            // LastName
            // 
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 120;
            // 
            // PWZ
            // 
            this.PWZ.HeaderText = "PWZ";
            this.PWZ.Name = "PWZ";
            this.PWZ.ReadOnly = true;
            this.PWZ.Width = 120;
            // 
            // dateTimePickerAppointmentDate
            // 
            this.dateTimePickerAppointmentDate.Location = new System.Drawing.Point(34, 41);
            this.dateTimePickerAppointmentDate.Name = "dateTimePickerAppointmentDate";
            this.dateTimePickerAppointmentDate.Size = new System.Drawing.Size(241, 20);
            this.dateTimePickerAppointmentDate.TabIndex = 20;
            this.dateTimePickerAppointmentDate.Value = new System.DateTime(2019, 5, 1, 0, 0, 0, 0);
            this.dateTimePickerAppointmentDate.ValueChanged += new System.EventHandler(this.dateTimePickerAppointmentDate_ValueChanged);
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Controls.Add(this.textBoxFirstName);
            this.groupBoxPatient.Controls.Add(this.labelFirstName);
            this.groupBoxPatient.Controls.Add(this.textBoxPESEL);
            this.groupBoxPatient.Controls.Add(this.labelPESEL);
            this.groupBoxPatient.Controls.Add(this.textBoxLastName);
            this.groupBoxPatient.Controls.Add(this.labelLastName);
            this.groupBoxPatient.Location = new System.Drawing.Point(12, 60);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(433, 77);
            this.groupBoxPatient.TabIndex = 32;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(15, 37);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.ReadOnly = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 21);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelFirstName.TabIndex = 3;
            this.labelFirstName.Text = "First Name";
            // 
            // textBoxPESEL
            // 
            this.textBoxPESEL.Location = new System.Drawing.Point(301, 37);
            this.textBoxPESEL.Name = "textBoxPESEL";
            this.textBoxPESEL.ReadOnly = true;
            this.textBoxPESEL.Size = new System.Drawing.Size(100, 20);
            this.textBoxPESEL.TabIndex = 8;
            // 
            // labelPESEL
            // 
            this.labelPESEL.AutoSize = true;
            this.labelPESEL.Location = new System.Drawing.Point(298, 21);
            this.labelPESEL.Name = "labelPESEL";
            this.labelPESEL.Size = new System.Drawing.Size(41, 13);
            this.labelPESEL.TabIndex = 5;
            this.labelPESEL.Text = "PESEL";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(158, 37);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.ReadOnly = true;
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 7;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(155, 21);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(58, 13);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(25, 125);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(46, 17);
            this.radioButton4.TabIndex = 33;
            this.radioButton4.Text = "8:00";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.dateTimePickerAppointmentDate);
            this.groupBoxTime.Controls.Add(this.radioButton3);
            this.groupBoxTime.Controls.Add(this.radioButton2);
            this.groupBoxTime.Controls.Add(this.radioButton1);
            this.groupBoxTime.Controls.Add(this.radioButton0);
            this.groupBoxTime.Controls.Add(this.radioButton27);
            this.groupBoxTime.Controls.Add(this.radioButton26);
            this.groupBoxTime.Controls.Add(this.radioButton25);
            this.groupBoxTime.Controls.Add(this.radioButton24);
            this.groupBoxTime.Controls.Add(this.radioButton23);
            this.groupBoxTime.Controls.Add(this.radioButton22);
            this.groupBoxTime.Controls.Add(this.radioButton21);
            this.groupBoxTime.Controls.Add(this.radioButton20);
            this.groupBoxTime.Controls.Add(this.radioButton19);
            this.groupBoxTime.Controls.Add(this.radioButton18);
            this.groupBoxTime.Controls.Add(this.radioButton17);
            this.groupBoxTime.Controls.Add(this.radioButton16);
            this.groupBoxTime.Controls.Add(this.radioButton15);
            this.groupBoxTime.Controls.Add(this.radioButton14);
            this.groupBoxTime.Controls.Add(this.radioButton13);
            this.groupBoxTime.Controls.Add(this.radioButton12);
            this.groupBoxTime.Controls.Add(this.radioButton11);
            this.groupBoxTime.Controls.Add(this.radioButton10);
            this.groupBoxTime.Controls.Add(this.radioButton9);
            this.groupBoxTime.Controls.Add(this.radioButton8);
            this.groupBoxTime.Controls.Add(this.radioButton7);
            this.groupBoxTime.Controls.Add(this.radioButton6);
            this.groupBoxTime.Controls.Add(this.radioButton5);
            this.groupBoxTime.Controls.Add(this.radioButton4);
            this.groupBoxTime.Location = new System.Drawing.Point(464, 60);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(309, 349);
            this.groupBoxTime.TabIndex = 34;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Date and Time";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(235, 95);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 60;
            this.radioButton3.Text = "7:30";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(164, 95);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 59;
            this.radioButton2.Text = "7:00";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(93, 95);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 58;
            this.radioButton1.Text = "6:30";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton0
            // 
            this.radioButton0.AutoSize = true;
            this.radioButton0.Location = new System.Drawing.Point(26, 96);
            this.radioButton0.Name = "radioButton0";
            this.radioButton0.Size = new System.Drawing.Size(46, 17);
            this.radioButton0.TabIndex = 57;
            this.radioButton0.Text = "6:00";
            this.radioButton0.UseVisualStyleBackColor = true;
            // 
            // radioButton27
            // 
            this.radioButton27.AutoSize = true;
            this.radioButton27.Location = new System.Drawing.Point(235, 275);
            this.radioButton27.Name = "radioButton27";
            this.radioButton27.Size = new System.Drawing.Size(52, 17);
            this.radioButton27.TabIndex = 56;
            this.radioButton27.Text = "19:30";
            this.radioButton27.UseVisualStyleBackColor = true;
            // 
            // radioButton26
            // 
            this.radioButton26.AutoSize = true;
            this.radioButton26.Location = new System.Drawing.Point(164, 275);
            this.radioButton26.Name = "radioButton26";
            this.radioButton26.Size = new System.Drawing.Size(52, 17);
            this.radioButton26.TabIndex = 55;
            this.radioButton26.Text = "19:00";
            this.radioButton26.UseVisualStyleBackColor = true;
            // 
            // radioButton25
            // 
            this.radioButton25.AutoSize = true;
            this.radioButton25.Location = new System.Drawing.Point(93, 275);
            this.radioButton25.Name = "radioButton25";
            this.radioButton25.Size = new System.Drawing.Size(52, 17);
            this.radioButton25.TabIndex = 54;
            this.radioButton25.Text = "18:30";
            this.radioButton25.UseVisualStyleBackColor = true;
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.Location = new System.Drawing.Point(25, 275);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(52, 17);
            this.radioButton24.TabIndex = 53;
            this.radioButton24.Text = "18:00";
            this.radioButton24.UseVisualStyleBackColor = true;
            // 
            // radioButton23
            // 
            this.radioButton23.AutoSize = true;
            this.radioButton23.Location = new System.Drawing.Point(235, 245);
            this.radioButton23.Name = "radioButton23";
            this.radioButton23.Size = new System.Drawing.Size(52, 17);
            this.radioButton23.TabIndex = 52;
            this.radioButton23.Text = "17:30";
            this.radioButton23.UseVisualStyleBackColor = true;
            // 
            // radioButton22
            // 
            this.radioButton22.AutoSize = true;
            this.radioButton22.Location = new System.Drawing.Point(164, 245);
            this.radioButton22.Name = "radioButton22";
            this.radioButton22.Size = new System.Drawing.Size(52, 17);
            this.radioButton22.TabIndex = 51;
            this.radioButton22.Text = "17:00";
            this.radioButton22.UseVisualStyleBackColor = true;
            // 
            // radioButton21
            // 
            this.radioButton21.AutoSize = true;
            this.radioButton21.Location = new System.Drawing.Point(93, 245);
            this.radioButton21.Name = "radioButton21";
            this.radioButton21.Size = new System.Drawing.Size(52, 17);
            this.radioButton21.TabIndex = 50;
            this.radioButton21.Text = "16:30";
            this.radioButton21.UseVisualStyleBackColor = true;
            // 
            // radioButton20
            // 
            this.radioButton20.AutoSize = true;
            this.radioButton20.Location = new System.Drawing.Point(25, 245);
            this.radioButton20.Name = "radioButton20";
            this.radioButton20.Size = new System.Drawing.Size(52, 17);
            this.radioButton20.TabIndex = 49;
            this.radioButton20.Text = "16:00";
            this.radioButton20.UseVisualStyleBackColor = true;
            // 
            // radioButton19
            // 
            this.radioButton19.AutoSize = true;
            this.radioButton19.Location = new System.Drawing.Point(235, 215);
            this.radioButton19.Name = "radioButton19";
            this.radioButton19.Size = new System.Drawing.Size(52, 17);
            this.radioButton19.TabIndex = 48;
            this.radioButton19.Text = "15:30";
            this.radioButton19.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(164, 215);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(52, 17);
            this.radioButton18.TabIndex = 47;
            this.radioButton18.Text = "15:00";
            this.radioButton18.UseVisualStyleBackColor = true;
            // 
            // radioButton17
            // 
            this.radioButton17.AutoSize = true;
            this.radioButton17.Location = new System.Drawing.Point(93, 215);
            this.radioButton17.Name = "radioButton17";
            this.radioButton17.Size = new System.Drawing.Size(52, 17);
            this.radioButton17.TabIndex = 46;
            this.radioButton17.Text = "14:30";
            this.radioButton17.UseVisualStyleBackColor = true;
            // 
            // radioButton16
            // 
            this.radioButton16.AutoSize = true;
            this.radioButton16.Location = new System.Drawing.Point(25, 215);
            this.radioButton16.Name = "radioButton16";
            this.radioButton16.Size = new System.Drawing.Size(52, 17);
            this.radioButton16.TabIndex = 45;
            this.radioButton16.Text = "14:00";
            this.radioButton16.UseVisualStyleBackColor = true;
            // 
            // radioButton15
            // 
            this.radioButton15.AutoSize = true;
            this.radioButton15.Location = new System.Drawing.Point(235, 185);
            this.radioButton15.Name = "radioButton15";
            this.radioButton15.Size = new System.Drawing.Size(52, 17);
            this.radioButton15.TabIndex = 44;
            this.radioButton15.Text = "13:30";
            this.radioButton15.UseVisualStyleBackColor = true;
            // 
            // radioButton14
            // 
            this.radioButton14.AutoSize = true;
            this.radioButton14.Location = new System.Drawing.Point(164, 185);
            this.radioButton14.Name = "radioButton14";
            this.radioButton14.Size = new System.Drawing.Size(52, 17);
            this.radioButton14.TabIndex = 43;
            this.radioButton14.Text = "13:00";
            this.radioButton14.UseVisualStyleBackColor = true;
            // 
            // radioButton13
            // 
            this.radioButton13.AutoSize = true;
            this.radioButton13.Location = new System.Drawing.Point(93, 185);
            this.radioButton13.Name = "radioButton13";
            this.radioButton13.Size = new System.Drawing.Size(52, 17);
            this.radioButton13.TabIndex = 42;
            this.radioButton13.Text = "12:30";
            this.radioButton13.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(25, 185);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(52, 17);
            this.radioButton12.TabIndex = 41;
            this.radioButton12.Text = "12:00";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(235, 155);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(52, 17);
            this.radioButton11.TabIndex = 40;
            this.radioButton11.Text = "11:30";
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(164, 155);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(52, 17);
            this.radioButton10.TabIndex = 39;
            this.radioButton10.Text = "11:00";
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(93, 155);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(52, 17);
            this.radioButton9.TabIndex = 38;
            this.radioButton9.Text = "10:30";
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(25, 155);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(52, 17);
            this.radioButton8.TabIndex = 37;
            this.radioButton8.Text = "10:00";
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(235, 125);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(46, 17);
            this.radioButton7.TabIndex = 36;
            this.radioButton7.Text = "9:30";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(164, 125);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(46, 17);
            this.radioButton6.TabIndex = 35;
            this.radioButton6.Text = "9:00";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(93, 125);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(46, 17);
            this.radioButton5.TabIndex = 34;
            this.radioButton5.Text = "8:30";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearchDoctors
            // 
            this.groupBoxSearchDoctors.Controls.Add(this.buttonSearchDoctors);
            this.groupBoxSearchDoctors.Controls.Add(this.textBoxDoctorFirstName);
            this.groupBoxSearchDoctors.Controls.Add(this.labelDoctorFirstName);
            this.groupBoxSearchDoctors.Controls.Add(this.textBoxDoctorLastName);
            this.groupBoxSearchDoctors.Controls.Add(this.labelDoctorLastName);
            this.groupBoxSearchDoctors.Location = new System.Drawing.Point(12, 146);
            this.groupBoxSearchDoctors.Name = "groupBoxSearchDoctors";
            this.groupBoxSearchDoctors.Size = new System.Drawing.Size(433, 77);
            this.groupBoxSearchDoctors.TabIndex = 33;
            this.groupBoxSearchDoctors.TabStop = false;
            this.groupBoxSearchDoctors.Text = "Search Doctors";
            // 
            // buttonSearchDoctors
            // 
            this.buttonSearchDoctors.Location = new System.Drawing.Point(301, 34);
            this.buttonSearchDoctors.Name = "buttonSearchDoctors";
            this.buttonSearchDoctors.Size = new System.Drawing.Size(100, 23);
            this.buttonSearchDoctors.TabIndex = 8;
            this.buttonSearchDoctors.Text = "Search";
            this.buttonSearchDoctors.UseVisualStyleBackColor = true;
            this.buttonSearchDoctors.Click += new System.EventHandler(this.buttonSearchDoctors_Click);
            // 
            // textBoxDoctorFirstName
            // 
            this.textBoxDoctorFirstName.Location = new System.Drawing.Point(15, 37);
            this.textBoxDoctorFirstName.Name = "textBoxDoctorFirstName";
            this.textBoxDoctorFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDoctorFirstName.TabIndex = 6;
            // 
            // labelDoctorFirstName
            // 
            this.labelDoctorFirstName.AutoSize = true;
            this.labelDoctorFirstName.Location = new System.Drawing.Point(12, 21);
            this.labelDoctorFirstName.Name = "labelDoctorFirstName";
            this.labelDoctorFirstName.Size = new System.Drawing.Size(57, 13);
            this.labelDoctorFirstName.TabIndex = 3;
            this.labelDoctorFirstName.Text = "First Name";
            // 
            // textBoxDoctorLastName
            // 
            this.textBoxDoctorLastName.Location = new System.Drawing.Point(158, 37);
            this.textBoxDoctorLastName.Name = "textBoxDoctorLastName";
            this.textBoxDoctorLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxDoctorLastName.TabIndex = 7;
            // 
            // labelDoctorLastName
            // 
            this.labelDoctorLastName.AutoSize = true;
            this.labelDoctorLastName.Location = new System.Drawing.Point(155, 21);
            this.labelDoctorLastName.Name = "labelDoctorLastName";
            this.labelDoctorLastName.Size = new System.Drawing.Size(58, 13);
            this.labelDoctorLastName.TabIndex = 4;
            this.labelDoctorLastName.Text = "Last Name";
            // 
            // FormReceptionistNewAppointment
            // 
            this.AcceptButton = this.buttonAddAppointment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(785, 475);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Controls.Add(this.groupBoxSearchDoctors);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.groupBoxPatient);
            this.Controls.Add(this.labelPanelName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddAppointment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormReceptionistNewAppointment";
            this.Text = "FormReceptionistNewAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.groupBoxPatient.ResumeLayout(false);
            this.groupBoxPatient.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBoxSearchDoctors.ResumeLayout(false);
            this.groupBoxSearchDoctors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddAppointment;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.DateTimePicker dateTimePickerAppointmentDate;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxPESEL;
        private System.Windows.Forms.Label labelPESEL;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton0;
        private System.Windows.Forms.RadioButton radioButton27;
        private System.Windows.Forms.RadioButton radioButton26;
        private System.Windows.Forms.RadioButton radioButton25;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.RadioButton radioButton23;
        private System.Windows.Forms.RadioButton radioButton22;
        private System.Windows.Forms.RadioButton radioButton21;
        private System.Windows.Forms.RadioButton radioButton20;
        private System.Windows.Forms.RadioButton radioButton19;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton16;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.GroupBox groupBoxSearchDoctors;
        private System.Windows.Forms.TextBox textBoxDoctorFirstName;
        private System.Windows.Forms.Label labelDoctorFirstName;
        private System.Windows.Forms.TextBox textBoxDoctorLastName;
        private System.Windows.Forms.Label labelDoctorLastName;
        private System.Windows.Forms.Button buttonSearchDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PWZ;
    }
}