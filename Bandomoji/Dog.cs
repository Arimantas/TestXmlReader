using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandomoji
{
    public class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Hello, im Dog!");
            Console.WriteLine();
            // pries kvieciant turi buti priskirtos reiksmes
            ReturnAnimal();
        }
    }
}
