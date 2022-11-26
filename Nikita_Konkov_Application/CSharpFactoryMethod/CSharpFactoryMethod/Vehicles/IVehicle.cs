namespace CSharpFactoryMethod.Vehicles
{
    public interface IVehicle
    {
        public virtual void TransportInfo()
        {
            Console.WriteLine("Thi is some trans");
        }
    }
} // a common interface for vehicles, classes can inherit common features from this interface
