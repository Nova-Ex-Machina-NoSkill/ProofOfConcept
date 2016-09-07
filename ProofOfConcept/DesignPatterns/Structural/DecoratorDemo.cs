namespace ProofOfConcept.DesignPatterns.Structural
{
    using Decorator;

    public class DecoratorDemo
    {
        public static void TestDecorator()
        {
            var circle = new Circle();
            var rectangle = new Rectangle();
            var redCircle = new RedShapeDecorator(new Circle());
            var redRectangle = new RedShapeDecorator(new Rectangle());
            System.Console.WriteLine("Normal Shapes");
            circle.Draw();
            rectangle.Draw();
            System.Console.WriteLine("Decorated Shapes");
            redCircle.Draw();
            redRectangle.Draw();
        }
    }
}