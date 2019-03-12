using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class Book : Item
    {
        protected int Price { get; set; }
        protected string Name { get; set; }

        public Book(string name = "Name", int price = 1)
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
