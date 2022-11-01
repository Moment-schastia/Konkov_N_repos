using System.Reflection;
using System.Security.Cryptography.X509Certificates;


// =========== TASK_1 ================

//Console.Write("Enter a quantity of food portions - ");
//float foodPortion = float.Parse(Console.ReadLine());

//Console.Write("Enter the cost - ");
//float foodCost = float.Parse(Console.ReadLine());

//Console.Write("Enter the discount - ");
//float discount = float.Parse(Console.ReadLine());

//var finSumm = new Homework_4().AnOrder(foodPortion, foodCost, discount);

//Console.WriteLine($"The final amount to the payment - {finSumm}");

//Console.ReadLine();


// =========== TASK_2 ================

//float commonDiscount = 15;

//Console.Write("Enter the wanted food - ");
//string foodName = Console.ReadLine();
//Console.Write("Enter the quantity of food portions - ");
//float foodPortion = float.Parse(Console.ReadLine());
//float foodCost = 8.99f;

//var foodFinCost = new Homework_4().AnOrder(foodPortion, foodCost, commonDiscount);

//Console.Write("Enter the wanted drink - ");
//string drinkName = Console.ReadLine();
//Console.Write("Enter the quantity of drink bottles - ");
//float drinkBottle = float.Parse(Console.ReadLine());
//float drinkCost = 1.99f;

//var drinkFinCost = new Homework_4().AnOrder(drinkBottle, drinkCost, commonDiscount);

//Console.Write("Enter the wanted souce - ");
//string souceName = Console.ReadLine();
//Console.Write("Enter a quantity of souces - ");
//float souce = float.Parse(Console.ReadLine());
//float souceCost = 0.8f;

//var souceFinCost = new Homework_4().AnOrder(souce, souceCost, commonDiscount);

//Console.WriteLine($" For all {foodName} - {foodFinCost}");
//Console.WriteLine($" For all {drinkName} - {drinkFinCost}");
//Console.WriteLine($" For all {souceName} - {souceFinCost}");

//var finSum = new Homework_4().SeveralItemCaunter(foodFinCost, drinkFinCost, souceFinCost);
//Console.WriteLine($"The final amount to the payment - {finSum}, with discount {commonDiscount}%");

//Console.ReadLine();

// ======= Task_3 ========

//float commonDiscount = 15;
//Console.Write("Enter the wanted food - ");
//string foodName = Console.ReadLine();
//float foodCost = 8.99f;

//var foodFinCost = new Homework_4().AnOrderOptionalQuantity(foodCost, commonDiscount);

//Console.Write("Enter the wanted drink - ");
//string drinkName = Console.ReadLine();
//float drinkCost = 1.99f;

//var drinkFinCost = new Homework_4().AnOrderOptionalQuantity(drinkCost, commonDiscount);

//Console.Write("Enter the wanted souce - ");
//string souceName = Console.ReadLine();
//float souceCost = 0.8f;

//var souceFinCost = new Homework_4().AnOrderOptionalQuantity(souceCost, commonDiscount);

//Console.WriteLine($" For all {foodName} - {foodFinCost}");
//Console.WriteLine($" For all {drinkName} - {drinkFinCost}");
//Console.WriteLine($" For all {souceName} - {souceFinCost}");

//var finSum = new Homework_4().SeveralItemCaunter(foodFinCost, drinkFinCost, souceFinCost);
//Console.WriteLine($"The final amount to the payment - {finSum}, with discount {commonDiscount}%");

//Console.ReadLine();

// ======= Task_4 ========

//Console.Write("Enter length of the side: ");
//int sideLength = int.Parse(Console.ReadLine());

//var trianglePerimetr = new Homework_4().PerimeterCaunter(sideLength, sideLength, sideLength);
//Console.WriteLine($"The perimetr of triangle is {trianglePerimetr}");

//var quadroPerimetr = new Homework_4().PerimeterCaunter(sideLength, sideLength, sideLength, sideLength);
//Console.WriteLine($"The perimetr of square is {quadroPerimetr}");

//var pectaPerimetr = new Homework_4().PerimeterCaunter(sideLength, sideLength, sideLength, sideLength, sideLength);
//Console.WriteLine($"The perimetr of square is {pectaPerimetr}");

//Console.ReadLine(); 

//======= Task_5 ========

//double sideTriangle = 12; 
//double height = 10.39;

//var triengleSquare = new Homework_4().SquareCounter(sideTriangle, height);
//Console.WriteLine($"Square of triangle is {triengleSquare} .");

//double radius = 14;

//var circleSquare = new Homework_4().SquareCounter(radius);
//Console.WriteLine($"Square of square is {circleSquare} .");

//Console.ReadLine();

//========= Task_6 ========
/*
Encapsulation. Windows is a closed system in which not all possible changes are available to users, unlike Linux.

Inheritance. Many games have a skill branch. In this branch, we first pump one skill, and another skill can continue pumping the first one, taking as a basis the capabilities of the first skill.

Polymorphism. Many games have character classes. There is an archer class and the archer's attack can be reassigned to a magician by replacing an arrow with a clot of magic.

Abstraction. In many films, especially with a small budget, the characters are shown in the simplest possible way, demonstrating only its key features and capabilities (the old Gadzila).
*/

new Homework_4();

class Homework_4
{
    public float AnOrder(float item, float itemCost, float discount)
    {
        float theSumCost = item * itemCost;
        float theDiscount = theSumCost * discount / 100;

        return theSumCost - theDiscount;
    }
    public float SeveralItemCaunter(params float[] orderedIems)
    {
        float result = 0;
        foreach (var n in orderedIems)
        {
            result += n;

        }
        return result;
    }
    public float AnOrderOptionalQuantity(float itemCost, float discount, float item = 10)
    {
        float theSumCost = item * itemCost;
        float theDiscount = theSumCost * discount / 100;

        return theSumCost - theDiscount;
    }
    public int PerimeterCaunter(params int[] sidesInArray)
    {
        int result = 0;
        foreach (var n in sidesInArray)
        {
            result += n;

        }
        return result;
    }
    public double SquareCounter(double sideTriangle, double height)
    {
        double traingleSquare = (sideTriangle * height) / 2;

        return traingleSquare;
    }
    public double SquareCounter(double radius)
    {
        double circleSquare = Math.PI * (radius * radius);

        return circleSquare;
    }
}
