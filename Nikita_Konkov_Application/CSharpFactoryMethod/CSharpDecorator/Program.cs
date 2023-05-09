using CSharpDecorator;

IGigantosaurus gigantosaurus = new Gigantosaurus();
gigantosaurus = new LoudGigantosarusDecorator(gigantosaurus);

Console.WriteLine(gigantosaurus.Roar());

gigantosaurus = new ExtraLoudGigantosaurusDecorator(gigantosaurus);

Console.WriteLine(gigantosaurus.Roar());

Console.ReadLine();


abstract class Quest
{
    protected string Name;

    public string GetName()
    {
        return Name;
    }
}

class Acatmane : Quest
{
    public Acatmane()
    {
        Name = "WTF";
    }
}