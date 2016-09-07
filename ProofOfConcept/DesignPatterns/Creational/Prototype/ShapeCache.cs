using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.Creational.Prototype
{
    public class ShapeCache
    {
        private static Dictionary<string, Shape> shapeDictionary;

        static ShapeCache()
        {
            shapeDictionary = new Dictionary<string, Shape>();
            var c = new Circle();
            c.Id = "1";
            shapeDictionary.Add(c.Id, c);
            var s = new Square();
            s.Id = "2";
            shapeDictionary.Add(s.Id, s);
            var r = new Rectangle();
            r.Id = "3";
            shapeDictionary.Add(r.Id, r);
        }

        public static Shape GetShape(string id)
        {
            return (Shape)shapeDictionary[id].Clone();
        }
    }
}
