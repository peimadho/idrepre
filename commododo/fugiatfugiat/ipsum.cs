using System;
using System.Xml;

namespace XmlExample
{
    class Program
    {
        static void Main()
        {
            using (XmlWriter writer = XmlWriter.Create("example.xml"))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("greetings");
                writer.WriteElementString("hello", "world");
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
