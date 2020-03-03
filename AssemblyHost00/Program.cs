using System;
using System.IO;
//using System.Linq;
using System.Reflection;

namespace AssemblyHost00
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
            string targetAssemblyFile = Path.Combine(targetAssemblyDirectory, "CalculationProjectTake4.dll");

            Assembly a = Assembly.LoadFrom(targetAssemblyFile);
            Type classType = a.GetType("CalculationProjectTake4.Program");
            object obj = Activator.CreateInstance(classType);
            //MethodInfo mi = classType.GetMethod("Calculate");
            MethodInfo mi = classType.GetMethod("Main");


            
            string value = "12";
            string[][] myArgs = { new string[] { value } };
            mi.Invoke(obj, myArgs); // Main method, therefore no return type 
        }
    }
}
