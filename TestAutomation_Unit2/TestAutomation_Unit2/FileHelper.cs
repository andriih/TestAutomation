using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomation_Unit2
{
    class FileHelper
    {
        public void OpenAndSearchInFile(string fileName, string word)
        {
            try
            {
                using (StreamReader myFile = File.OpenText(fileName))
                {
                    int count = 0;
                    int lineNumber = 0;
                    while (!myFile.EndOfStream)
                    {
                        string line = myFile.ReadLine();
                        lineNumber++;
                        int position = line.IndexOf(word);
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
        }
    }
}
