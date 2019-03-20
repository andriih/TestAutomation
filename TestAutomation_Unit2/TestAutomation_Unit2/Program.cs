using System;
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
            try
            {
                using (StreamReader myFile = File.OpenText("TestFile.txt"))
                {
                    int count = 0; 
                    int lineNumber = 0;
                    while (!myFile.EndOfStream)
                    {
                        string line = myFile.ReadLine();
                        lineNumber++;
                        int position = line.IndexOf("justo");
                        if (position != -1)
                        {
                            count++;
                            Console.WriteLine("Match #{0} {1}:{2}", count, lineNumber, line);
                        }
                    }

                    if (count == 0)
                    {
                        Console.WriteLine("your word was not found!");
                    }
                    else
                    {
                        Console.WriteLine("Your word was found " + count + " times!");
                    }
                    Console.ReadLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
