// Practical 3: Bird Management
// Objective: Demonstrate Liskov Substitution Principle (LSP) and Interface Segregation Principle (ISP)
// Separate Fly functionality so non-flying birds don't throw exceptions.

using System;

namespace SolidAssignments.Practical3
{
    // Base interface for all birds
    public interface IBird
    {
        string BirdName { get; }
        void Eat();
    }

    // Separate interface for flying birds (ISP)
    public interface IFlyingBird : IBird
    {
        void Fly();
    }

    // Sparrow can fly
    public class Sparrow : IFlyingBird
    {
        public string BirdName => "Sparrow";

        public void Eat()
        {
            Console.WriteLine(BirdName + " is eating grains.");
        }

        public void Fly()
        {
            Console.WriteLine(BirdName + " is flying in the sky.");
        }
    }

    // Penguin cannot fly (Does NOT implement IFlyingBird - satisfies LSP)
    public class Penguin : IBird
    {
        public string BirdName => "Penguin";

        public void Eat()
        {
            Console.WriteLine(BirdName + " is eating fish.");
        }
    }

    // Ostrich cannot fly
    public class Ostrich : IBird
    {
        public string BirdName => "Ostrich";

        public void Eat()
        {
            Console.WriteLine(BirdName + " is eating plants.");
        }
    }
}