using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TestAutomation_Unit2
{
    class XmlHelper
    {
        public void OpenAndSearchNodesInXml()
        {
            XElement booksFromFile = XElement.Load(@"books.xml");

            // Console.WriteLine(booksFromFile);


            // Create a reader and move to the content.  
            using (XmlReader nodeReader = XmlReader.Create(new StringReader(booksFromFile)))
            {
                // the reader must be in the Interactive state in order to  
                // Create a LINQ to XML tree from it.  
                nodeReader.MoveToContent();

                XElement xRoot = XElement.Load(nodeReader, LoadOptions.SetLineInfo);
                Console.WriteLine("{0}{1}{2}",
                    "Element Name".PadRight(20),
                    "Line".PadRight(5),
                    "Position");
                Console.WriteLine("{0}{1}{2}",
                    "------------".PadRight(20),
                    "----".PadRight(5),
                    "--------");
                foreach (XElement e in xRoot.DescendantsAndSelf())
                    Console.WriteLine("{0}{1}{2}",
                        ("".PadRight(e.Ancestors().Count() * 2) + e.Name).PadRight(20),
                        ((IXmlLineInfo)e).LineNumber.ToString().PadRight(5),
                        ((IXmlLineInfo)e).LinePosition);
            }
        }
    }
}
