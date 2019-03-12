using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class MyBook : Book
    {
        public string Owner { get; set; }

        public MyBook(string name, int price, string owner) : base(,price)
        {
            Owner = owner;
        }

        public override void Info() 
        {
            Console.WriteLine("Name of book is '{0}', price: ${1}, Owner: {2}",Name,Price,Owner);
        }
    }
}
