using System;

namespace Lecture1
{
    internal class AS1P10
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("1. Check Even/Odd");
                Console.WriteLine("2. Find Largest of Three Numbers");
                Console.WriteLine("3. Calculate Factorial");
                Console.WriteLine("4. Exit");
 
         int op= Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.Write("Enter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        if (num % 2 == 0)
                            Console.WriteLine($"{num} is Even");
                        else
                            Console.WriteLine($"{num} is Odd");
                        break;

                    case 2:
                        Console.Write("Enter first number: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter second number: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter third number: ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        int largest = (a > b) ? (a > c ? a : c) : (b > c ? b : c);
                        Console.WriteLine($"Largest number is {largest}");
                        break;

                    case 3:
                        Console.Write("Enter a number: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        long fact = 1;
                        for (int i = 1; i <= n; i++)
                            fact *= i;
                        Console.WriteLine($"Factorial of {n} is {fact}");
                        break;

                    case 4:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            } while (op!=4)

            Console.WriteLine("Developed By Shreyansh Agarwal (12584200182)");
        }
    }
}
