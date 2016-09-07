using System;

namespace ProofOfConcept.DesignPatterns.Creational.Prototype
{
    public class Circle : Shape
    {
        public Circle() : base("Circle") { }

        public override void Draw()
        {
            Console.WriteLine("Inside Circle");
        }
    }
}