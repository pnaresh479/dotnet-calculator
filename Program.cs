using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 3)
        {
            Console.WriteLine("Usage: CalculatorApp <num1> <operator> <num2>");
            return;
        }

        if (!double.TryParse(args[0], out double a) || !double.TryParse(args[2], out double b))
        {
            Console.WriteLine("Invalid numbers.");
            return;
        }

        string op = args[1];
        double result = op switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b != 0 ? a / b : double.NaN,
            _ => double.NaN
        };

        Console.WriteLine($"Result: {result}");
    }
}
