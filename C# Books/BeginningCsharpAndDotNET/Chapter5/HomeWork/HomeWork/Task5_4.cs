using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Task5_4
    {
        // Write a console application that accepts a string from the user and outputs a string with
        //the characters in reverse order.

        public static void Task()
        {
            string str;
            Console.WriteLine($"Dear user, please enter what u want.");
            str = Console.ReadLine();
            for (int i = 1; i <= str.Length; i++)
            {
                Console.Write(str[^i]);
            }
        }
    }
}
