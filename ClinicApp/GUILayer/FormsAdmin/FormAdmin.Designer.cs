namespace GUILayer
{
    partial class FormAdmin
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
            this.labelPanelName = new System.Windows.Forms.Label();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hashcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateRetired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelOnlyActive = new System.Windows.Forms.Label();
            this.checkBoxOnlyActive = new System.Windows.Forms.CheckBox();
            this.labelDateRetired = new System.Windows.Forms.Label();
            this.dateTimePickerDateRetired = new System.Windows.Forms.DateTimePicker();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxUserID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.buttonRetireUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.groupBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPanelName
            // 
            this.labelPanelName.AutoSize = true;
            this.labelPanelName.Font = new System.Drawing.Font("OpenSymbol", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPanelName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelPanelName.Location = new System.Drawing.Point(260, 9);
            this.labelPanelName.Name = "labelPanelName";
            this.labelPanelName.Size = new System.Drawing.Size(257, 48);
            this.labelPanelName.TabIndex = 0;
            this.labelPanelName.Text = "Admin Panel";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AllowUserToResizeColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.Username,
            this.Hashcode,
            this.Role,
            this.DateRetired});
            this.dataGridViewUsers.Location = new System.Drawing.Point(12, 152);
            this.dataGridViewUsers.MultiSelect = false;
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUsers.Size = new System.Drawing.Size(564, 287);
            this.dataGridViewUsers.TabIndex = 1;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            this.UserID.Width = 60;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 130;
            // 
            // Hashcode
            // 
            this.Hashcode.HeaderText = "Hashcode";
            this.Hashcode.Name = "Hashcode";
            this.Hashcode.ReadOnly = true;
            this.Hashcode.Width = 143;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 60;
            // 
            // DateRetired
            // 
            this.DateRetired.HeaderText = "DateRetired";
            this.DateRetired.Name = "DateRetired";
            this.DateRetired.ReadOnly = true;
            this.DateRetired.Width = 110;
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.Location = new System.Drawing.Point(610, 213);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(120, 23);
            this.buttonNewUser.TabIndex = 2;
            this.buttonNewUser.Text = "New User";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.labelOnlyActive);
            this.groupBoxSearch.Controls.Add(this.checkBoxOnlyActive);
            this.groupBoxSearch.Controls.Add(this.labelDateRetired);
            this.groupBoxSearch.Controls.Add(this.dateTimePickerDateRetired);
            this.groupBoxSearch.Controls.Add(this.comboBoxRole);
            this.groupBoxSearch.Controls.Add(this.labelRole);
            this.groupBoxSearch.Controls.Add(this.labelUsername);
            this.groupBoxSearch.Controls.Add(this.labelUserID);
            this.groupBoxSearch.Controls.Add(this.textBoxUsername);
            this.groupBoxSearch.Controls.Add(this.textBoxUserID);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 57);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(738, 89);
            this.groupBoxSearch.TabIndex = 4;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // labelOnlyActive
            // 
            this.labelOnlyActive.AutoSize = true;
            this.labelOnlyActive.Location = new System.Drawing.Point(522, 28);
            this.labelOnlyActive.Name = "labelOnlyActive";
            this.labelOnlyActive.Size = new System.Drawing.Size(61, 13);
            this.labelOnlyActive.TabIndex = 21;
            this.labelOnlyActive.Text = "Only Active";
            // 
            // checkBoxOnlyActive
            // 
            this.checkBoxOnlyActive.AutoSize = true;
            this.checkBoxOnlyActive.Location = new System.Drawing.Point(545, 47);
            this.checkBoxOnlyActive.Name = "checkBoxOnlyActive";
            this.checkBoxOnlyActive.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOnlyActive.TabIndex = 20;
            this.checkBoxOnlyActive.UseVisualStyleBackColor = true;
            this.checkBoxOnlyActive.CheckedChanged += new System.EventHandler(this.checkBoxOnlyActive_CheckedChanged);
            // 
            // labelDateRetired
            // 
            this.labelDateRetired.AutoSize = true;
            this.labelDateRetired.Location = new System.Drawing.Point(403, 28);
            this.labelDateRetired.Name = "labelDateRetired";
            this.labelDateRetired.Size = new System.Drawing.Size(64, 13);
            this.labelDateRetired.TabIndex = 19;
            this.labelDateRetired.Text = "DateRetired";
            // 
            // dateTimePickerDateRetired
            // 
            this.dateTimePickerDateRetired.Checked = false;
            this.dateTimePickerDateRetired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDateRetired.Location = new System.Drawing.Point(406, 44);
            this.dateTimePickerDateRetired.Name = "dateTimePickerDateRetired";
            this.dateTimePickerDateRetired.ShowCheckBox = true;
            this.dateTimePickerDateRetired.Size = new System.Drawing.Size(100, 20);
            this.dateTimePickerDateRetired.TabIndex = 18;
            this.dateTimePickerDateRetired.Value = new System.DateTime(2019, 4, 5, 19, 12, 43, 0);
            this.dateTimePickerDateRetired.ValueChanged += new System.EventHandler(this.dateTimePickerDateRetired_ValueChanged);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            " ",
            "REC",
            "DOC",
            "TEC",
            "MAN",
            "ADM"});
            this.comboBoxRole.Location = new System.Drawing.Point(276, 43);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(100, 21);
            this.comboBoxRole.TabIndex = 17;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(273, 28);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(29, 13);
            this.labelRole.TabIndex = 8;
            this.labelRole.Text = "Role";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(143, 28);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 7;
            this.labelUsername.Text = "Username";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Location = new System.Drawing.Point(13, 28);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(40, 13);
            this.labelUserID.TabIndex = 6;
            this.labelUserID.Text = "UserID";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(146, 44);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 4;
            // 
            // textBoxUserID
            // 
            this.textBoxUserID.Location = new System.Drawing.Point(16, 44);
            this.textBoxUserID.Name = "textBoxUserID";
            this.textBoxUserID.Size = new System.Drawing.Size(100, 20);
            this.textBoxUserID.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(598, 42);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(120, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Location = new System.Drawing.Point(610, 279);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(120, 23);
            this.buttonChangePassword.TabIndex = 5;
            this.buttonChangePassword.Text = "Change Password";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // buttonRetireUser
            // 
            this.buttonRetireUser.Location = new System.Drawing.Point(610, 346);
            this.buttonRetireUser.Name = "buttonRetireUser";
            this.buttonRetireUser.Size = new System.Drawing.Size(120, 23);
            this.buttonRetireUser.TabIndex = 6;
            this.buttonRetireUser.Text = "Retirement";
            this.buttonRetireUser.UseVisualStyleBackColor = true;
            this.buttonRetireUser.Click += new System.EventHandler(this.buttonRetireUser_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 451);
            this.Controls.Add(this.buttonRetireUser);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.groupBoxSearch);
            this.Controls.Add(this.buttonNewUser);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.labelPanelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPanelName;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxUserID;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Button buttonRetireUser;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateRetired;
        private System.Windows.Forms.Label labelDateRetired;
        private System.Windows.Forms.Label labelOnlyActive;
        private System.Windows.Forms.CheckBox checkBoxOnlyActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hashcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateRetired;
    }
}