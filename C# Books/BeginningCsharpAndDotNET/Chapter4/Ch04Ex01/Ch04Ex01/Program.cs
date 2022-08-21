using System;
using System.Threading;
using static System.Console;
using static System.Convert;

namespace Ch04Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter an integer");
            int myInt = ToInt32(ReadLine());
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);
            WriteLine($"Integer less then 10? {isLessThan10}");
            WriteLine($"Integer between 0 and 5? {isBetween0And5}");
            WriteLine($"Exactly one of the above is true?" +
                $"{isLessThan10 ^ isBetween0And5}");

            //<test> ? <resultIfTrue>: <resultIfFalse>;
            string resultString = (myInt < 10) ? "Less than 10"
                                            : "greater than or equal to 10";
            WriteLine(resultString);
        }

    }

}
