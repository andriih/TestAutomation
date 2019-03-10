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
            Book someBook = new Book("Some book",99);
            someBook.Info();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
