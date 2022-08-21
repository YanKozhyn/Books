/*4.1 If you have two integers stored in variables var1 and var2, what Boolean test can you perform
to determine whether one or the other (but not both) is greater than 10 ?*/
///Answer: (var1 > 10) ^ (var2 > 10)


/*4.2 What is wrong with the following code?
int i;
for (i = 1; i <= 10; i++)
{
 if ((i % 2) = 0)
 continue;
 Console.WriteLine(i);
} */

///Answer: Using the = assignment operator instead of the Boolean == operator is a very common mistake.


/* 4.3 Write an application that includes the logic from Exercise 1, obtains two numbers from the user,
and displays them, but rejects any input where both numbers are greater than 10 and asks for
two new numbers.*/
///Answer: 

using static System.Console;
using static System.Convert;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numbersOK = false;
            double var1, var2;
            var1 = 0;
            var2 = 0;
            while (!numbersOK)
            {
                WriteLine("Enter 2 numbers, both numbers cannot be greater than 10.");
                Write("Please enter the first number: ");
                var1 = ToDouble(ReadLine());
                Write("Please enter the second number: ");
                var2 = ToDouble(ReadLine());
                WriteLine($"The first number entered is {var1} " +
                    $"and the second is {var2}");
                if ((var1 > 10) ^ (var2 > 10))
                    numbersOK = true;
                else
                    WriteLine("Only one number may be greater than 10, " +
                            "please try again.");
            }
            WriteLine("Press the <ENTER> key to exit.");
            ReadLine();
        }
    }
}

