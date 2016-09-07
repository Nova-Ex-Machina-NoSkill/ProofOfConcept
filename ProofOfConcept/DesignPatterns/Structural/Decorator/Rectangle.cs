using System;

namespace ProofOfConcept.DesignPatterns.Structural.Decorator
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle");
        }
    }
}