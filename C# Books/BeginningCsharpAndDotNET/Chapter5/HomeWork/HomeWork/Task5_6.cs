using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Task5_6
    {
        // Write a console application that places double quotes
        // around each word in a string.

        public static void Task()
        {
            string str;
            char symbol = '\"';
            Console.WriteLine("Please enter what u want");
            str = Console.ReadLine();
            string[] arrayStr = str.Split(' ');
            for (int i = 0; i < arrayStr.Length; i++)
            {
                Console.WriteLine($" {symbol + arrayStr[i] + symbol} "); 
            }
        }
    }
}

///Answer:
/*
 using static System.Console;
static void Main(string[] args)
 {
 WriteLine("Enter a string:");
 string myString = ReadLine();
 myString = "\"" + myString.Replace(" ", "\" \"") + "\"";
 WriteLine($"Added double quotes around words: {myString}");
 }
Or using String.Split():
using static System.Console;
static void Main(string[] args)
 {
 WriteLine("Enter a string:");
 string myString = ReadLine();
 string[] myWords = myString.Split(' ');
 WriteLine("Adding double quotes around words:");
 foreach (string myWord in myWords)
 {
 Write($"\"{myWord}\" ");
 }
 }
*/
