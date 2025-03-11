using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentManagement;

namespace StudentManagement
{
    public class Student
    {
        public string StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public double Grade { get; set; }

        public Student(string studentId, string firstName, string lastName, string department, double grade)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Department = department;
            Grade = grade;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}, สาขาวิชา: {Department}, เกรด: {Grade}";
        }
    }
}
