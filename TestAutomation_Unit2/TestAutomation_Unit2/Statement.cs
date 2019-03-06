using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class Statement
    {
        private List<int> collection { get; set; }

        public int getMeanInt(List<int> collection)
        {
            int mean = 0;
            foreach (int number in collection)
            {
                mean += number;
            }
            return mean / collection.Count;
        }

        public  int getMedianInt(List<int> collection)
        {
            collection.Sort();
            return (collection[0] + collection[(collection.Count) / 2]) / 2;
        }

        public void getMedianInt2(List<int> collection)
        {
            List<int> newList = new List<int>();
            newList.Add(collection.Sort());
            Console.WriteLine("=======================");
            Console.WriteLine(collection[0]);
            Console.WriteLine(collection[(collection.Count) / 2]);
        }

    }
}
