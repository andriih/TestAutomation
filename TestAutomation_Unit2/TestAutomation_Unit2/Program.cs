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
            List<int> intList = new List<int>() { 1,2,3,4,5,6,7,8,9};
            Statement numbers = new Statement();
            Console.WriteLine(numbers.getMeanInt(intList));


            Console.ReadKey();
        }
    }
}
