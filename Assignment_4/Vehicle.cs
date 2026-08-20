using System;

namespace Assignment_3
{
    internal class Vehicles
    {
        static void Main8(string[] args)
        {
            Vehicle car = new Vehicle("Rolls Royce", "Phantom", 2026);

            car.DisplayInfo();
            car.Start();
            car.Stop();
        }
    }
}
