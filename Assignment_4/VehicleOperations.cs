using System;

namespace Assignment_3
{
    internal partial class Vehicle
    {
        public void Start()
        {
            Console.WriteLine($"{Brand} {Model} is starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} {Model} is stopping...");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Vehicle: {Brand}, Model: {Model}, Year: {Year}");
        }
    }
}
