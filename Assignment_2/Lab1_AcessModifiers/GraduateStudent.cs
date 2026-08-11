using System;

namespace Lab1_AccessModifiers
{
    public class GraduateStudent : Student
    {
        public void ShowData()
        {
            Console.WriteLine("inheritance");
            Console.WriteLine(Name);
            Console.WriteLine(Department);
            Console.WriteLine(CGPA);
            Console.WriteLine(College);
            Console.WriteLine(Address);
            Console.WriteLine();
            Console.WriteLine("use Object ");
            Student student = new Student();
            Console.WriteLine(student.Name);
            Console.WriteLine(student.CGPA);
            Console.WriteLine(student.College);
        }
    }
}
