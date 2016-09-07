using System;

namespace ProofOfConcept.DesignPatterns.Structural.Facade
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle");
        }
    }
}
