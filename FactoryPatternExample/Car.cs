using System;
namespace FactoryPatternExample
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            Console.WriteLine("The car is driving! Vrrooom!");
        }


    }
}
