using System;
namespace FactoryPatternExample
{
    public class ThreeWheeler : IVehicle
    {
        public ThreeWheeler()
        {
        }

        public void Drive()
        {
            Console.WriteLine("This is 'Merica we call those trikes!");
        }


    }
}
