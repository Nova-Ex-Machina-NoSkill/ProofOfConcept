using System;

namespace ProofOfConcept.DesignPatterns.Structural.Bridge
{
    public class GreenCircle : IDraw
    {
        public void Draw(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing Green Circle[Radius: {radius}, X: {x}, Y: {y}]");
        }
    }
}
