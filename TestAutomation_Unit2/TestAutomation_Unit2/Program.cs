﻿using System;
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
            arr.printArrayInReverseOrder2(a).ToList().ForEach(Console.WriteLine);

            Console.ReadKey();

        }
    }
}
