﻿using static System.Console;
using static System.Convert;

namespace Ch04Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance, interestRate, targetBalance;
            WriteLine("What is your current balance?");
            balance = ToDouble(ReadLine());
            WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + ToDouble(ReadLine()) / 100.0;
            WriteLine("What balance would you like to have?");
            targetBalance = ToDouble(ReadLine());
            int totalYears = 0;
            while (balance < targetBalance)
            {
                balance *= interestRate;
                ++totalYears;
            }
            WriteLine($"In {totalYears} year{(totalYears == 1 ? "" : "s")} " +
            $"you'll have a balance of {balance}.");
            if (totalYears == 0)
                WriteLine("To be honest, you really didn't need to use this calculator.");
            ReadKey();
        }
    }
}
