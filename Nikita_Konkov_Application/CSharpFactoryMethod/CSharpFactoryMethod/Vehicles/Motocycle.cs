using CSharpFactoryMethod.Vehicles;

namespace CSharpFactoryMethod
{
    internal class Motocycle : IVehicle
    {
        public Motocycle() { }

        public void TransportInfo()
        {
            Console.WriteLine("This is Motobyke");
        }
    }
} //The final(in this case) class wich might be created by cpecidic class (DevMoto)
