using System.Linq;
using System.Collections;
using System.Transactions;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Collections.Specialized;
using CSharpOOP2;
using System.Net;


// Task 9 
//Book Somebook = new Book();

// Task 8
//List<string> linesList = new List<string>
//{
//    "Success is the child of audacity",
//    "The mind is everything. What you think you become",
//    "A wolf is weaker than а lion, but he doesn't perform in the circus"
//};

//linesList.Sum();

// Task 7 
//List<int> numbersList = new List<int> { 3, 4, 54, 21, 16, 44, 65, 33, 11, 6 };
//Console.Write("Enter one of listed nember: ");
//int userNamber = int.Parse(Console.ReadLine());

//bool numberChecker = numbersList.Any(num => num == userNamber);

//if (numberChecker)
//    Console.WriteLine("You entered number from the list!");
//else 
//    Console.WriteLine("Incorrect!");

// Task 6
//List<int> numbersList = new List<int> { 3, 4, 16, 21, 16, 4, 65, 3, 21, 6 };

//var umicNumbers = numbersList.Distinct().Reverse();

//foreach (var l in umicNumbers)
//    Console.WriteLine(l);

//Console.ReadLine();

// Task 5
// YOU miss one HUNDRED percents OF THE SHOTS you do not take
//Console.Write("Enter phras: ");
//string startPhrase = Console.ReadLine();
//string[] arrayPhrase = startPhrase.Split( new char[] {' '});

//List<string> listedPhrase = new List<string>();

//foreach (var l in arrayPhrase)
//    listedPhrase.Add(l);

//var selectedPhrase = listedPhrase.Where(l => l.All(char.IsLower));
//foreach (var l in selectedPhrase)
//    Console.WriteLine(l);


//  ================= Task 4
//List<string> cities = new List<string>
//{
//    "Gomel",
//    "Grodno",
//    "Molodechno",
//    "Minsk",
//    "Pinsk",
//    "Orsha"
//};

//var selectedCities = cities.Where(c => c.StartsWith("G") && c.EndsWith("o"));

//foreach (var c in selectedCities)
//   Console.WriteLine(c);

// ==================== Task 3
//List<string> names = new List<string>
//{
//    "Nadji",
//    "Pain",
//    "Itachi",
//    "Madara",
//    "Hashirama"
//};

//var evenNaames = from n in names
//                 where n.Length % 2 == 0
//                 orderby n
//                 select n;

//foreach (var n in evenNaames)
//    Console.WriteLine(n);

// =====================Task 2 
//List<int> numbersToSelect = new List<int> { -7, 12, -11, 8, 14, -10, 11, -13, -15, 7 };

//var selectedNumbers = numbersToSelect.Where(num => num < 10 || num < 0).OrderBy(num => num);

//foreach (var num in selectedNumbers)
//    Console.WriteLine(num);

// =====================Task 1
//List<int> numbersToSelect = new List<int> { 3, 4, 54, 21, 16, 44, 65, 33, 11, 6 };

//var selectedNumbers = from num in numbersToSelect
//                       where num % 3 == 0
//                       select num;

//foreach (var num in numbersToSelect)
//    Console.WriteLine(num);
