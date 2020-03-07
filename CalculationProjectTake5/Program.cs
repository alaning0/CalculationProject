using System;
using System.Net;

namespace CalculationProjectTake5
{
    class Program
    {
        static void Main(string[] args)
        {
            //string url = "https://localhost:44310/api/calculator";
            string url = "https://calculationprojecttake5api20200307101653.azurewebsites.net/api/calculator";

            string value = "10";
            string multiplier = "2";

            var client = new WebClient();
            client.QueryString.Add("value", value);
            client.QueryString.Add("multiplier", multiplier);

            string result = client.DownloadString(url);

            Console.WriteLine(result);
        }
    }
}
