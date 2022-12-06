// See https://aka.ms/new-console-template for more information

class Program
{
    delegate double ProcessDelegate(double param1, double param2);

    static double Multiply(double param1, double param2) => param1 * param2;
    static double Divide(double param1, double param2) => param1 / param2;

    static void Main(string[] args)
    {
        ProcessDelegate process;
        Console.WriteLine("Enter 2 numbers separated with a comma");
        string input = Console.ReadLine();
        int commaPos = input.IndexOf(',');
        double param1 = Convert.ToDouble(input.Substring(0, commaPos));
        double param2 = Convert.ToDouble(input.Substring(commaPos + 1, input.Length - commaPos - 1));
        Console.WriteLine("Enter m to multiply or d to divide");
        input = Console.ReadLine();
        if (input == "m")
            process = new ProcessDelegate(Multiply);
        else
            process = new ProcessDelegate(Divide);
        Console.WriteLine($"Result: {process(param1, param2)}");
        Console.ReadKey();

    }
    
}