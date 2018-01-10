using System;

namespace Bandomoji
{
    public class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("Hello, im Cat!");
            Console.WriteLine();
            ReturnAnimal();
        }

        public Cat(string animalClass, string name, double weight, double height, string move)
        {

            Console.WriteLine("Hello, im Cat in constructor!");
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
