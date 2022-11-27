using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP2
{
    static class BookInfo
    {
        public static float CostPerPage (this Book bookIt) 
        {
            return bookIt.Cost / bookIt.Pages;
        }
        
        public static void InfoBookIt(this Book bookIt)
        {
             Console.WriteLine($"Here we have {bookIt.Tittle} that was written by {bookIt.Author} in {bookIt.Date}. In book {bookIt.Pages}. And the cost of the book just {bookIt.Cost} BYN"); 
        }

        public static double BooItCostWithDiscaunter(this Book bookIt, double discount = 0.17)
        {
            double discounted = bookIt.Cost - (bookIt.Cost * discount);
            return discounted;
        }
    }
}
