namespace ProofOfConcept.DesignPatterns.Structural
{
    using Facade;

    public class FacadeDemo
    {
        public static void TestFacade()
        {
            var shapeMaker = new ShapeMaker();
            shapeMaker.DrawCircle();
            shapeMaker.DrawRectangle();
            shapeMaker.DrawSquare();
        }
    }
}