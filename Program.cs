//Josefin Mikaelsson .NET23
using System;

class Program
{
    public static void Main(string[] args)
    {


        int defaultNr = 10; //default number

        //if the default number is high or low
        if (defaultNr < 10)
        {
            Console.WriteLine("Talet är stort!");
        }
        else
        {
            Console.WriteLine("OJ. Lågt tal!");
        }

        //ask the user his/her name
        Console.WriteLine("Vad heter du?");
        string userName = Console.ReadLine();
        Console.WriteLine("Hej " + userName + "!");

        //Write all numbers between 0 and the default number
        for (int i = 0; i <= defaultNr; i++)
        {
            Console.WriteLine(i);
        }

        Console.ReadKey();
    }
}