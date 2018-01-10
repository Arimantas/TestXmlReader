using System;

namespace Bandomoji
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfAnimals list = new ListOfAnimals();
            // Console.WriteLine("Pick one animal by typing: 1, 2 or 3");
            // var animalType = Console.ReadLine();

            AnimalFactory animalFactory = new AnimalFactory();
            animalFactory.MakeAnimals();           
        }
    }
}
