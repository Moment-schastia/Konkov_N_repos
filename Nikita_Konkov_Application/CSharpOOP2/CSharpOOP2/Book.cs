using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP2
{
   public class Book
    {
        public Book()
        {
            
        }
        public Book(string tittle)
        {
            Tittle = $"\"{tittle}\""; 
        }
        public Book(string tittle, string author, int pages, int date, float cost)
        {
            Tittle = tittle;
            Author = author;
            Pages = pages;
            Date = date;
            Cost = cost;
        }

        public string Tittle;
        public string Author { get; internal set; }
        public int Pages;
        public int Date;
        public float Cost;

        public static string copyright;


        // private geter int 
        private int _inStock = 21;
        public int InStock
        {
            get => _inStock;
        }

        //private seter int 
        private int _pageWithSecret;
        public int PageWithSecret
        {
            set => _pageWithSecret = value;
        }


        // all methods 

        public void IfAffordable()
        {
            if (Cost < 50)
            {
                Console.WriteLine("This book is affordable");
            } else if (Cost > 50)
            {
                Console.WriteLine("This book is too expensive");
            } else
            {
                Console.WriteLine("unexpected number");
            }
        }
        internal int AgeOfBook()
        {
            int age = 2022 - Date;
            return age;
        }
        private double PricePerPage()
        {
            return Cost / Pages;
        }
        public static void StatementOfVariousity() => Console.WriteLine("Books, for every taste and means.");
    }
}
