using Microsoft.VisualBasic;
using System;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;


new Homework_2().Task_3();

class Homework_2
{
    public void Task_1()
    {
        //int enteredNumber = Convert.ToInt32(Console.ReadLine());

        //if (enteredNumber % 2 == 0 && enteredNumber % 5 == 0)
        //{
        //    Console.WriteLine("TuttiFrutti");
        //}
        //else if (enteredNumber % 5 == 0)
        //{
        //    Console.WriteLine("Frutti");
        //}
        //else if (enteredNumber % 2 == 0)
        //{
        //    Console.WriteLine("Tutti");
        //}
        //else
        //{
        //    Console.WriteLine("Сan’t be divided on 2 or 5");
        //}

        //Console.ReadLine();

    }
    public void Task_2()
    {

        //int lessnum = Convert.ToInt32(Console.ReadLine());
        //int biggernum = Convert.ToInt32(Console.ReadLine());

        //for (int i = lessnum; i <= biggernum; i++)
        //{
        //    if (i % 2 == 0 && i % 5 == 0)
        //    {
        //        Console.WriteLine("TuttiFrutti");
        //    }
        //    else if (i % 5 == 0)
        //    {
        //        Console.WriteLine("Frutti");
        //    }
        //    else if (i % 2 == 0)
        //    {
        //        Console.WriteLine("Tutti");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Сan’t be divided on 2 or 5");
        //    }
        //}

        //Console.ReadLine();

    }
    public void Task_3()
    {
        int firstNum = Convert.ToInt32(Console.ReadLine());
        int secondNum = Convert.ToInt32(Console.ReadLine());

        if (firstNum > secondNum)
        {
            Console.WriteLine($"{firstNum} is bigger");

            for (int i = secondNum; i <= firstNum; i++)
            {
                if (i % 2 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("TuttiFrutti");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Frutti");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("Tutti");
                }
                else
                {
                    Console.WriteLine("Сan’t be divided on 2 or 5");
                }
            }
        }
        else if (secondNum > firstNum)
        {
            Console.WriteLine($"{secondNum} is bigger");

            for (int i = firstNum; i <= secondNum; i++)
            {
                if (i % 2 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("TuttiFrutti");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Frutti");
                }
                else if (i % 2 == 0)
                {
                    Console.WriteLine("Tutti");
                }
                else
                {
                    Console.WriteLine("Сan’t be divided on 2 or 5");
                }
            }

        }
        else
        {
            Console.WriteLine("Tne entered numbers are equal ог there were not numbers");
        }

        Console.ReadLine(); 
    }

}
