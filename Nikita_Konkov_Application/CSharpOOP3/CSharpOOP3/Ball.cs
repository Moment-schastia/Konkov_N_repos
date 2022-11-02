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
        internal string Name;
        internal double Radius;


        public Ball(string name, double radius): base(name)
        {
            Name = name;
            Radius = radius;
        }


        public override double GetVolumeShape()
        {
            double volumeBall = (1.33333 * Math.PI) * Math.Pow(Radius, 3);

            return volumeBall;
        }


        public override void ShapeInfo()
        {
            Console.WriteLine($"The Radius of the shape(Ball) {Name} is {Radius}, and the volume is {GetVolumeShape()}.");
        }









        //public Ball(string name, string dtype, double volume, double perimetr) : base(name, dtype)
        //{
        //  Volume = volume;
        //  Perimetr = perimetr;
        //}

        //public override string color => base.color ;

        //public override void GetDiretionsType()
        //{
        //    Console.WriteLine("This unpleasant type is 3d always");
        //}

    }
}
