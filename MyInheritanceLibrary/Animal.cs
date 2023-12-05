using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MyInheritanceLibrary
{
    public class Animal
    {
        // Assign 'Animal' properties, 'name' 'age' 'number of legs' / GET SET
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }


        // Default so assign default values  
        public Animal()
        {
            // Default values
            Name = "Toby";
            Age = 9;
            NumberOfLegs = 4;
        }

        // Custom Constructor 
        public Animal(string name, int age, int numberOfLegs)
        {
            Name = name;
            Age = age;
            NumberOfLegs = numberOfLegs;
        }

        // Create a method called 'speak' return type 'void / all class should override this 
        public virtual void Speak()
        {
            Console.WriteLine("Hello");
        }
    }

    // Derived class 'Dog'
    public class Dog : Animal
    {
        // All classes should have default and custom constructors 
        public Dog() : base() { }

        // Customer Constructor 'Assign Values'
        public Dog(string name, int age, int numberOfLegs) : base(name, age, numberOfLegs) { }

        // All classes should override 'Speak()'
        public override void Speak()
        {
            Console.WriteLine("Woof");
        }
    }

    // Same principle for 'Cat'
    public class Cat : Animal
    {
        // All classes should have a default and custom constructors
        public Cat() : base() { }

        // Custom Constructor assign values
        public Cat(string name, int age, int numberOfLegs) : base(name, age, numberOfLegs) { }

        // All classes should use 'override'
        public override void Speak()
        {
            Console.WriteLine("Meow");
        }
    }

    // Derived class of Bird
    public class Bird : Animal
    {
        // need to set a property for the double 
        public double Wingspan { get; set; }

        // Default constructor 
        public Bird() : base() { }

        // Custom Constructor 
        public Bird(string name, int age, int numberOfLegs, double wingspan) : base (name, age, numberOfLegs)
        {
            Wingspan = wingspan;
        }

        // Override Speak
        public override void Speak()
        {
            Console.WriteLine("Chirpy Chirp");
        }
    }
}

// Do we make a main here?! Question for marinus.....

/* Inheritance allows one class (called a subclass or derived class) to inherit properties
and behaviors from another class (called a superclass or base class). This promotes
code reuse and establishes an "is-a" relationship between classes. For instance, you
can create a subclass "Car" that inherits from a superclass "Vehicle," inheriting common
attributes like "speed" and methods like "start" and "stop." */

/* Abstraction, on the other hand, involves simplifying complex systems by hiding
unnecessary details and exposing only essential features. In C#, this is often achieved
using abstract classes and interfaces. Abstract classes provide a blueprint for other
classes to implement, while interfaces define a contract that classes must adhere to,
ensuring a consistent interface across different implementations. These concepts make
code more modular and maintainable, as you can work with high-level abstractions
without needing to concern yourself with the intricate implementation details of each
class. Abstraction allows us to define what an object “can-do” without worrying about
“how” it carries out that behaviour. */