using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP3
{
    internal struct Student
    {
        public string Name;
        public int Age;


        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void StudentInfo()
        {
            Console.WriteLine($"The name of student - {Name}. The age of student - {Age}.");
        }
    }
}
