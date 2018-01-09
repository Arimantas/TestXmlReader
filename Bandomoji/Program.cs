using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Bandomoji
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfAnimals list = new ListOfAnimals();
            Console.WriteLine("Pick one animal by typing: 1, 2 or 3");
            var animalType = Console.ReadLine();

            AnimalFactory animalFactory = new AnimalFactory();
            animalFactory.MakeAnimal(animalType);           
        }
    }
}
