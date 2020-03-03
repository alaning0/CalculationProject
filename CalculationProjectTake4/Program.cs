using System;
using System.Data.SqlClient;
using CalculationProjectTake4Calculator;

namespace CalculationProjectTake4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // CalculationProjectTake4Calculator is a project of type 'class library'
            // I added a reference to it by right clicking on this project > Add > Reference > Projects > ticked CalculationProjectTake4Calculator
            // put 'CalculationProjectTake4Calculator' in the using or use the full namespace when referring to the class. In here I did it both ways... 

            // Instead of doing a project reference, you could also refer to the specific project's assembly file...  
            // CalculationProject\CalculationProjectTake4Calculator\bin\Debug\netcoreapp3.1\CalculationProjectTake4Calculator.dll

            if (args.Length == 1)
            {
                if (!string.IsNullOrWhiteSpace(args[0]))
                {
                    int value = Int32.Parse(args[0]);
                    int multiplier = 2;
                    var result = new CalculationProjectTake4Calculator.Calculator().Calculate(value, multiplier);

                    Console.WriteLine("value = " + value);
                    Console.WriteLine("result = " + result);
                }
            }
        }
    }
}
