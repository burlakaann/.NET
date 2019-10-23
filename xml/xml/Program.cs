using System;
using System.Xml;

namespace xml
{
    class Program
    {
        public XmlDocument GenerateXML()
        {

            XmlDocument doc = new XmlDocument();
            XmlDeclaration xmlDeclaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            XmlElement root = doc.DocumentElement;
            doc.InsertBefore(xmlDeclaration, root);
            XmlElement missionElement = doc.CreateElement(string.Empty, "mission", string.Empty);
            doc.AppendChild(missionElement);
            XmlElement northElement = doc.CreateElement(string.Empty, "north", string.Empty);
            northElement.Value = ("1990018836");
            missionElement.AppendChild(northElement);
            XmlElement exactlyElement = doc.CreateElement(string.Empty, "exactly", string.Empty);
            exactlyElement.Value = ("2059624129.3760319");
            missionElement.AppendChild(exactlyElement);
            XmlElement stayElement = doc.CreateElement(string.Empty, "stay", string.Empty);
            stayElement.Value = ("exclaimed");
            missionElement.AppendChild(stayElement);

            XmlElement takeElement = doc.CreateElement(string.Empty, "take", string.Empty);
            doc.AppendChild(takeElement);
            takeElement.Value = ("colony");

            XmlElement biggestElement = doc.CreateElement(string.Empty, "biggest", string.Empty);
            doc.AppendChild(takeElement);
            takeElement.Value = ("music");

            return doc;

        }

        static void Main(string[] args)
        {
            Program p = new Program();
            XmlDocument doc = new XmlDocument();
            try
            {
                doc = p.GenerateXML();
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
        
    }
}
