using System;

namespace Lecture1
{
    internal class As1p8
    {
        static void Main(string[] args) { 
            Console.WriteLine("Enter a number N:");
            int N = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            if (N <= 1) 
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(N); i++)   
                {
                    if (N % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                    Console.WriteLine($"{N} is Prime");
                else
                    Console.WriteLine($"{N} is Not Prime");
            }

            Console.WriteLine("Developed By Shreyansh Agarwal (12584200182)");
        }
    }
}
