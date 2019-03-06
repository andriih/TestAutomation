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

        public List<int> printArrayInReverseOrder(int[] numbers)
        {
            List<int> reversed = new List<int>();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                reversed.Add(numbers[i]);
            }
            return reversed;
        }

        public int [] printArrayInReverseOrder2(int[] numbers)
        {

            for (int i = 0, j = numbers.Length-1; i < j; i++, j--)
            {
                int t = numbers[i];
                numbers[i] = numbers[j];
                numbers[j] = t;
            }
            return numbers;
        }

    }
}
