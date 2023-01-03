using CSharpException;

Console.WriteLine("Enter three sides of triangle:");
Triangle triangle = new Triangle();

int firstSide = int.Parse(Console.ReadLine());
int secondSide = int.Parse(Console.ReadLine());
int thirdSide = int.Parse(Console.ReadLine());
do
{
    try
    {
        triangle.FirstSide = firstSide;

        triangle.SecondSide = secondSide;

        triangle.ThirdSide = thirdSide;
    }

    catch (UnsuitableZeroValue ex)
    {
        Console.WriteLine(ex.Message);

        firstSide = triangle.ZeroCheck(firstSide);
        secondSide = triangle.ZeroCheck(secondSide);
        thirdSide = triangle.ZeroCheck(thirdSide);
    }

} while (triangle.IsZero(firstSide) || triangle.IsZero(secondSide) || triangle.IsZero(thirdSide));

try
{
    triangle.SideCheck(firstSide, secondSide, thirdSide);
}

catch (OversizedTriangeSideException ex)
{
    Console.WriteLine(ex.Message);
}

catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("SUCCESS!");

Console.ReadLine();