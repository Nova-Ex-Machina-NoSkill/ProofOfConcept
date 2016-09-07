namespace ProofOfConcept.DesignPatterns.Creational.FactoryMethod
{
    public class ShapeFactory
    {
        public IShape GetShape(ShapeEnum shape)
        {
            if (shape.Equals(ShapeEnum.Rectangle)) return new Rectangle();
            else if (shape.Equals(ShapeEnum.Square)) return new Square();
            else if (shape.Equals(ShapeEnum.Circle)) return new Circle();
            else return null;
        }
    }
}