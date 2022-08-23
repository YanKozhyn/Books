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
