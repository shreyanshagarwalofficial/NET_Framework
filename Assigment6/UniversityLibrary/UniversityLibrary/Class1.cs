using System;

namespace UniversityLibrary
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

        public Student(int id, string name, string course)
        {
            StudentId = id;
            Name = name;
            Course = course;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student ID: " + StudentId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Course: " + Course);
        }
    }
}