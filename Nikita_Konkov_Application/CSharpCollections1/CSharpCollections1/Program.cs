using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Linq;


////======================== Task 5
//string country1 = "USA";
//string capital1 = "VASHINGTON";

//string country2 = "FRANCE";
//string capital2 = "PARIG";

//string country3 = "BELARUS";
//string capital3 = "MINSK";

//string country4 = "UKRAINE";
//string capital4 = "KIEV";

//string country5 = "NEW ZELAND";
//string capital5 = "WELLINGTON";

//var countriesAndCapitals = new Dictionary<string, string>();
//countriesAndCapitals.Add(country1, capital1);
//countriesAndCapitals.Add(country2, capital2);
//countriesAndCapitals.Add(country3, capital3);
//countriesAndCapitals.Add(country4, capital4);
//countriesAndCapitals.Add(country5, capital5);


//var capitalsAndCountries = new Dictionary<string, string>();

//foreach (var el in countriesAndCapitals)
//{
//    capitalsAndCountries.Add(el.Value, el.Key);

//    Console.WriteLine($"{el.Key} : {el.Value}");
//}

//foreach (var el in capitalsAndCountries)
//{
//    Console.WriteLine($"{ el.Key} : {el.Value}");
//}

//Console.ReadLine();

//=====================Task 4 

Citizen nickCitizen = new Citizen
{
Name = "Nick",
LastName = "Sadov",
FatherName = "Petrovich",
AdresStreet = "Romanovskaya",
AdresHouse = 44,
Birthday = new DateTime(1991, 01, 12)
};

Citizen robertCitizen = new Citizen
{
Name = "Robert",
LastName = "Gadov",
FatherName = "Nikolaevich",
AdresStreet = "Sovetskaya",
AdresHouse = 44,
Birthday = new DateTime(2001, 11, 10)
};

Citizen ameliCitizen = new Citizen
{
Name = "Ameli",
LastName = "Rose",
FatherName = "Ivanovna",
AdresStreet = "Belino",
AdresHouse = 44,
Birthday = new DateTime(2005, 01, 01)
};

Citizen gotaroCitizen = new Citizen
{
Name = "Gotaro",
LastName = "Goske",
FatherName = "Gokevich",
AdresStreet = "Krestyanskya",
AdresHouse = 12,
Birthday = new DateTime(1975, 08, 07)
};

Citizen aleksandrCitizen = new Citizen
{
Name = "Aleksandr",
LastName = "Dyaktyarev",
FatherName = "Evgenevich",
AdresStreet = "Krestyanskya",
AdresHouse = 12,
Birthday = new DateTime(1992, 09, 11)
};

Citizen katyCitizen = new Citizen
{
Name = "Katy",
LastName = "Grose",
FatherName = "Romanovna",
AdresStreet = "Adskaya",
AdresHouse = 12,
Birthday = new DateTime(2008, 10, 22)
};

List<Citizen> allOfCitizens = new List<Citizen> { nickCitizen, ameliCitizen, robertCitizen, gotaroCitizen, aleksandrCitizen, katyCitizen };

List<Citizen> votersCitizen = allOfCitizens
    .FindAll(c => c.GetAge(c.Birthday) >= 18);
votersCitizen.Sort((c, v) => c.AdresStreet.CompareTo(v.AdresStreet));

class Citizen
{
    public string Name;
    public string LastName;
    public string FatherName;
    public string AdresStreet;
    public int AdresHouse;
    public DateTime Birthday;

    public Citizen()
    {

    }

    public int GetAge(DateTime birth)
    {
        DateTime dateTime = new DateTime(1, 1, 1);
        var timespan = (DateTime.Now - birth).Duration();
        int age = (dateTime + timespan).Year - 1;
        return age;
    }
}


//=================================Task 3

//List<string> lastNames = new List<string>();
//lastNames.Add("Peterson");
//lastNames.Add("Holland");
//lastNames.Add("Stathem");
//lastNames.Add("Dyllan");
//lastNames.Add("McGregor");
//lastNames.Add("Mercury");
//lastNames.Add("Horlamov");
//lastNames.Add("Annistom");
//lastNames.Sort();

//foreach (var element in lastNames)
//{
//    Console.WriteLine(element);
//}


//======================================Task 2

//int[] startArr = { 6, 15, 54, 7, 41, 2, 4, 89, 33, 5, 12 };
//int maxNum = startArr[0];
//int minNum = startArr[0];

//for (int i = 0; i < startArr.Length; i++)
//{
//    if (startArr[i] > maxNum)
//    {
//        maxNum = startArr[i];
//    } else if (startArr[i] < minNum) 
//    {
//        minNum = startArr[i];
//    }

//}
//Console.WriteLine(maxNum - minNum);
//Console.ReadLine();

// ==================================== Task 1

//int[] startArr = { 6, 15, 54, 7, 41, 2, 0, 4, 89, 33, 5, 12 };
//Array.Sort(startArr);

//int count = 0;

//for (int i = 0; i < startArr.Length; i++)
//{

//    if (startArr[i] % 2 == 0 && startArr[i] >= 0)
//    {
//        count++;
//    }
//}

//    int[] evenArr = new int[count];

//for (int i = 0, j = 0; i < startArr.Length; i++)
//{
//    if (startArr[i] % 2 == 0 && startArr[i] >= 0)
//    {
//        evenArr[j] = startArr[i];
//        Console.WriteLine(evenArr[j]);
//        j++;
//    }
//}

//for (int i = 0; i < startArr.Length; i++)
//{

//    if (startArr[i] % 2 != 0 && startArr[i] != 0)
//    {
//        count++;
//    }
//}

//int[] oddArr = new int[count];

//for (int i = 0, j = 0; i < startArr.Length; i++)
//{
//    if (startArr[i] % 2 != 0 && startArr[i] >= 0)
//    {
//        oddArr[j] = startArr[i];
//        Console.WriteLine(oaddArr[j]);
//        j++;
//    }
//}

//Console.ReadLine();