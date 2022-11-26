using CSharpFactoryMethod.Vehicles;

namespace CSharpFactoryMethod
{
    internal class Track : IVehicle
    {
        public Track() { }

        public void TransportInfo()
        {
            Console.WriteLine("This is Track");
        }
    }
} //The final(in this case) class wich might be created by cpecidic class (DevCar)
