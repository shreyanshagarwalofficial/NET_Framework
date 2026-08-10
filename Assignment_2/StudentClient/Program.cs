using StudentLibrary;
using System;

class Program
{
    static void Main()
    {
        Student student = new Student();

        // PUBLIC
        Console.WriteLine(student.Name);
        student.DisplayName();


        // PRIVATE
        // Console.WriteLine(student.age);
        // student.DisplayAge();


        // PROTECTED
        // Console.WriteLine(student.course);
        // student.DisplayCourse();


        // INTERNAL
        // Console.WriteLine(student.college);
        // student.DisplayCollege();


        // PROTECTED INTERNAL
        // Console.WriteLine(student.city);
        // student.DisplayCity();


        // PRIVATE PROTECTED
        // Console.WriteLine(student.rollNumber);
        // student.DisplayRollNumber();
    }
}