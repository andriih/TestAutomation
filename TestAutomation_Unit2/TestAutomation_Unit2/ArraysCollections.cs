using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class ArraysCollections
    {


        public void arraySumAndMax(int [] numbers)
        {
            int sum = 0;
            foreach (var number in numbers )
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
