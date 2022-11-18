using CSharpException;

try
{
    int firstSide = int.Parse(Console.ReadLine());
    int secondSide = int.Parse(Console.ReadLine());
    int thirdSide = int.Parse(Console.ReadLine());

    Triangle triangle = new Triangle(firstSide, secondSide, thirdSide);
}
catch (OversizedTriangeSideException ex)
{
    Console.WriteLine(ex.Message); 
}
Console.WriteLine("SUCCESS");

Console.ReadLine();