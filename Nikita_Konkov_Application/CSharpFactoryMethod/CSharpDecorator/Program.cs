using CSharpDecorator;

IGigantosaurus gigantosaurus = new Gigantosaurus();
gigantosaurus = new LoudGigantosarusDecorator(gigantosaurus);

Console.WriteLine(gigantosaurus.Roar());

gigantosaurus = new ExtraLoudGigantosaurusDecorator(gigantosaurus);

Console.WriteLine(gigantosaurus.Roar());

Console.ReadLine();