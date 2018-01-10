using System;

namespace Bandomoji
{
    public abstract class Animal
    {
        public string AnimalClass { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public string Move { get; set; }

        public void ReturnAnimal() {
            Console.WriteLine("My Class is: " + AnimalClass);
            Console.WriteLine("My Name is: " + Name);
            Console.WriteLine("My Weight is: " + Weight);
            Console.WriteLine("My Hight is: " + Height);
            Console.WriteLine("My movement: " + Move);
        }
    }
}
