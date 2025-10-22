using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE322_App_KAU.UniversityStudentClasses
{
    internal class Student
    {

        // Properties
        public string StudentName { get; private set; }
        public int StudentID { get; private set; }
        public double GPA { get; private set; }

        // Constructor
        public Student(string studentName, int studentID, double gpa)
        {
            StudentName = studentName;
            StudentID = studentID;
            GPA = gpa;
        }

        // Method to update the GPA of the student
        public void UpdateGPA(double newGPA)
        {
            GPA = newGPA;
        }
    }
}
