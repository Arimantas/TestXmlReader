using System;
using System.Xml;

namespace Bandomoji
{
    class AnimalFactory
    {
        private string _localClass { get; set; }
        private string _localName { get; set; }
        private double _localWeight { get; set; }
        private double _localHeight { get; set; }
        private string _localMove { get; set; }

        // nors list ir dinaminis, cia viskas statiska.. kolkas
        public Animal MakeAnimal(string newAnimalType)
        {
            if (newAnimalType.Equals("1"))
            {
                ReadXmlFile("Dog"); // pasirenku kuri parametra nuskaitineti
                return new Dog(_localClass, _localName, _localWeight, _localHeight, _localMove);
            }
            else if (newAnimalType.Equals("2"))
            {
                ReadXmlFile("Cat");
                return new Cat(_localClass, _localName, _localWeight, _localHeight, _localMove);
            }
            else if (newAnimalType.Equals("3"))
            {
                ReadXmlFile("Pigeon");
                return new Pigeon(_localClass, _localName, _localWeight, _localHeight, _localMove);
            }
            else
            {
                Console.WriteLine("Tokio pasirinkimo nera");
                return null;
            } 
        }

        private void ReadXmlFile(string elementType)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("F:\\KCS\\Bandomoji uzduotis\\Bandomoji\\Bandomoji\\animals.xml");

            XmlNodeList animals = doc.GetElementsByTagName(elementType);
            foreach (XmlNode animalNode in animals)
            {
                _localClass = animalNode.SelectSingleNode("AnimalClass").InnerText;
                _localName = animalNode.SelectSingleNode("Name").InnerText;
                _localWeight = Convert.ToDouble(animalNode.SelectSingleNode("Weight").InnerText);
                _localHeight = Convert.ToDouble(animalNode.SelectSingleNode("Height").InnerText);
                _localMove = animalNode.SelectSingleNode("Move").InnerText;
            }
        }
    }
}