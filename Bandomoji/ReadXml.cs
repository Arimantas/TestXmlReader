using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bandomoji
{
    public class ReadXml : Animal // kitaip neissiaikinau kaip pasiekt setter
    {
        public static void ReadXmlFile(string elementType)
        {
            ReadXml read = new ReadXml();
            XmlDocument doc = new XmlDocument();
            doc.Load("F:\\KCS\\Bandomoji uzduotis\\Bandomoji\\Bandomoji\\animals.xml");
           
            XmlNodeList animals = doc.GetElementsByTagName(elementType);
            foreach (XmlNode animalNode in animals)
            {
                read.GetAnimalClass = animalNode.SelectSingleNode("AnimalClass").InnerText;
                read.GetName = animalNode.SelectSingleNode("Name").InnerText;
                read.GetWeight = Convert.ToDouble(animalNode.SelectSingleNode("Weight").InnerText); 
                read.GetHeight = Convert.ToDouble(animalNode.SelectSingleNode("Height").InnerText);
                read.GetMove = animalNode.SelectSingleNode("Move").InnerText;
                // as isivaizdavau, jog tokiu budu priskirsiu reiksmes Animal klasei ir tuomet 
                // kuriamas paveldincios klases objektas jau tures tas reiksmes, t.y. kvieciant Dog(), per AnimalFactory 
                // bus perrasamos tik pasikeitusios taisykles, o visa kita kas priskirta bendrai Animal
                // liks tas pats ir bus parodyta per ReturnAnimal(), deja bet viskas pasirodo netaip paprasta...
            }
        }
    }
}