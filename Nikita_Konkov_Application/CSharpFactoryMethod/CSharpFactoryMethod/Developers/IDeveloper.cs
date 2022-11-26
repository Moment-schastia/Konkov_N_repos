namespace CSharpFactoryMethod
{
    public interface IDeveloper
    {
        public virtual object Create(){ return new Object(); }
    }
} //  a common interface for developers, classes can inherit common features from this interface 
