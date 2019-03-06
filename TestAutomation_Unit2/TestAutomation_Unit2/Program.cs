using System;
using System.Collections.Generic;
using System.Collections; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 2, 3, 3, 5, 7 , 10 };
            Statement numbers = new Statement();
            Console.WriteLine("Mean: "+numbers.getMean(intList));
            Console.WriteLine("Median: "+numbers.getMedian(intList));
            Console.WriteLine("Mode: "+numbers.getMode(intList));

            List<string> names = new List<string>()
            {
               "Danae",
               "James",
               "Rima",
               "Aida",
               "Coretta",
               "Jeff",
               "Adam",
               "Alvaro",
               "Kristal",
               "Marisa",
               "Jackqueline"
            };

            Statement name = new Statement();
            name.SearchForParticularNames(names);

            ArrayList list = new ArrayList() { "string", 11.34, "text", 77.0001, "Some text", 23 };
            Statement intAndString = new Statement();
            intAndString.ConvertToInt(list);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
