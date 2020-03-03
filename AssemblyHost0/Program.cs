using System;
using System.IO;
//using System.Linq;
using System.Reflection;

namespace AssemblyHost0
{
    class Program
    {
        static void Main(string[] args)
        {
            string thisAssembly = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string thisAssemblyDirectory = System.IO.Path.GetDirectoryName(thisAssembly);
            //Console.WriteLine(thisAssembly);
            //Console.WriteLine(thisAssemblyDirectory);

            string solutionRoot = Path.Combine(thisAssemblyDirectory, "../../../..");
            //Console.WriteLine("Paths in " + solutionRoot + ":");
            //Console.WriteLine(string.Join(",", new DirectoryInfo(solutionRoot).GetDirectories().Select(x => x.FullName)));

            string targetAssemblyDirectory =
                Path.Combine(solutionRoot, @"CalculationProjectTake4\bin\Debug\netcoreapp3.1");
            string targetAssemblyFile = Path.Combine(targetAssemblyDirectory, "CalculationProjectTake4Calculator.dll");

            Assembly a = Assembly.LoadFrom(targetAssemblyFile);
            Type classType = a.GetType("CalculationProjectTake4Calculator.Calculator");
            object obj = Activator.CreateInstance(classType);
            MethodInfo mi = classType.GetMethod("Calculate");
                                 


            int value = 12;//Int32.Parse(args[0]);
            int multiplier = 2;
            var result = mi.Invoke(obj, new object[] { value, multiplier });

            Console.WriteLine("value = " + value);
            Console.WriteLine("result = " + result);
        }
    }
}
