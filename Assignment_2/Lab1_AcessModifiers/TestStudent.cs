using System;

namespace Lab1_AccessModifiers
{
    public class TestStudent
    {
        public void LabEx()
        {
            Student student = new Student();

            Console.WriteLine("Accessible Members:");
            Console.WriteLine("Name:" + student.Name);
            Console.WriteLine("CGPA:" + student.CGPA);
            Console.WriteLine("College:" + student.College);
            Console.WriteLine();
            Console.WriteLine("Inaccessible Members:");
            // Console.WriteLine("Age : " + student.Age);
            // Console.WriteLine("Department: " + student.Department);
            // Console.WriteLine("Address4: " + student.Address);
        }
    }
}
