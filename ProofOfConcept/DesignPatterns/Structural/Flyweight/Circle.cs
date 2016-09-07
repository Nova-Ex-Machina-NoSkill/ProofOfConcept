using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProofOfConcept.DesignPatterns.Structural.Flyweight
{
    public class Circle : IShape
    {
        private string color;
        private int x;
        private int y;
        private int radius;

        public int X { set { x = value; } }
        public int Y { set { y = value; } }
        public int Radius { set { radius = value; } }

        public Circle(string color)
        {
            this.color = color;
        }

        public void Draw()
        {
            Console.WriteLine($"Circle: [Color: {color}, X: {x}, Y: {y}, Radius: {radius}]");
        }
    }
}
