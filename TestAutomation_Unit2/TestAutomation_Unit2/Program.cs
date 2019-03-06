using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 5, 17, 3, 9, 14, 2};
            Statement numbers = new Statement();
            Console.WriteLine(numbers.getMeanInt(intList));

            Console.WriteLine(numbers.getMedianInt(intList));

            numbers.getMedianInt2(intList);

            Console.ReadKey();
        }
    }
}
