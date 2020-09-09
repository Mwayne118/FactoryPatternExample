using System;
namespace FactoryPatternExample
{
    public class Motorcylce : IVehicle
    {
        public Motorcylce()
        {
        }

        public void Drive()
        {
            Console.WriteLine("I dont even brake when I'm backing up");
            Console.WriteLine("Toot toot toot");

        }

    }
}
