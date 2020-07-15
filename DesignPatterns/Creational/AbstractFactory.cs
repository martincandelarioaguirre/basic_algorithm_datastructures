using System;

namespace DesignPatterns.Creational
{
    public interface IAnimal
    {
        string speak();
    }

    public class Cat : IAnimal
    {
        public string speak()
        {
            return "Meow Meow Meow";
        }
    }

    public class Lion : IAnimal
    {
        public string speak()
        {
            return "Roar";
        }
    }

    public class Dog : IAnimal
    {
        public string speak()
        {
            return "Bark Bark";
        }
    }

    public class Octopus : IAnimal
    {
        public string speak()
        {
            return "SQUAWCK";
        }
    }

    public class Shark : IAnimal
    {
        public string speak()
        {
            return "Cannot speak";
        }
    }

    public abstract class AnimalFactory
    {
        public abstract IAnimal GetAnimal(string animalType);
        public static AnimalFactory CreateAnimalFactory(string FactoryType)
        {
            if (FactoryType.Equals("Sea"))
            {
                return new SeaAnimalFactory();
            }
            else
            {
                return new LandAnimalFactory();
            }
        }
    }

    public class LandAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string animalType)
        {
            if (animalType.Equals("Dog"))
            {
                return new Dog();
            }
            else if (animalType.Equals("Cat"))
            {
                return new Cat();
            }
            else if (animalType.Equals("Lion"))
            {
                return new Lion();
            }
            else
                return null;
        }
    }

    public class SeaAnimalFactory : AnimalFactory
    {
        public override IAnimal GetAnimal(string AnimalType)
        {
            if (AnimalType.Equals("Shark"))
            {
                return new Shark();
            }
            else if (AnimalType.Equals("Octopus"))
            {
                return new Octopus();
            }
            else
                return null;
        }
    }

    public class AbstractFactoryTest
    {
        public void Run()
        {
            IAnimal animal = null;
            AnimalFactory animalFactory = null;
            string speakSound = null;
            // Create the Sea Factory object by passing the factory type as Sea
            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();
            // Get Octopus Animal object by passing the animal type as Octopus
            animal = animalFactory.GetAnimal("Octopus");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();
            Console.WriteLine("--------------------------");
            // Create Land Factory object by passing the factory type as Land
            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();
            // Get Lion Animal object by passing the animal type as Lion
            animal = animalFactory.GetAnimal("Lion");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.WriteLine();
            // Get Cat Animal object by passing the animal type as Cat
            animal = animalFactory.GetAnimal("Cat");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            speakSound = animal.speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + speakSound);
            Console.Read();
        }
    }
}