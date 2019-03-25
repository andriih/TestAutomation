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
            //Console.WriteLine(booksFromFile);

            //Serarch for second book
            XElement root = XElement.Load("books.xml");
            IEnumerable<XElement> address =
                from el in root.Elements("Book")
                where (string)el.Attribute("id") == "bk102"
                select el;
            foreach (XElement el in address)
                Console.WriteLine(el);
        }

        public void AddNodeToXml(string fileName, string rootName, string childElement)
        {
            XElement root = XElement.Load(fileName);
            XElement newTree = new XElement(rootName,
                root.Element(childElement),
                from att in root.Attributes()
                select new XElement(att.Name, (string)att)
            );
            Console.WriteLine(newTree);
        }

        public XmlElement AddNewBook(string genre, string ISBN, string misc,
    string title, string price, XmlDocument doc)
        {
            // Create a new book element.
            XmlElement bookElement = doc.CreateElement("book", "http://www.contoso.com/books");

            // Create attributes for book and append them to the book element.
            XmlAttribute attribute = doc.CreateAttribute("genre");
            attribute.Value = genre;
            bookElement.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("ISBN");
            attribute.Value = ISBN;
            bookElement.Attributes.Append(attribute);

            attribute = doc.CreateAttribute("publicationdate");
            attribute.Value = misc;
            bookElement.Attributes.Append(attribute);

            // Create and append a child element for the title of the book.
            XmlElement titleElement = doc.CreateElement("title");
            titleElement.InnerText = title;
            bookElement.AppendChild(titleElement);

            // Introduce a newline character so that XML is nicely formatted.
            bookElement.InnerXml =
                bookElement.InnerXml.Replace(titleElement.OuterXml,
                "\n    " + titleElement.OuterXml + " \n    ");

            // Create and append a child element for the price of the book.
            XmlElement priceElement = doc.CreateElement("price");
            priceElement.InnerText = price;
            bookElement.AppendChild(priceElement);

            // Introduce a newline character so that XML is nicely formatted.
            bookElement.InnerXml =
                bookElement.InnerXml.Replace(priceElement.OuterXml, priceElement.OuterXml + "   \n  ");

            return bookElement;

        }
    }
}
