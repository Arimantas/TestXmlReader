using System;

namespace Bandomoji
{
    public abstract class Animal
    {
        private string _animalClass { get; set; }
        private string _name { get; set; }
        private double _weight { get; set; }
        private double _height { get; set; }
        private string _move { get; set; }

        // reiksmes priskirimas private klasei 
        public string GetAnimalClass { get { return _animalClass; } set { _animalClass = value; } }
        public string GetName { get { return _name; } set { _name = value; } }
        public double GetWeight { get { return _weight; } set { _weight = value; } }
        public double GetHeight { get { return _height; } set { _height = value; } }
        public string GetMove { get { return _move; } set { _move = value; } }

        public void ReturnAnimal() {
            Console.WriteLine("My Class is: " + GetAnimalClass);
            Console.WriteLine("My Name is: " + GetName);
            Console.WriteLine("My Weight is: " + GetWeight);
            Console.WriteLine("My Hight is: " + GetHeight);
            Console.WriteLine("My movement: " + GetMove);
        }
    }
}
