namespace StudentManagement
{
    public partial class Form1 : Form
    {
        // รายการเก็บข้อมูลนักศึกษาและอาจารย์
        private List<Student> studentList = new List<Student>();
        private List<Professor> professorList = new List<Professor>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            // รับข้อมูลจาก TextBox
            string studentId = txtStudentId.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string department = txtDepartment.Text;
            double grade = Convert.ToDouble(txtGrade.Text);

            // สร้างนักศึกษาด้วยข้อมูลที่ได้รับ
            Student newStudent = new Student(studentId, firstName, lastName, department, grade);

            // เพิ่มนักศึกษาไปในรายการ
            studentList.Add(newStudent);

            // แสดงข้อมูลใน TextBox
            txtStudentDetails.AppendText(newStudent.ToString() + Environment.NewLine);

        }

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            // รับข้อมูลจาก TextBox
            string professorFirstName = txtProfessorFirstName.Text;
            string professorLastName = txtProfessorLastName.Text;
            string professorDepartment = txtProfessorDepartment.Text;

            // สร้างอาจารย์ด้วยข้อมูลที่ได้รับ
            Professor newProfessor = new Professor(professorFirstName, professorLastName, professorDepartment);

            // เพิ่มอาจารย์ไปในรายการ
            professorList.Add(newProfessor);

            // แสดงข้อมูลใน TextBox
            txtProfessorDetails.AppendText(newProfessor.ToString() + Environment.NewLine);

        }

        private void btnShowTopStudent_Click(object sender, EventArgs e)
        {
            // หานักศึกษาที่ได้เกรดสูงสุด
            Student topStudent = GetTopStudent();

            // แสดงข้อมูลนักศึกษาที่ได้เกรดสูงสุด
            lblTopStudent.Text = "นักศึกษาที่ได้เกรดสูงสุด: " + topStudent.ToString();
        }

        // ฟังก์ชันหานักศึกษาที่ได้เกรดสูงสุด
        private Student GetTopStudent()
        {
            Student topStudent = null;
            double highestGrade = 0;

            foreach (var student in studentList)
            {
                if (student.Grade > highestGrade)
                {
                    highestGrade = student.Grade;
                    topStudent = student;
                }
            }

            return topStudent;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // เคลียร์ข้อมูลใน TextBox และ Label
            txtStudentId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDepartment.Clear();
            txtGrade.Clear();
            txtProfessorFirstName.Clear();
            txtProfessorLastName.Clear();
            txtProfessorDepartment.Clear();
            txtStudentDetails.Clear();
            txtProfessorDetails.Clear();
            lblTopStudent.Text = string.Empty;
        }

        private void butClearStudent_Click(object sender, EventArgs e)
        {
            txtStudentId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtDepartment.Clear();
            txtGrade.Clear();
            txtStudentDetails.Clear();
        }

        private void btnClearProFessors_Click(object sender, EventArgs e)
        {
            txtProfessorFirstName.Clear();
            txtProfessorLastName.Clear();
            txtProfessorDepartment.Clear();
            txtProfessorDetails.Clear();
        }
    }
}


