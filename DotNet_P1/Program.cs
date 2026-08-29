using System;

namespace StudentAdmissionManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== STUDENT ADMISSION MANAGEMENT SYSTEM =====");

            // Taking input from user
            Console.Write("Enter Student ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course Name: ");
            string course = Console.ReadLine();

            // Creating object and calling constructor
            Student student1 = new Student(id, name, age, course);

            // Calling method
            student1.DisplayDetails();

            Console.ReadKey();
        }
    }
}