using System;

namespace Assignment_3
{
    class Student
    {
        public int RollNumber;
        public string Name;
        public string Course;
        public int Semester;
        public Student(int rollNumber, string name, string course, int semester)
        {
            RollNumber = rollNumber;
            Name = name;
            Course = course;
            Semester = semester;
        }
    }
    class Record
    {
        static void Main15(string[] args)
        {
            Student s1 = new Student(182, "Surya", "MCA", 3);
            Student s2 = new Student(182, "Surya", "MCA", 3);
            Console.WriteLine("Student1:" + s1.Name);
            Console.WriteLine("Student2:" + s2.Name);
            if (s1.RollNumber == s2.RollNumber && s1.Name == s2.Name && s1.Course == s2.Course &&s1.Semester == s2.Semester){
                Console.WriteLine("Both students are equal");
           }
            else{
                Console.WriteLine("Students are notequal");
            }
Console.ReadLine();
        }
    }
}