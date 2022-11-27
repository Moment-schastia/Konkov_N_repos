using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class Flower
    {
        public string Name;
        public float Cost;
        public string Color;

        public Flower(string name, float cost, string color)
        {
            Name = name;
            Cost = cost;
            Color = color;
        }
    }
}
