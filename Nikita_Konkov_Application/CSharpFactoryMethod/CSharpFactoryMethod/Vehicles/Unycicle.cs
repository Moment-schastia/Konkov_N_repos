using CSharpFactoryMethod.Vehicles;

namespace CSharpFactoryMethod
{
    public class Unycicle : IVehicle
    { 
        public Unycicle() { }

        public void TransportInfo()
        {
            Console.WriteLine("this is Unycicle");
        }
    }
} // The final(in this case) class wich might be created by cpecidic class (DeveloperUnycicle)
