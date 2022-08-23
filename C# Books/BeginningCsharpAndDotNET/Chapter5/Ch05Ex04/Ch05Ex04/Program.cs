using System;
using System.Collections.Generic;

namespace Ch05Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> NikitaDoun = new List<string>();
            NikitaDoun.Add("dalbaeb");
            NikitaDoun.Add("Umorist");
            NikitaDoun.Add("Geniu");


            string[] friendNames = { "Todd Anthiny", "Mary chris", "Autry Rual" };
            //int i;
            Console.WriteLine($"Here are {friendNames.Length} of my friends: ");
            //for (i = 0; i < friendNames.Length; i++)
            //{
            //    Console.WriteLine(friendNames[i]);
            //}
            foreach (string nikita in NikitaDoun)
            {
                nikita = "ueban";
            }
            Console.ReadKey();
        }
    }
}
