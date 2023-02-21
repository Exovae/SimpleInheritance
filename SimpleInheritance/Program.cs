using System;

namespace SimpleInheritance
{
    // Base class
    class Animal
    {
        public string name;

        // Constructor
        public Animal()
        {
            name = "";
        }

        // Parameterized constructor
        public Animal(string name)
        {
            this.name = name;
        }

        public void Display()
        {
            Console.WriteLine($"I am an animal, my name is {name}");
        }
    }

    // Derived class 1
    class GuineaPig : Animal
    {
        public int age;
        public string breed;
        public string color;

        // Default constructor
        public GuineaPig() : base()
        {
            age = 0;
            breed = "";
            color = "";
        }

        // Parameterized constructor
        public GuineaPig(string name, int age, string breed, string color) : base(name)
        {
            this.age = age;
            this.breed = breed;
            this.color = color;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Breed: {breed}");
            Console.WriteLine($"Color: {color}");
        }
    }

    // Derived class 2
    class Fish : Animal
    {
        public string species;
        public string color;
        public int age;

        // Default constructor
        public Fish() : base()
        {
            species = "";
            color = "";
            age = 0;
        }

        // Parameterized constructor
        public Fish(string name, string species, string color, int age) : base(name)
        {
            this.species = species;
            this.color = color;
            this.age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Species: {species}");
            Console.WriteLine($"Color: {color}");
            Console.WriteLine($"Age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create object of derived class 1 using default constructor
            Console.WriteLine();
            Console.WriteLine("Guinea pig #1:");
            GuineaPig myGuineaPig = new GuineaPig();
            myGuineaPig.name = "Pixel";
            myGuineaPig.age = 2;
            myGuineaPig.breed = "Peruvian";
            myGuineaPig.color = "Brown";
            myGuineaPig.DisplayInfo();

            // Create object of derived class 1 using parameterized constructor
            Console.WriteLine();
            Console.WriteLine("Guinea pig #2:");
            GuineaPig myOtherGuineaPig = new GuineaPig("Pikea", 1, "American", "White and Brown");
            myOtherGuineaPig.DisplayInfo();

            // Create object of derived class 2 using default constructor
            Console.WriteLine();
            Console.WriteLine("Fish #1:");
            Fish myFish = new Fish();
            myFish.name = "Nemo";
            myFish.species = "Clownfish";
            myFish.color = "Orange and White";
            myFish.age = 1;
            myFish.DisplayInfo();

            // Create object of derived class 2 using parameterized constructor
            Console.WriteLine();
            Console.WriteLine("Fish #2:");
            Fish myOtherFish = new Fish("Goldie", "Goldfish", "Gold", 2);
            myOtherFish.DisplayInfo();
        }
    }
}
