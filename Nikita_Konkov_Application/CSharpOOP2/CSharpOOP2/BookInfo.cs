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
        
        public static void InfoBookIt(Book bookIt) // out of fantasy, sorry
        {
             Console.WriteLine($"Here we have {bookIt.Tittle} that was written by {bookIt.Author} in {bookIt.Date}. In book {bookIt.Pages}. And the cost of the book just {bookIt.Cost}");
           
        }
        public static double BooItCostWithDiscaunter(Book bookIt, double discount = 0.17)
        {
            double discounted = bookIt.Cost - (bookIt.Cost * discount);
            return discounted;
        } 
        internal static void BookUseWarning()
        {
            Console.WriteLine("Read only with a good lighting and don't be ashamed of using glasses");

        }


    
    
    
    
    
    }

}
