using System;
using System.Xml;

namespace Bandomoji
{
    class ListOfAnimals
    {
        public ListOfAnimals()
        {
            // dinaminis list, jei nesikeicia klases pvd
            XmlDocument doc = new XmlDocument();
            doc.Load("F:\\KCS\\Bandomoji uzduotis\\Bandomoji\\Bandomoji\\animals.xml");

            XmlNodeList AllAnimalLists = doc.SelectSingleNode("Animals").ChildNodes;
            Console.WriteLine("All available animals: ");
            for (int i = 0; i < AllAnimalLists.Count; i++)
            {
                Console.WriteLine((i + 1) + " - " + AllAnimalLists[i].Name);
            }
            Console.WriteLine();
        }
    }
}
