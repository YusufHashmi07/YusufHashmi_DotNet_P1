using System;

namespace StudentAdmissionManagement
{
    class Student
    {
        // Private data members (Access Modifier)
        private int studentId;
        private string name;
        private int age;
        private string course;

        // Constructor
        public Student(int id, string studentName, int studentAge, string studentCourse)
        {
            studentId = id;
            name = studentName;
            age = studentAge;
            course = studentCourse;
        }

        // Public method to display student details
        public void DisplayDetails()
        {
            Console.WriteLine("\n----- Student Admission Details -----");
            Console.WriteLine("Student ID: " + studentId);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + course);
        }
    }
}