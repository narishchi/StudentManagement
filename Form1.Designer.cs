namespace StudentManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblDepartment = new Label();
            lblGrade = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtDepartment = new TextBox();
            txtGrade = new TextBox();
            btnAddStudent = new Button();
            lblProfessorFirstName = new Label();
            lblProfessorLastName = new Label();
            lblProfessorDepartment = new Label();
            gbStudentInfo = new GroupBox();
            butClearStudent = new Button();
            txtStudentDetails = new TextBox();
            txtProfessorFirstName = new TextBox();
            txtProfessorLastName = new TextBox();
            txtProfessorDepartment = new TextBox();
            btnAddProfessor = new Button();
            gbProFessorInfo = new GroupBox();
            btnClearProFessors = new Button();
            txtProfessorDetails = new TextBox();
            btnShowTopStudent = new Button();
            lblTopStudent = new Label();
            btnClear = new Button();
            gbStudentInfo.SuspendLayout();
            gbProFessorInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(24, 22);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(65, 15);
            lblStudentId.TabIndex = 0;
            lblStudentId.Text = "รหัสนักศึกษา";
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(95, 19);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(100, 23);
            txtStudentId.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(37, 49);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(20, 15);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "ชื่อ";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(219, 49);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(45, 15);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "นามสกุล";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(219, 22);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(30, 15);
            lblDepartment.TabIndex = 4;
            lblDepartment.Text = "สาขา";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(37, 75);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(29, 15);
            lblGrade.TabIndex = 5;
            lblGrade.Text = "เกรด";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(95, 46);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(277, 46);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 7;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(277, 17);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(100, 23);
            txtDepartment.TabIndex = 8;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(95, 72);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(100, 23);
            txtGrade.TabIndex = 9;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(402, 15);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(246, 27);
            btnAddStudent.TabIndex = 10;
            btnAddStudent.Text = "เพิ่มนักศึกษา";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // lblProfessorFirstName
            // 
            lblProfessorFirstName.AutoSize = true;
            lblProfessorFirstName.Location = new Point(27, 20);
            lblProfessorFirstName.Name = "lblProfessorFirstName";
            lblProfessorFirstName.Size = new Size(53, 15);
            lblProfessorFirstName.TabIndex = 12;
            lblProfessorFirstName.Text = "ชื่ออาจารย์";
            // 
            // lblProfessorLastName
            // 
            lblProfessorLastName.AutoSize = true;
            lblProfessorLastName.Location = new Point(198, 23);
            lblProfessorLastName.Name = "lblProfessorLastName";
            lblProfessorLastName.Size = new Size(78, 15);
            lblProfessorLastName.TabIndex = 13;
            lblProfessorLastName.Text = "นามสกุลอาจารย์";
            // 
            // lblProfessorDepartment
            // 
            lblProfessorDepartment.AutoSize = true;
            lblProfessorDepartment.Location = new Point(36, 54);
            lblProfessorDepartment.Name = "lblProfessorDepartment";
            lblProfessorDepartment.Size = new Size(30, 15);
            lblProfessorDepartment.TabIndex = 14;
            lblProfessorDepartment.Text = "สาขา";
            // 
            // gbStudentInfo
            // 
            gbStudentInfo.Controls.Add(butClearStudent);
            gbStudentInfo.Controls.Add(txtStudentDetails);
            gbStudentInfo.Controls.Add(btnAddStudent);
            gbStudentInfo.Controls.Add(txtGrade);
            gbStudentInfo.Controls.Add(txtDepartment);
            gbStudentInfo.Controls.Add(txtLastName);
            gbStudentInfo.Controls.Add(txtFirstName);
            gbStudentInfo.Controls.Add(lblGrade);
            gbStudentInfo.Controls.Add(lblDepartment);
            gbStudentInfo.Controls.Add(lblLastName);
            gbStudentInfo.Controls.Add(lblFirstName);
            gbStudentInfo.Controls.Add(txtStudentId);
            gbStudentInfo.Controls.Add(lblStudentId);
            gbStudentInfo.Location = new Point(36, 33);
            gbStudentInfo.Name = "gbStudentInfo";
            gbStudentInfo.Size = new Size(723, 107);
            gbStudentInfo.TabIndex = 16;
            gbStudentInfo.TabStop = false;
            gbStudentInfo.Text = "ข้อมูลนักศึกษา";
            // 
            // butClearStudent
            // 
            butClearStudent.Location = new Point(663, 14);
            butClearStudent.Name = "butClearStudent";
            butClearStudent.Size = new Size(54, 58);
            butClearStudent.TabIndex = 12;
            butClearStudent.Text = "ล้างข้อมูล";
            butClearStudent.UseVisualStyleBackColor = true;
            butClearStudent.Click += butClearStudent_Click;
            // 
            // txtStudentDetails
            // 
            txtStudentDetails.Location = new Point(402, 49);
            txtStudentDetails.Name = "txtStudentDetails";
            txtStudentDetails.Size = new Size(246, 23);
            txtStudentDetails.TabIndex = 11;
            // 
            // txtProfessorFirstName
            // 
            txtProfessorFirstName.Location = new Point(94, 20);
            txtProfessorFirstName.Name = "txtProfessorFirstName";
            txtProfessorFirstName.Size = new Size(100, 23);
            txtProfessorFirstName.TabIndex = 17;
            // 
            // txtProfessorLastName
            // 
            txtProfessorLastName.Location = new Point(276, 19);
            txtProfessorLastName.Name = "txtProfessorLastName";
            txtProfessorLastName.Size = new Size(100, 23);
            txtProfessorLastName.TabIndex = 18;
            // 
            // txtProfessorDepartment
            // 
            txtProfessorDepartment.Location = new Point(94, 49);
            txtProfessorDepartment.Name = "txtProfessorDepartment";
            txtProfessorDepartment.Size = new Size(100, 23);
            txtProfessorDepartment.TabIndex = 19;
            // 
            // btnAddProfessor
            // 
            btnAddProfessor.Location = new Point(400, 14);
            btnAddProfessor.Name = "btnAddProfessor";
            btnAddProfessor.Size = new Size(246, 32);
            btnAddProfessor.TabIndex = 20;
            btnAddProfessor.Text = "เพิ่มอาจารย์";
            btnAddProfessor.UseVisualStyleBackColor = true;
            btnAddProfessor.Click += btnAddProfessor_Click;
            // 
            // gbProFessorInfo
            // 
            gbProFessorInfo.Controls.Add(btnClearProFessors);
            gbProFessorInfo.Controls.Add(txtProfessorDetails);
            gbProFessorInfo.Controls.Add(btnAddProfessor);
            gbProFessorInfo.Controls.Add(txtProfessorDepartment);
            gbProFessorInfo.Controls.Add(txtProfessorLastName);
            gbProFessorInfo.Controls.Add(txtProfessorFirstName);
            gbProFessorInfo.Controls.Add(lblProfessorDepartment);
            gbProFessorInfo.Controls.Add(lblProfessorLastName);
            gbProFessorInfo.Controls.Add(lblProfessorFirstName);
            gbProFessorInfo.Location = new Point(37, 163);
            gbProFessorInfo.Name = "gbProFessorInfo";
            gbProFessorInfo.Size = new Size(722, 95);
            gbProFessorInfo.TabIndex = 22;
            gbProFessorInfo.TabStop = false;
            gbProFessorInfo.Text = "ข้อมูลอาจารย์";
            // 
            // btnClearProFessors
            // 
            btnClearProFessors.Location = new Point(662, 14);
            btnClearProFessors.Name = "btnClearProFessors";
            btnClearProFessors.Size = new Size(54, 58);
            btnClearProFessors.TabIndex = 13;
            btnClearProFessors.Text = "ล้างข้อมูล";
            btnClearProFessors.UseVisualStyleBackColor = true;
            btnClearProFessors.Click += btnClearProFessors_Click;
            // 
            // txtProfessorDetails
            // 
            txtProfessorDetails.Location = new Point(401, 53);
            txtProfessorDetails.Name = "txtProfessorDetails";
            txtProfessorDetails.Size = new Size(245, 23);
            txtProfessorDetails.TabIndex = 21;
            // 
            // btnShowTopStudent
            // 
            btnShowTopStudent.Location = new Point(37, 264);
            btnShowTopStudent.Name = "btnShowTopStudent";
            btnShowTopStudent.Size = new Size(513, 40);
            btnShowTopStudent.TabIndex = 23;
            btnShowTopStudent.Text = "แสดงนักศึกษาที่ได้เกรดสูงสุด";
            btnShowTopStudent.UseVisualStyleBackColor = true;
            btnShowTopStudent.Click += btnShowTopStudent_Click;
            // 
            // lblTopStudent
            // 
            lblTopStudent.AutoSize = true;
            lblTopStudent.Location = new Point(37, 325);
            lblTopStudent.Name = "lblTopStudent";
            lblTopStudent.Size = new Size(148, 15);
            lblTopStudent.TabIndex = 24;
            lblTopStudent.Text = "ใช้เเสดงนักศึกษาที่ได้เกรดสูงสุด";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(556, 264);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(203, 40);
            btnClear.TabIndex = 25;
            btnClear.Text = "ล้างข้อมูลทั้งหมด";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 450);
            Controls.Add(btnClear);
            Controls.Add(lblTopStudent);
            Controls.Add(btnShowTopStudent);
            Controls.Add(gbProFessorInfo);
            Controls.Add(gbStudentInfo);
            Name = "Form1";
            Text = "Form1";
            gbStudentInfo.ResumeLayout(false);
            gbStudentInfo.PerformLayout();
            gbProFessorInfo.ResumeLayout(false);
            gbProFessorInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentId;
        private TextBox txtStudentId;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblDepartment;
        private Label lblGrade;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtDepartment;
        private TextBox txtGrade;
        private Button btnAddStudent;
        private Label lblProfessorFirstName;
        private Label lblProfessorLastName;
        private Label lblProfessorDepartment;
        private GroupBox gbStudentInfo;
        private TextBox txtProfessorFirstName;
        private TextBox txtProfessorLastName;
        private TextBox txtProfessorDepartment;
        private Button btnAddProfessor;
        private GroupBox gbProFessorInfo;
        private Button btnShowTopStudent;
        private Label lblTopStudent;
        private Button btnClear;
        private TextBox txtStudentDetails;
        private TextBox txtProfessorDetails;
        private Button butClearStudent;
        private Button btnClearProFessors;
    }
}
