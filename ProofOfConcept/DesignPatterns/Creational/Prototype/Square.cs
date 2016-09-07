using System;

namespace ProofOfConcept.DesignPatterns.Creational.Prototype
{
    public class Square : Shape
    {
        public Square() : base("Square") { }

        public override void Draw()
        {
            Console.WriteLine("Inside Square");
        }
    }
}