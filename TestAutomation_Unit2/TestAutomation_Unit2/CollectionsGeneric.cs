using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class CollectionsGeneric<T>
    {
        private List<T> list { get; set; }

        private Dictionary<T, T> dictionary { get; set; }

        public CollectionsGeneric(List<T> mylist)
        {
            list = mylist;
        }

        public CollectionsGeneric(Dictionary<T, T> mydictionary)
        {
            dictionary = mydictionary;
        }

        public void addElementTolist(T elem)
        {
            list.Add(elem);
        }
    }
}
