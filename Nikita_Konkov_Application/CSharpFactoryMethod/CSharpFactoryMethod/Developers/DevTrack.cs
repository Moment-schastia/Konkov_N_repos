namespace CSharpFactoryMethod
{
    internal class DevTrack : IDeveloper
    {
        public Track Create()
        {
            return new Track();
        }
    }
} // Developers class for creating of cpecific type of vehicles(Track)
