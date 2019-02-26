using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class Collections<T>
    {
        private List<T> list { get; set; }

        private Dictionary<T, T> dictionary { get; set; }

        public Collections(List<T> mylist)
        {
            list = mylist;
        }

        public Collections(Dictionary<T, T> mydictionary)
        {
            dictionary = mydictionary;
        }

        public List<T> addElementTolist<T>(T elem)
        {
             
        }
    }
}
