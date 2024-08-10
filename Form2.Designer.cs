namespace ASM_2_Thầy_Toàn
{
    partial class ViewStudent
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
            this.lbUser = new System.Windows.Forms.Label();
            this.lbList = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvViewStudent = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(12, 19);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(39, 16);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "User:";
            // 
            // lbList
            // 
            this.lbList.AutoSize = true;
            this.lbList.Font = new System.Drawing.Font("Bell MT", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbList.Location = new System.Drawing.Point(302, 213);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(162, 28);
            this.lbList.TabIndex = 1;
            this.lbList.Text = "List of Student";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogout.Location = new System.Drawing.Point(633, 46);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 29);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // dgvViewStudent
            // 
            this.dgvViewStudent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Gender,
            this.DateOfBirth,
            this.ClassID});
            this.dgvViewStudent.Location = new System.Drawing.Point(59, 274);
            this.dgvViewStudent.Name = "dgvViewStudent";
            this.dgvViewStudent.RowHeadersWidth = 51;
            this.dgvViewStudent.RowTemplate.Height = 24;
            this.dgvViewStudent.Size = new System.Drawing.Size(678, 164);
            this.dgvViewStudent.TabIndex = 17;
            this.dgvViewStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvViewStudent_CellContentClick);
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
            // txtSearchID
            // 
            this.txtSearchID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSearchID.Location = new System.Drawing.Point(159, 120);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(100, 22);
            this.txtSearchID.TabIndex = 18;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSearch.Location = new System.Drawing.Point(78, 120);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search ID";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ViewStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.dgvViewStudent);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.lbUser);
            this.Name = "ViewStudent";
            this.Text = "ViewStudent";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvViewStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Button btnSearch;
    }
}