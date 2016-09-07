using System;
using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.Structural.Flyweight
{
    public sealed class ShapeFactory
    {
        private static Dictionary<string, IShape> circleDictionary;

        static ShapeFactory()
        {
            circleDictionary = new Dictionary<string, IShape>();
        }

        public static IShape GetCircle(string color)
        {
            var circle = (Circle)circleDictionary[color];

            if (circle == null)
            {
                circle = new Circle(color);
                circleDictionary.Add(color, circle);
                Console.WriteLine("Creating Circle with Color: " + color);
            }
            return circle;
        }
    }
}
