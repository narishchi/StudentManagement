using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class GradeManager
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public void AddStudent(Student student)
        {
            Students.Add(student);
        }

        public Student GetHighestGradeStudent()
        {
            return Students.OrderByDescending(s => s.Grade).FirstOrDefault();
        }

        public void ShowAllStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
