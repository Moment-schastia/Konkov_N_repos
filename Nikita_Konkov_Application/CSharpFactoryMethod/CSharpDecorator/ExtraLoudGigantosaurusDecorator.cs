namespace CSharpDecorator
{
    internal class ExtraLoudGigantosaurusDecorator : IGigantosaurus
    {
        private IGigantosaurus _gigantosaurus;

        public ExtraLoudGigantosaurusDecorator(IGigantosaurus gigantosaurus)
        {
            _gigantosaurus = gigantosaurus;
        }

        public string Roar()
        {
            return _gigantosaurus.Roar().ToUpper().Insert(0, "AAAA");
        }
    }
} // The class for "decorating" of objects, in this case modifies the Roar method
