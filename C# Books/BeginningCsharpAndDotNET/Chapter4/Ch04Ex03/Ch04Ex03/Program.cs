﻿using static System.Console;


namespace Ch04Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string myName = "yan";
            const string niceName = "andrea";
            const string sillyName = "ploppy";
            string name;
            WriteLine("What is your name");
            name = ReadLine();
            switch (name.ToLower())
            {
                case myName:
                    WriteLine("You have the same name as me!");
                    break;
                case niceName:
                    WriteLine("My, what a nice name you have!");
                    break;
                case sillyName:
                    WriteLine("That's a very silly name");
                    break;
            }
            WriteLine($"Hello, {name}!");
            ReadKey();
        }
    }
}
