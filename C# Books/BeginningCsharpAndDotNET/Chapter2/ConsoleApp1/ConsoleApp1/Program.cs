using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;int y = 1; y *= x++; x += y;
            Console.WriteLine(x);
            
        }
    }
}
