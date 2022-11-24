namespace CSharpFactoryMethod
{
    public class DeveloperUnycicle : IDeveloper
    {
        public Unycicle Create()
        {
            return new Unycicle();
        }
    }
} // Developers class for creating of cpecific type of vehicles(Unycicle)
