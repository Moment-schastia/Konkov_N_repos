namespace CSharpFactoryMethod
{
    internal class DevCar : IDeveloper
    {
        public Car Create()
        {
            return new Car();
        }
    }
} // Developers class for creating of cpecific type of vehicles(Car)
