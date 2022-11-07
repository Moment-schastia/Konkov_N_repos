using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    internal class Ball: Shape
    {
        private string aNameBall;
        public double Radius;

        public Ball(string name, double radius): base(name)
        {
            aNameBall = name;
            Radius = radius;
        }

        public override double GetVolumeShape()
        {
            double volumeBall = Math.Round(((4 * Math.PI * Math.Pow(Radius, 3)) / 3));

            return volumeBall;
        }

        public override void ShapeInfo()
        {
            Console.WriteLine($"The Radius of the shape(Ball) {Name} is {Radius}, and the volume is {GetVolumeShape()}.");
        }

    }
}
