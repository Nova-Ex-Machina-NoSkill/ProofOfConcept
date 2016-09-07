using System;

namespace ProofOfConcept.DesignPatterns.Structural.Decorator
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle");
        }
    }
}