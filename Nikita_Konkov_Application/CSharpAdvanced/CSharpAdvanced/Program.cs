#region Task 1
using CSharpAdvanced;
using CSharpOOP2;

List<string> week = new List<string> { "Monday", "Tuesday", "Wednsday", "Thusday", "Friday", "Saturday", "Sinday" };

Console.WriteLine(GetFirst(week));

T GetFirst<T>(List<T> list) => list.First();
#endregion

#region Task 2

RoseFlower rose = new RoseFlower("Rose", 12.5f, "Blue");
ChamomileFlower chamomile = new ChamomileFlower("Chamomile", 8.2f, "White with yellow center");

Console.Write($"Enter number of Roses -> ");
int roseNumber = int.Parse(Console.ReadLine());

Console.Write($"Enter number of Chamomiles -> ");
int chamoNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"{chamoNumber} {roseNumber}");

GetCheck(rose, roseNumber);
GetCheck(rose, chamoNumber);

#region Methods for flowers
float GetCost<T>(T flower, float number) where T : Flower
{
    float totalCost = flower.Cost * number;
    return totalCost;
}

void GetCheck<T>(T flower, int flowerNumber) where T : Flower
{
    Console.WriteLine($"Number of {flower.Name} - {flowerNumber}; The total price of {flower.Name} - {GetCost(flower, flowerNumber)}");
}
#endregion 
#endregion

#region Task 3

var customRose = new CustomFlower<Flower>();
customRose.GetNewCost(rose);
customRose.ChangeColor(rose);

var customChamo = new CustomFlower<Flower>();
customChamo.GetNewCost(chamomile);
customChamo.ChangeColor(chamomile);

GetCheck(rose, roseNumber);
GetCheck(rose, chamoNumber);

Console.ReadLine();
#endregion

#region Task 4

Book bookIt = new Book { Tittle = "It", Author = "Stephen King", Pages = 1243, Date = 1986, Cost = 52.65f };

bookIt.InfoBookIt();

bookIt.BooItCostWithDiscaunter();

Console.WriteLine($"Cost for one page - {bookIt.CostPerPage()} BYN");
#endregion