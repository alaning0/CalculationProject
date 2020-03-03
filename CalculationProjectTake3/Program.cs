using System;

namespace CalculationProjectTake3
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1)
            {
                if (!string.IsNullOrWhiteSpace(args[0]))
                {
                    int value = Int32.Parse(args[0]);
                    int multiplier = 2;
                    var result = new Calculator().Calculate(value, multiplier);

                    Console.WriteLine("value = " + value);
                    Console.WriteLine("result = " + result);
                }
            }
        }
    }
}
