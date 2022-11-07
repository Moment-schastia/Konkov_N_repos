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
        public string Name { get => _name; set => _name = value; }

        public Shape(string Aname)
        {
            Aname = Name;
        }


        public abstract double GetVolumeShape();


        public virtual void ShapeInfo()
        {

        }


    }



    

}
