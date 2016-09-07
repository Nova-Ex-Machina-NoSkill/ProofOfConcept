using System;

namespace ProofOfConcept.DesignPatterns.Structural.Facade
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square");
        }
    }
}
