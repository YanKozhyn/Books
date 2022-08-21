/*3.1 In the following code, how would you refer to the name great from code in the
namespace fabulous?*/
/*namespace fabulous
{
    // code in fabulous namespace
}
namespace super
{
    namespace smashing
    {
        // great name defined
    }
}*/
/// Answer: super.smashing.great


// 3.2 Which of the following is not a legal variable name?
/*➤ myVariableIsGood
➤ 99Flake
➤ _floor
➤ time2GetJiggyWidIt
➤ wrox.com*/
///Answer:  The second bulleted item because it starts with a number and the last bulleted item because
///         it contains a period.


/*3.3 Is the string "supercalifragilisticexpialidocious" too big to fit in a string
variable? If so, why?*/
///Answer: No, the value is not too big. The limit is 2 GB, which is about 1 billion characters.


/*3.4 By considering operator precedence, list the steps involved in the computation of the
following expression: */
//resultVar += var1 * var2 + var3 % var4 / var5;
///Answer: The * operator has the highest precedence here. The % and / are evaluated from left to
///right, then + and then +=.The precedence in the exercise can be illustrated using
///parentheses as follows: resultVar += (var1 * var2) + ((var3 % var4) / var5);

/*3.5 Write a console application that obtains four int values from the user and displays the
product. Hint: You may recall that the Convert.ToDouble() command was used to convert the input from the console to a double; the equivalent command to convert from a
string to an int is Convert.ToInt32(). */
///Answer:
using static System.Console;
using static System.Convert;
namespace HomeWork
{
    class Program
    {

        static void Main(string[] args)
        {
            int firstNumber, secondNumber, thirdNumber, fourthNumber;
            WriteLine("Give me a number: ");
            firstNumber = ToInt32(ReadLine());
            WriteLine("Give me another number: ");
            secondNumber = ToInt32(ReadLine());
            WriteLine("Give me another number: ");
            thirdNumber = ToInt32(ReadLine());
            WriteLine("Give me another number: ");
            fourthNumber = ToInt32(ReadLine());
            WriteLine($"The product of {firstNumber}, {secondNumber}, " +
                $"{thirdNumber}, and {fourthNumber} is " +
                $"{firstNumber * secondNumber * thirdNumber * fourthNumber}.");
        }
    }
}
