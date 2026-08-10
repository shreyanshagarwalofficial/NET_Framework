using System;

namespace StudentLibrary
{
    public class Student
    {
        // Public field
        public string Name = "Shreyansh";

        // Private field
        private int age = 21;

        // Protected field
        protected string course = "MCA";

        // Internal field
        internal string college = "GLA University";

        // Protected internal field
        protected internal string city = "Agra";

        // Private protected field
        private protected string rollNumber = "MCA001";

        // Public method
        public void DisplayName()
        {
            Console.WriteLine("Name: " + Name);
        }

        // Private method
        private void DisplayAge()
        {
            Console.WriteLine("Age: " + age);
        }

        // Protected method
        protected void DisplayCourse()
        {
            Console.WriteLine("Course: " + course);
        }

        // Internal method
        internal void DisplayCollege()
        {
            Console.WriteLine("College: " + college);
        }

        // Protected internal method
        protected internal void DisplayCity()
        {
            Console.WriteLine("City: " + city);
        }

        // Private protected method
        private protected void DisplayRollNumber()
        {
            Console.WriteLine("Roll Number: " + rollNumber);
        }
    }
}