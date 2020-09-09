using System;
namespace FactoryPatternExample
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
    {
            switch (wheelCount)
            {
                case 2:
                    return new Motorcylce();
                case 3:
                    return new ThreeWheeler();

                case 4:
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}
