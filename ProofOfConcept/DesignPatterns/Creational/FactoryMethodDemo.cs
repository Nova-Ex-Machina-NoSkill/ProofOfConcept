namespace ProofOfConcept.DesignPatterns.Creational
{
    public class FactoryMethodDemo
    {
        private static FactoryMethod.ShapeFactory shapeFactory;

        static FactoryMethodDemo()
        {
            shapeFactory = new FactoryMethod.ShapeFactory();
        }

        public void TestShape()
        {
            var s1 = shapeFactory.GetShape(FactoryMethod.ShapeEnum.Rectangle);
            var s2 = shapeFactory.GetShape(FactoryMethod.ShapeEnum.Square);
            var s3 = shapeFactory.GetShape(FactoryMethod.ShapeEnum.Circle);

            s1.Draw();
            s2.Draw();
            s3.Draw();
        }
    }
}