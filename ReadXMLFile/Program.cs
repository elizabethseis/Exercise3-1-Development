using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadXMLFile
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("C:\\Users\\elizabeth.perez\\source\\repos\\ReadXMLFile\\ReadXMLFile\\BreakfastMenuXML.xml");
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                   
                    switch (reader.Name.ToString())
                    {
                        case "name":
                            Console.WriteLine("Name: " + reader.ReadString());
                            break;
                        case "price":
                            Console.WriteLine("Price: " + reader.ReadString());
                            break;
                        case "description":
                            Console.WriteLine("Description: " + reader.ReadString());
                            break;
                        case "calories":
                            Console.WriteLine("Calories: " + reader.ReadString());
                            break;
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
