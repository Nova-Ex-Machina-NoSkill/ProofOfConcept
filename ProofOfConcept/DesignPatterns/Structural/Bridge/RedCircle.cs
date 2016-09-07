using System;

namespace ProofOfConcept.DesignPatterns.Structural.Bridge
{
    public class RedCircle : IDraw
    {
        public void Draw(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing Red Circle[Radius: {radius}, X: {x}, Y: {y}]");
        }
    }
}
