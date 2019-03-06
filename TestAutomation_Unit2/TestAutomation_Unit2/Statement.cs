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

        public int getMedianInt(List<int> collection)
        {
            int mean = 0;
            foreach (int number in collection)
            {
                mean += number;
            }
            return mean / collection.Count;
        }
    }
}
