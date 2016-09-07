namespace ProofOfConcept.DesignPatterns.Structural
{
    using Proxy;

    public class ProxyDemo
    {
        public static void TestProxy()
        {
            var image = new ProxyImage("Test.jpg");
            image.Display();
            System.Console.WriteLine();
            image.Display();
        }
    }
}