using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class Program
    {
        static void Main(string[] args)
        {


           // Person boy = new Person();
           // Person girl = new Person("02/14/1992", "female", 165);

            //Console.WriteLine(boy.GetInfo());
            //Console.WriteLine(girl.GetInfo());

            //Types type = new Types();
            //type.getConvertedStr("1 2 3");
            //Console.WriteLine(type.calc(12, "/", 45));
            //Console.WriteLine(type.floatToString(3.5F, 3.5F, 3.5F));
            //type.convertStringToChars("TEST TEST");
            //Console.WriteLine(type.stringBoxing());

            Arrays arr = new Arrays();
            int[] a = { 1, 2, 56 ,-23, -14};
            //var b = arr.printArrayInReverseOrder(a);
           // arr.printArrayInReverseOrder(a).ForEach(Console.WriteLine);
            //arr.printArrayInReverseOrder2(a).ToList().ForEach(Console.WriteLine);

            List<int> numbers = new List<int>() { 1, 2, 3, 45 };
            numbers.Insert(0, 222222222);
            numbers.ForEach(Console.WriteLine);

            Console.WriteLine("----------------");

            numbers.Insert(2, 234);
            numbers.ForEach(Console.WriteLine);

            Console.WriteLine("----------------");

            numbers.Add(777);
            numbers.ForEach(Console.WriteLine);

            Console.WriteLine("----------------");

            numbers.Remove(2);
            numbers.ForEach(Console.WriteLine);

            Console.WriteLine("----------------");

            //Remove last one element in the list
            numbers.RemoveAt(numbers.Count - 1);
            numbers.ForEach(Console.WriteLine);
            Console.WriteLine("----------------");

            //Searching for elements 
            int item = numbers.IndexOf(45);
            Console.WriteLine(item);
            Console.WriteLine("----------------");

            //Accessing items by index or keys
            int itemByIndex = numbers[item];
            Console.WriteLine(itemByIndex);
            Console.WriteLine("----------------");

            //Check for element existence 
            Console.WriteLine(numbers.Contains(itemByIndex)); //true
            Console.WriteLine(numbers.Contains(123)); //false
            Console.WriteLine("----------------");

            //Update elements value
            int updated = 88888888;
            numbers[4] = updated ; // 45 to 88888888
            numbers.ForEach(Console.WriteLine);
            Console.WriteLine("----------------");

            //Clean elements
            numbers.Clear();
            numbers.ForEach(Console.WriteLine);
            Console.WriteLine("Cleaned!");

            CollectionsGeneric<int> list = new CollectionsGeneric<int>(numbers);
            int elem = 555;
            list.addElementTolist(elem);
            numbers.ForEach(Console.WriteLine);

            //DICTIONARIES
            //Adding/Removing elements (Beginning, middle, end) 

            Dictionary<string, string> zipCodes = new Dictionary<string, string>();

            zipCodes.Add("France", "FR");
            zipCodes.Add("Spain", "ES");
            zipCodes.Add("Japan", "JP");
            zipCodes.Add("Turkey", "TK");

            //Remove
            zipCodes.Remove("TR");
            zipCodes.ToList().ForEach(x => Console.WriteLine(x.Key));
            Console.WriteLine("----------------");

            //Searching for elements 
            bool ifContainsKey = zipCodes.ContainsKey("Turkey");
            Console.WriteLine(ifContainsKey); //True

            bool ifContainsValue = zipCodes.ContainsValue("zzz");
            Console.WriteLine(ifContainsValue); //False

            // Accessing items by index or keys
            string getItemByKey = zipCodes["Spain"];
            Console.WriteLine(getItemByKey);
            Console.WriteLine("----------------");

            string country = zipCodes.FirstOrDefault(x => x.Value.Contains("FR")).Key;
            Console.WriteLine(country);
            Console.WriteLine("----------------");

            string value;
            zipCodes.TryGetValue("Japan", out value);
            Console.WriteLine(value);
            Console.WriteLine("----------------");

            //Check for element existence 

            if (zipCodes.ContainsKey("Japan"))
            {
                Console.WriteLine("Exists!");
            }
            else
            {
                Console.WriteLine("Not Exists!");
            }

            if (zipCodes.ContainsValue("JP"))
            {
                Console.WriteLine("Value Exists!");
            }
            else
            {
                Console.WriteLine("Value Not Exists!");
            }

            //Update elements value
            zipCodes["Japan"] = "JAP";
            zipCodes.ToList().ForEach(x => Console.WriteLine( x.Value));
            Console.WriteLine("----------------");

            //Update key
            string val = zipCodes["Spain"];
            zipCodes.Remove("Spain");
            zipCodes["New Spain"] = val;

            zipCodes.ToList().ForEach(elm => Console.WriteLine("Key = {0}, Value = {1}", elm.Key,elm.Value));
            Console.WriteLine("----------------");


            //Clean elements
            zipCodes.Clear();
            zipCodes.ToList().ForEach(elm => Console.WriteLine("Key = {0}, Value = {1}", elm.Key, elm.Value));
            Console.WriteLine("Dict Cleared!");

            Console.ReadKey();

        }
    }
}
