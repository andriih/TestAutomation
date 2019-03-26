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

            XElement root = XElement.Load("books.xml");
            IEnumerable<XElement> address =
                from el in root.Elements("Book")
                where (string)el.Attribute("id") == "bk102"
                select el;
            foreach (XElement el in address)
                Console.WriteLine(el);
        }

        public void AddNodeToXml(string fileName, string author, string title, string genre, string price, string publishDate, string description)
        {
            Random rnd = new Random();
            int id = rnd.Next(1, 100);

            XmlDocument doc = new XmlDocument();

            doc.Load(fileName);

            XmlNode book = doc.CreateElement("Book");
            book.Attributes.Append(book.OwnerDocument.CreateAttribute("id"));
            book.Attributes["id"].Value = id.ToString();

            XmlNode Author = doc.CreateElement("Author");
            XmlNode Title = doc.CreateElement("Title");
            XmlNode Genre = doc.CreateElement("Genre");
            XmlNode Price = doc.CreateElement("Price");
            XmlNode PublishDate = doc.CreateElement("PublishDate");
            XmlNode Description = doc.CreateElement("description");

            Author.InnerText = author;
            Title.InnerText = title;
            Genre.InnerText = price;
            Price.InnerText = publishDate;
            PublishDate.InnerText = publishDate;
            Description.InnerText = description;

            book.AppendChild(Author);
            book.AppendChild(Title);
            book.AppendChild(Genre);
            book.AppendChild(Price);
            book.AppendChild(PublishDate);
            book.AppendChild(Description);

            doc.DocumentElement.AppendChild(book);
            doc.Save(fileName);
        }


        public void RemoveNodeFromXml(string fileName,string id)
        {
            XDocument doc = XDocument.Load(fileName);
            var q = from node in doc.Descendants("Book")
                    let attr = node.Attribute("id")
                    where attr != null && attr.Value == id
                    select node;
            q.ToList().ForEach(x => x.Remove());
            doc.Save(fileName);
        }

    }
}
