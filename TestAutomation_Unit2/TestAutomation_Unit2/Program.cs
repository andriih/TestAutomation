﻿using System;
using System.Collections.Generic;
using System.Collections; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestAutomation_Unit2
{

    class Program
    {
        static void Main(string[] args)
        {
            //FileHelper file = new FileHelper();
            //file.OpenAndSearchInFile("TestFile.txt","justo");

            XmlHelper xmlFile = new XmlHelper();
            xmlFile.OpenAndSearchNodesInXml();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
