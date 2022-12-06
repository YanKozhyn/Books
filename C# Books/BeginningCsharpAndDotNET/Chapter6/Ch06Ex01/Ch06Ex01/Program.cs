using System;

namespace Ch06Ex01
{
    internal class Program
    {
        static string myString;
        static void Write()
        {
            Console.WriteLine($"myString = {myString}");
            Console.WriteLine("Now in Write()");
            Console.WriteLine($"Local myString = {myString}");
            Console.WriteLine($"Global myString = {Program.myString}");
        }

        static void Main(string[] args)
        {
            string myString = "string defined in Main()";
            Program.myString = "Global string";
            Write();
            Console.ReadKey();
            Console.WriteLine("\nNow in Main()");
            Console.WriteLine($"Local myString = {myString}");
            Console.WriteLine($"Global myString = {Program.myString}");
            Console.ReadKey();
        }
    }
}
