using System;

namespace Assignment_3
{
    class University
    {
        public class Department
        {
            public string DepName;
            public string HODName;
            public int FacMembers;
            public Department(string depName, string hodName, int facMembers)
            {
                DepName = depName;
                HODName = hodName;
                FacMembers = facMembers;
            }
        }

        static void Main17(string[] args)
        {
            University.Department dept =
                new University.Department("Computer Science", "Dr. Sachendra Sir", 10);
            Console.WriteLine("Dep" + dept.DepName);
            Console.WriteLine("hod" + dept.HODName);
            Console.WriteLine("Fac Mem" + dept.FacMembers);
        }
    }
}