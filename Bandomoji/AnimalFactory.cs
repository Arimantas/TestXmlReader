﻿using System;
using System.Collections.Generic;
using System.Xml;

namespace Bandomoji
{
    class AnimalFactory
    {
        // nors list ir dinaminis, cia viskas statiska..
        public List<Animal> MakeAnimals()
        {
            List<Animal> result = new List<Animal>();
            XmlDocument doc = new XmlDocument();
            doc.Load("F:\\KCS\\Bandomoji uzduotis\\Bandomoji\\Bandomoji\\animals.xml");

            XmlNodeList animalsNodes = doc.SelectSingleNode("Animals").ChildNodes;
            foreach (XmlNode animalNode in animalsNodes)
            {
                Animal anim = null;
                switch (animalNode.Name)
                {
                    case "Dog":
                        anim = new Dog();
                        break;
                    case "Cat":
                        anim = new Cat();
                        break;
                    case "Pigeon":
                        anim = new Pigeon();
                        break;
                }
                if (anim != null)
                {
                    anim.AnimalClass = animalNode.SelectSingleNode("AnimalClass").InnerText;
                    anim.Name = animalNode.SelectSingleNode("Name").InnerText;
                    anim.Weight = Convert.ToDouble(animalNode.SelectSingleNode("Weight").InnerText);
                    anim.Height = Convert.ToDouble(animalNode.SelectSingleNode("Height").InnerText);
                    anim.Move = animalNode.SelectSingleNode("Move").InnerText;

                    result.Add(anim);
                    anim.ReturnAnimal(); // Atspauzdina sukurta objekta su nuskaitytas duomenimis
                }
            }
            return result;
        }

        internal void MakeAnimals(string animalType)
        {
            throw new NotImplementedException();
        }
    }
}