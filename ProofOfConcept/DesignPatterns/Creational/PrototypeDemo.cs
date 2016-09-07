namespace ProofOfConcept.DesignPatterns.Creational
{
    using Prototype;

    public class PrototypeDemo
    {
        public static void TestShapes()
        {
            var s1 = ShapeCache.GetShape("1");
            var s2 = ShapeCache.GetShape("2");
            var s3 = ShapeCache.GetShape("3");
            System.Console.WriteLine("Shape: " + s1.Type);
            System.Console.WriteLine("Shape: " + s2.Type);
            System.Console.WriteLine("Shape: " + s3.Type);
        }
    }
}