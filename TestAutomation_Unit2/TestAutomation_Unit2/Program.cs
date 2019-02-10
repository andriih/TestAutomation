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
            Person person = new Person("12/12/1990");

            Console.WriteLine(person.GetInfo());
            Console.ReadKey();
        }
    }
}
