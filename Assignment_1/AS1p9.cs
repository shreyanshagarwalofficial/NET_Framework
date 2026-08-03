using System;

namespace Lecture1
{
    internal class AS1p9
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number N:");
            int N = Convert.ToInt32(Console.ReadLine());
            int original = N;
            int reversed = 0;

            while (N > 0)
            {
                int digit = N % 10;
                reversed = reversed * 10 + digit;
                N /= 10;
            }

            if (original == reversed)
                Console.WriteLine($"{original} is a Palindrome Number");
            else
                Console.WriteLine($"{original} is Not a Palindrome Number");

            Console.WriteLine("Developed By Shreyansh Agarwal (12584200182)");
        }
    }
}
