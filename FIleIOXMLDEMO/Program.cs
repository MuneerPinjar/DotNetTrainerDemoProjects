using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using System.IO;

namespace FIleIOXMLDEMO
{

    public class ListManager<T>
    {

        private List<T> list;

        public ListManager()
        {
            list = new List<T>();
        }

        public void Add(T item)
        {
            list.Add(item);
        }

        public bool Remove(T item)
        {
          return  list.Remove(item);
        }

        public bool Contains(T item)
        {
            return (list.Contains(item));
        }

        public List<T> GetAllItems()
        {
            return list;
        }

        public void DisplayAll()
        {
            Console.WriteLine(" All Items");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\sampleXmlData.xml";


            //ListManager<string> listManagerObj = new ListManager<string>();

            //listManagerObj.Add("Test data 1");
            //listManagerObj.Add("Test data 2");
            //listManagerObj.Add("Test data 3");
            //listManagerObj.Add("Test data 4");
            //listManagerObj.Add("Test data 5");
            //listManagerObj.Add("Test data 6");

            //WriteToXml(filePath);

            ReadFromXml(filePath);

            Console.ReadLine();
        }

        static void WriteToXml(string filePath)
        {
            

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlDeclaration xmlDeclaration = xmlDocument.CreateXmlDeclaration("1.0", "UTF-8", null);

                XmlNode rootNode = xmlDocument.CreateElement("Books");


                xmlDocument.AppendChild(xmlDeclaration);
                xmlDocument.AppendChild(rootNode);

                XmlNode bookNode = xmlDocument.CreateElement("Book");

                XmlElement titleElement = xmlDocument.CreateElement("Title");
                titleElement.InnerText = "Sample Text Book 1";

                bookNode.AppendChild(titleElement);

                XmlElement authorElement = xmlDocument.CreateElement("Author");
                authorElement.InnerText = "Test Author Data 1";

                bookNode.AppendChild(authorElement);


                XmlElement yearElement = xmlDocument.CreateElement("Year");
                yearElement.InnerText = "2001";

                bookNode.AppendChild(yearElement);


                rootNode.AppendChild(bookNode);

                xmlDocument.Save(filePath);

                Console.WriteLine("XML data written to the file");

            }
            catch (Exception)
            {

                throw;
            }
         

        }

        static   void ReadFromXml(string filePath)
        {

            try
            {
                XmlDocument xmlDocument= new XmlDocument();

                xmlDocument.Load(filePath);

                XmlNodeList bookNodes = xmlDocument.SelectNodes("/Books/Book");

                if(bookNodes != null)
                {

                    Console.WriteLine("Content of your XML file");
                    foreach (XmlNode bookNodeItem in bookNodes)
                    {
                        string title = bookNodeItem.SelectSingleNode("Title").InnerText;

                        string author = bookNodeItem.SelectSingleNode("Author").InnerText;

                        string year = bookNodeItem.SelectSingleNode("Year").InnerText;

                        Console.WriteLine($"Title : "+title +" Author  : "+author +" Year : "+year);
                    }
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Error reading XML file : "+ex.Message);
            }
        }
    }

}
