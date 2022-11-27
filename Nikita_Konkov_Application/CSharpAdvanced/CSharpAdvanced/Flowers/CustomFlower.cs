using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class CustomFlower<T> where T : Flower
    {
        public int costUp = 15;
        
        public string ChangeColor(T flower) 
        {
            Console.Write($"Enter new color for {flower.Name}: ");
            flower.Color = Console.ReadLine();
            return flower.Color;
        }

        public float GetNewCost(T flower)
        {
            float newcost = flower.Cost + (flower.Cost * costUp / 100);
            flower.Cost = newcost;
            return flower.Cost;
        } 

    }
}
