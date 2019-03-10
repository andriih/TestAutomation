using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class Book : Item
    {
        public int Price { get; set; }
        public string Name { get; set; }

        public Book(string name, int price)
        {
            Price = price;
            Name = name;
        }

        public override void Info()
        {
            Console.WriteLine("Name of book is '{0}', price: ${1}", Name, Price);
        }
    }
}
