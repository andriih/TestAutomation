using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class Arrays
    {


        public void arraySumAndMax(int [] numbers)
        {
            int sum = 0;
            var max = numbers.Max();
            foreach (var number in numbers )
            {
                sum += number;
            }
            Console.WriteLine(sum);
            Console.WriteLine(max);
        }

        public void printArrayInReverseOrder(int[] numbers)
        {
            int[] reversed = { };
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }



    }
}
