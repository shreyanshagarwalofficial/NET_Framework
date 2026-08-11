using System;
using StudentLibrary;

namespace StudentClient
{
    public class ResearchStudent : Student
    {
        public void InheritMem()
        {
            Console.WriteLine("Accessible Members");
            Console.WriteLine(Name);
            DisplayName();
            Console.WriteLine(course);
            DisplayCourse();
            Console.WriteLine(city);
            DisplayCity();
            Console.WriteLine();
            Console.WriteLine("Inaccessible Members");
            // Console.WriteLine(age);
            // DisplayAge();
            // Console.WriteLine(college);
            // DisplayCollege();
            // Console.WriteLine(rollNumber);
            // DisplayRollNumber();
        }
    }
}
