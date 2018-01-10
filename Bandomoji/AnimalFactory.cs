using System;
using System.Xml;

namespace Bandomoji
{
    class AnimalFactory
    {
        

        // nors list ir dinaminis, cia viskas statiska.. kolkas
        public List<Animal> MakeAnimal(string newAnimalType)
        {
			List<Animal> result = new List<Animal>();
			XmlDocument doc = new XmlDocument();
            doc.Load("F:\\KCS\\Bandomoji uzduotis\\Bandomoji\\Bandomoji\\animals.xml");

            XmlNodeList animalsNodes = doc.SelectSingleNode("Animals").ChildNodes;
			foreach(XmlNode animalNode in animalsNodes){
				switch (animalNode.Name)
				{
					case "Dog":
						result = new Dog();
						
					break;
					
				}
				if(result != null){
					
				}
			}
        }

        private void ReadXmlFile(string elementType)
        {
            
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