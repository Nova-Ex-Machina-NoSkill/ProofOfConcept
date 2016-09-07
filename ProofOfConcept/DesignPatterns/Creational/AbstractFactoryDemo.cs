namespace ProofOfConcept.DesignPatterns.Creational
{
    using AbstractFactory;

    public class AbstractFactoryDemo
    {
        private static AbstractFactory.AbstractFactory shapeFactory;
        private static AbstractFactory.AbstractFactory colorFactory;

        static AbstractFactoryDemo()
        {
            shapeFactory = FactoryProducer.GetFactory(FactoryEnum.Shape);
            colorFactory = FactoryProducer.GetFactory(FactoryEnum.Color);
        }

        public void TestShape()
        {
            var s1 = shapeFactory.GetShape(ShapeEnum.Rectangle);
            var s2 = shapeFactory.GetShape(ShapeEnum.Square);
            var s3 = shapeFactory.GetShape(ShapeEnum.Circle);

            s1.Draw();
            s2.Draw();
            s3.Draw();
        }

        public void TestColor()
        {
            var c1 = colorFactory.GetColor(ColorEnum.Red);
            var c2 = colorFactory.GetColor(ColorEnum.Green);
            var c3 = colorFactory.GetColor(ColorEnum.Blue);

            c1.Fill();
            c2.Fill();
            c3.Fill();
        }
    }
}