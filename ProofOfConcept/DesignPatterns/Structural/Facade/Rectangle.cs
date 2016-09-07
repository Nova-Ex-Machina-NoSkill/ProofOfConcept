using System;

namespace ProofOfConcept.DesignPatterns.Structural.Facade
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle");
        }
    }
}
