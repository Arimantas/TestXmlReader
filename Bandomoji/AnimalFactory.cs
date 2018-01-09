using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Bandomoji
{
    class AnimalFactory
    {

        // nors list ir dinaminis, cia viskas statiska.. kolkas
        public Animal MakeAnimal(string newAnimalType)
        {
            if (newAnimalType.Equals("1"))
            {
                ReadXml.ReadXmlFile("Dog"); // pasirenku kuri parametra nuskaitineti
                return new Dog(); // kuriu nauja objekta, kuriam nera parduoti jokie parametrai ir nuskaitymos..
            }
            else if (newAnimalType.Equals("2"))
            {
                ReadXml.ReadXmlFile("Cat");
                return new Cat();
            }
            else if (newAnimalType.Equals("3"))
            {
                ReadXml.ReadXmlFile("Pigeon");
                return new Pigeon();
            }
            else return null;
        }
    }
}