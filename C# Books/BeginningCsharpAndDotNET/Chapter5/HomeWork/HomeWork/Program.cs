// 5.1 Which of the following conversions can’t be performed implicitly?
/*a. int to short
b. short to int
c. bool to string
d. byte to float*/
/// Answer: a

//5.2 Show the code for a color enumeration based on the short type containing the colors
//of the rainbow plus black and white. Can this enumeration be based on the byte type?
///Answer: 
/// enum color: short {
/// red = 1,
/// oreange = 2,
/// yellow = 3,
/// green = 4,
/// blue = 5,
/// indigo = 6,
/// violet = 7,
/// white = 8,
/// black = 9
///}
/// Yes this can be based on byte type.

//5.3 Will the following code compile? Why or why not? 
/* string[] blab = new string[5]
blab[5] = 5th string.*/
///Answer:
/// No, this code can't comile, becouse second line is broke code.
/// array only have 0,1,2,3,5 indexes. and 5 elements. 
/// this arrays can't contain index of 5 in squad brackets


using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task5.4
            //Task5_4.Task();

            //Task5.5
            //Task5_5.Task();

            Task5_6.Task();
        }
    }
}
