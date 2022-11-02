using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    internal class Cylinder: Shape
    {
        public string Name;
        public double Height;
        public double Radius;


        public Cylinder(string name, double height, double radius) : base(name)
        {
            Name = name;
            Height = height;
            Radius = radius;
        }


        public override double GetVolumeShape()
        {
            double volumeCylinder = Math.PI * Math.Pow(Radius, 2) * Height;
            return volumeCylinder;
        }


        public override void ShapeInfo()
        {
            Console.WriteLine($"The height of the shape(Pyramid) {Name} is {Height} its radius is {Radius}, and the volume is {GetVolumeShape()}.");
        }

    }
}
