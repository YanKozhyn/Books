using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Task5_5
    {
        // Write a console application that accepts a string and replaces all occurrences of the
        //string no with yes.

        public static void Task()
        {
            string str;
            char[] separator = { ' ' };
            Console.WriteLine("Please enter sentense which contains words 'yes' or 'no' ");
            str = Console.ReadLine();
            string[] splitedStr = str.Split(separator);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Equals("no"))
                {
                    splitedStr[i] = "yes";
                }
                
            }
            Console.WriteLine("Your changed sentense without 'no': ");
            foreach (string item in splitedStr)
            {
                Console.Write($"{item} ");
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
 myString = myString.Replace("no", "yes");
 WriteLine($"Replaced \"no\" with \"yes\": {myString}");
}
*/

