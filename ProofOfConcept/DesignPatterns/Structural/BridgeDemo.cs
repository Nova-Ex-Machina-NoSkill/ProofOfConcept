namespace ProofOfConcept.DesignPatterns.Structural
{
    using Bridge;

    public class BridgeDemo
    {
        public static void TestBridge()
        {
            var redCircle = new Circle(50, 50, 10, new RedCircle());
            var greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            redCircle.Draw();
        }
    }
}