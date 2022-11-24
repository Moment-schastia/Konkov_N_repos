namespace CSharpFactoryMethod
{
    internal class DevMoto : IDeveloper
    {
        public Motocycle Create()
        {
            return new Motocycle();
        }
    }
} // Developers class for creating of cpecific type of vehicles(Motocycle)
