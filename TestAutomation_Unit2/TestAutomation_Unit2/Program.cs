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


            //Person boy = new Person();
            Person girl = new Person("02/14/1992","female",165);

            //Console.WriteLine(boy.GetInfo());
            Console.WriteLine(girl.GetInfo());
            Console.ReadKey();
        }
    }
}
