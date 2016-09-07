using System;

namespace ProofOfConcept.DesignPatterns.Creational.Prototype
{
    public class Rectangle : Shape
    {
        public Rectangle() : base("Rectangle") { }

        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle");
        }
    }
}