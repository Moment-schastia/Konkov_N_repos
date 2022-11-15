#region

using CSharpOOP2;
using System;


//1st obj ===================================================================
Book bookfightClub = new Book();
bookfightClub.Tittle = "Fight club";
bookfightClub.Author = "Chuck Palahniuk";
bookfightClub.Pages = 155;
bookfightClub.Date = 1996;
bookfightClub.Cost = 19.57f;

bookfightClub.IfAffordable();



//2nd obj ===================================================================
Book bookIt = new Book{ Tittle = "It", Author = "Stephen King", Pages = 1243, Date = 1986, Cost = 52.65f};

bookIt.IfAffordable();

// var proportionIt = bookIt.PricePerPage(); - Error Line

var ageOfIt = bookIt.AgeOfBook(); // internal method
Console.WriteLine(ageOfIt);

// bookIt.InStock = 25;  - Error Line
var books_It_left = bookIt.InStock; // Here the tittle of the book was separated by sign '_' to make it more readable 
Console.WriteLine($"\"{bookIt.Tittle}\" in our posession {books_It_left}");

// Console.WriteLine(bookIt.PageWithSecret)   - Error Line
bookIt.PageWithSecret = 777;

// the method wich takes bookIt (Author, Tittle etc)
BookInfo.InfoBookIt(bookIt);

// the method wich takes bookIt Cost and return discaunted cost
var deccontedCost = BookInfo.BooItCostWithDiscaunter(bookIt);
Console.WriteLine($"\"{bookIt.Tittle}\" is sheaper now - {deccontedCost}");



//3d obj ===================================================================
Book bookNausea = new Book("Nausea", "Jean-Paul Sartre", 253, 1938, 21.30f);

bookNausea.IfAffordable();



//4d obj
Book bookMetamorphosis = new Book { Tittle = "Metamorphosis", Author = "Franz Kafka", Pages = 30, Date = 1915};

bookMetamorphosis.IfAffordable();



// static property 
Book.copyright = "Copyrights are protected";
Console.WriteLine(Book.copyright);

//static method 
Book.StatementOfVariousity();

// static method of static class BookInfo  
BookInfo.BookUseWarning();

Console.ReadLine();
#endregion
