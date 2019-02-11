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


            Person person = new Person();

            Console.WriteLine(person.GetInfo());
            Console.ReadKey();
        }
    }
}
