using CSharpFactoryMethod.Vehicles;

namespace CSharpFactoryMethod
{
    internal class Car : IVehicle
    {
        public Car() { }

        public void TransportInfo()
        {
            Console.WriteLine("Thi is Car");
        }
    }
}//The final(in this case) class wich might be created by cpecidic class (DevCar)
