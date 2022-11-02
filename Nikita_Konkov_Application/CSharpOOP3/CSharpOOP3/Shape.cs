using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    abstract class Shape
    {
        private string _name;


        public Shape(string Name)
        {
            _name = Name;
        }


        public abstract double GetVolumeShape();


        public virtual void ShapeInfo()
        {

        }











        //public string Name;
        //public string Dtype;
        //public double Volume;
        //public double Perimetr;
        //private string _color = "blue";



        //public Shape(string name, string dtype)
        //{
        //    Name = name;
        //    Dtype = dtype;
        //}

        //public virtual string color 
        //{ 
        //    get
        //    { return _color;}
        //}

        //public virtual void GetDiretionsType()
        //{
        //    Console.WriteLine($"Direction type is {Dtype}");
        //}

    }



    

}
