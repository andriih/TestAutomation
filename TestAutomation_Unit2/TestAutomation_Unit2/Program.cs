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
            FileHelper file = new FileHelper();
            file.OpenAndSearchInFile("TestFile.txt","justo");
            file.EditFile("TestFile.txt", "Donec molestie lacus","TEST TEST TEST");

            XmlHelper xmlFile = new XmlHelper();
            xmlFile.OpenAndSearchNodesInXml();
            xmlFile.AddNodeToXml("books.xml", "Some author", "Some ttl", "Fantasy", "Fantasy", "Fantasy", "Fantasy");
            xmlFile.RemoveNodeFromXml("books.xml","bk101");

            Serialization.SerializeModelToJson();

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
