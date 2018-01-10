using System;

namespace Bandomoji
{
    public class Pigeon : Animal
    {
        public Pigeon()
        {
            Console.WriteLine("Hello, im Pigeon!");
            Console.WriteLine();
            ReturnAnimal();
        }

        public Pigeon(string animalClass, string name, double weight, double height, string move)
        {

            Console.WriteLine("Hello, im Pigeon in constructor!");
            Console.WriteLine();

            GetAnimalClass = animalClass;
            GetName = name;
            GetWeight = weight;
            GetHeight = height;
            GetMove = move;

            ReturnAnimal();
        }
    }
}
