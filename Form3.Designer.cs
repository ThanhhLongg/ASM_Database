namespace ASM_2_Thầy_Toàn
{
    partial class Form3
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
            this.lbStudentmanagement = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbDateOfBirth = new System.Windows.Forms.Label();
            this.lbClass = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtDayofBirth = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bbtnLogout = new System.Windows.Forms.Button();
            this.dgvManagement = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.lbIDError = new System.Windows.Forms.Label();
            this.lbNameError = new System.Windows.Forms.Label();
            this.lbGenderError = new System.Windows.Forms.Label();
            this.lbDateOfBirthError = new System.Windows.Forms.Label();
            this.lbClassError = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnUpdata = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagement)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudentmanagement
            // 
            this.lbStudentmanagement.AutoSize = true;
            this.lbStudentmanagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentmanagement.Location = new System.Drawing.Point(259, 19);
            this.lbStudentmanagement.Name = "lbStudentmanagement";
            this.lbStudentmanagement.Size = new System.Drawing.Size(259, 29);
            this.lbStudentmanagement.TabIndex = 0;
            this.lbStudentmanagement.Text = "Student Management";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(289, 228);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(179, 29);
            this.lb2.TabIndex = 1;
            this.lb2.Text = "List of Student";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(114, 79);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(20, 16);
            this.lbID.TabIndex = 2;
            this.lbID.Text = "ID";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(114, 123);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 16);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(114, 173);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(52, 16);
            this.lbGender.TabIndex = 4;
            this.lbGender.Text = "Gender";
            // 
            // lbDateOfBirth
            // 
            this.lbDateOfBirth.AutoSize = true;
            this.lbDateOfBirth.Location = new System.Drawing.Point(407, 79);
            this.lbDateOfBirth.Name = "lbDateOfBirth";
            this.lbDateOfBirth.Size = new System.Drawing.Size(79, 16);
            this.lbDateOfBirth.TabIndex = 5;
            this.lbDateOfBirth.Text = "Date of Birth";
            // 
            // lbClass
            // 
            this.lbClass.AutoSize = true;
            this.lbClass.Location = new System.Drawing.Point(416, 131);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(41, 16);
            this.lbClass.TabIndex = 6;
            this.lbClass.Text = "Class";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(194, 73);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 22);
            this.txtID.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(194, 167);
            this.txtGender.Multiline = true;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(125, 22);
            this.txtGender.TabIndex = 9;
            // 
            // txtDayofBirth
            // 
            this.txtDayofBirth.Location = new System.Drawing.Point(492, 73);
            this.txtDayofBirth.Multiline = true;
            this.txtDayofBirth.Name = "txtDayofBirth";
            this.txtDayofBirth.Size = new System.Drawing.Size(139, 22);
            this.txtDayofBirth.TabIndex = 10;
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(39, 19);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(80, 16);
            this.lbUser.TabIndex = 12;
            this.lbUser.Text = "User: Admin";
            this.lbUser.Click += new System.EventHandler(this.lbUser_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInsert.Location = new System.Drawing.Point(107, 210);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(465, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // bbtnLogout
            // 
            this.bbtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bbtnLogout.Location = new System.Drawing.Point(698, 16);
            this.bbtnLogout.Name = "bbtnLogout";
            this.bbtnLogout.Size = new System.Drawing.Size(75, 23);
            this.bbtnLogout.TabIndex = 15;
            this.bbtnLogout.Text = "Logout";
            this.bbtnLogout.UseVisualStyleBackColor = false;
            this.bbtnLogout.Click += new System.EventHandler(this.bbtnLogout_Click);
            // 
            // dgvManagement
            // 
            this.dgvManagement.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Gender,
            this.DateOfBirth,
            this.ClassID});
            this.dgvManagement.Location = new System.Drawing.Point(73, 260);
            this.dgvManagement.Name = "dgvManagement";
            this.dgvManagement.RowHeadersWidth = 51;
            this.dgvManagement.RowTemplate.Height = 24;
            this.dgvManagement.Size = new System.Drawing.Size(679, 173);
            this.dgvManagement.TabIndex = 16;
            this.dgvManagement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManagement_CellClick);
            this.dgvManagement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManagement_CellContentClick);
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "student_id";
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.Width = 125;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "student_name_id";
            this.StudentName.HeaderText = "Student Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.Width = 125;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "student_gender";
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.Width = 125;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.DataPropertyName = "student_date_of_birth";
            this.DateOfBirth.HeaderText = "Date Of Birth";
            this.DateOfBirth.MinimumWidth = 6;
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Width = 125;
            // 
            // ClassID
            // 
            this.ClassID.DataPropertyName = "class_id";
            this.ClassID.HeaderText = "Class ID";
            this.ClassID.MinimumWidth = 6;
            this.ClassID.Name = "ClassID";
            this.ClassID.Width = 125;
            // 
            // cbClass
            // 
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(492, 123);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(139, 24);
            this.cbClass.TabIndex = 18;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // lbIDError
            // 
            this.lbIDError.AutoSize = true;
            this.lbIDError.Location = new System.Drawing.Point(194, 102);
            this.lbIDError.Name = "lbIDError";
            this.lbIDError.Size = new System.Drawing.Size(0, 16);
            this.lbIDError.TabIndex = 19;
            // 
            // lbNameError
            // 
            this.lbNameError.AutoSize = true;
            this.lbNameError.Location = new System.Drawing.Point(197, 154);
            this.lbNameError.Name = "lbNameError";
            this.lbNameError.Size = new System.Drawing.Size(0, 16);
            this.lbNameError.TabIndex = 20;
            this.lbNameError.Click += new System.EventHandler(this.lbNameError_Click);
            // 
            // lbGenderError
            // 
            this.lbGenderError.AutoSize = true;
            this.lbGenderError.Location = new System.Drawing.Point(194, 196);
            this.lbGenderError.Name = "lbGenderError";
            this.lbGenderError.Size = new System.Drawing.Size(0, 16);
            this.lbGenderError.TabIndex = 21;
            // 
            // lbDateOfBirthError
            // 
            this.lbDateOfBirthError.AutoSize = true;
            this.lbDateOfBirthError.Location = new System.Drawing.Point(498, 101);
            this.lbDateOfBirthError.Name = "lbDateOfBirthError";
            this.lbDateOfBirthError.Size = new System.Drawing.Size(0, 16);
            this.lbDateOfBirthError.TabIndex = 22;
            // 
            // lbClassError
            // 
            this.lbClassError.AutoSize = true;
            this.lbClassError.Location = new System.Drawing.Point(501, 154);
            this.lbClassError.Name = "lbClassError";
            this.lbClassError.Size = new System.Drawing.Size(0, 16);
            this.lbClassError.TabIndex = 23;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(194, 121);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 22);
            this.txtName.TabIndex = 24;
            // 
            // btnUpdata
            // 
            this.btnUpdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUpdata.Location = new System.Drawing.Point(218, 210);
            this.btnUpdata.Name = "btnUpdata";
            this.btnUpdata.Size = new System.Drawing.Size(75, 23);
            this.btnUpdata.TabIndex = 25;
            this.btnUpdata.Text = "Update";
            this.btnUpdata.UseVisualStyleBackColor = false;
            this.btnUpdata.Click += new System.EventHandler(this.btnUpdata_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.Location = new System.Drawing.Point(565, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdata);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbClassError);
            this.Controls.Add(this.lbDateOfBirthError);
            this.Controls.Add(this.lbGenderError);
            this.Controls.Add(this.lbNameError);
            this.Controls.Add(this.lbIDError);
            this.Controls.Add(this.cbClass);
            this.Controls.Add(this.dgvManagement);
            this.Controls.Add(this.bbtnLogout);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.txtDayofBirth);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbClass);
            this.Controls.Add(this.lbDateOfBirth);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lbStudentmanagement);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManagement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbStudentmanagement;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbDateOfBirth;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtDayofBirth;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button bbtnLogout;
        private System.Windows.Forms.DataGridView dgvManagement;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.Label lbIDError;
        private System.Windows.Forms.Label lbNameError;
        private System.Windows.Forms.Label lbGenderError;
        private System.Windows.Forms.Label lbDateOfBirthError;
        private System.Windows.Forms.Label lbClassError;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnUpdata;
        private System.Windows.Forms.Button btnDelete;
    }
}