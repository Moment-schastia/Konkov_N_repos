using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpOOP3
{
    internal class Pyramid: Shape
    {
        public string Name;
        public double Height;
        public double S;


        public Pyramid(string name, double height, double s) : base(name)
        {
            Name = name;
            Height = height;
            S = s;
        }


        public override double GetVolumeShape()
        {
            double volumePyramid = Math.Round((S / 3) * Height);
            return volumePyramid;
        }


        public override void ShapeInfo()
        {
            Console.WriteLine($"The height of the shape(Pyramid) {Name} is {Height} its base area is {S}, and the volume is {GetVolumeShape()}.");
        }




    }
}
