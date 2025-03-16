using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE322_App_KAU.UniversityStudentClasses
{
    internal class University
    {
        // Properties
        public string UniversityName { get; private set; }
        public List<Student> Students { get; private set; }

        // Static field to track total universities
        private static int totalUniversities = 0;

        // Constructor
        public University(string universityName)
        {
            UniversityName = universityName;
            Students = new List<Student>();
            totalUniversities++;  // Increment total universities when a new university is created
        }

        // Method to enroll a student in the university
        public void EnrollStudent(Student student)
        {
            Students.Add(student);
        }

        // Method to find a student by ID
        public Student FindStudentByID(int studentID)
        {
            foreach (var student in Students)
            {
                if (student.StudentID == studentID)
                {
                    return student;  // Return the student if found
                }
            }
            return null;  // Return null if student not found
        }

        // Static method to get the total number of universities
        public static int GetTotalUniversities()
        {
            return totalUniversities;
        }

    }
}
