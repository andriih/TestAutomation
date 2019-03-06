using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class Statement
    {
        private List<int> collection { get; set; }

        public int getMean(List<int> collection)
        {
            int mean = default(int);
            foreach (int number in collection)
            {
                mean += number;
            }
            return mean / collection.Count;
        }

        public  int getMedian(List<int> collection)
        {
            int[] array = collection.ToArray();
            Array.Sort(array);
            for (int i = 0, j = array.Length - 1; i < j; i++, j--)
            {
                int t = array[i];
                array[i] = array[j];
                array[j] = t;
            }
            int count = array.Count();
            int first = array[count / 2];
            int second = array[(count / 2) - 1 ];

            if (count%2 == 0)
            {
                return (first + second) / 2;
            }

            return array[(count / 2) - 1];
        }

        public int getMode(List<int> collection)
        {
            int[] array = collection.ToArray();
            Dictionary<int, int> counts = new Dictionary<int, int>();
            foreach (int a in array)
            {
                if (counts.ContainsKey(a))
                    counts[a] = counts[a] + 1;
                else
                    counts[a] = 1;
            }

            int result = int.MinValue;
            int max = int.MinValue;
            foreach (int key in counts.Keys)
            {
                if (counts[key] > max)
                {
                    max = counts[key];
                    result = key;
                }
            }
            return result;
        }

       public void SearchForParticularNames(List<string> names)
       {
            Random rnd = new Random();
            string[] arrayNames = names.ToArray();
            Array.Sort(arrayNames);

            int count = arrayNames.Length;
            var last = count - 1;

            for (var i = 0; i < last; ++i)
            {
                var r = rnd.Next(i, count);
                var tmp = arrayNames[i];
                arrayNames[i] = arrayNames[r];
                arrayNames[r] = tmp;
            }

            foreach (string name in arrayNames)
            {
                if (name == "Adam")
                {
                    Console.WriteLine(" 'Adam' name was found!");
                    continue;
                }

                if (name == "James")
                {
                    Console.WriteLine(" 'James' name was found!");
                    break;
                }
            }
       }
        
        public void ConvertToInt(ArrayList list)
        {
            foreach (string item in list)
            {
                if (Int32.TryParse(item, out int result))
                {
                   
                }
            }
        }
    }
}

