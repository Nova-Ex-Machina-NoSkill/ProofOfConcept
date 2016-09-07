using System;

namespace ProofOfConcept.DesignPatterns.Structural
{
    using Flyweight;

    public class FlyweightDemo
    {
        private static string[] colors = { "Red", "Green", "Blue", "Yellow", "White", "Black", "Purple" };
        private static Random r = new Random();
        
        public static void TestFlywieght()
        {
            for(int i = 0; i < 10; i++)
            {
                var circle = (Circle)ShapeFactory.GetCircle(getRandomColor());
                circle.X = r.Next(100);
                circle.Y = r.Next(100);
                circle.Radius = r.Next(100);
                circle.Draw();
            }
        }

        private static string getRandomColor()
        {
            return colors[r.Next(colors.Length)];
        }
    }
}