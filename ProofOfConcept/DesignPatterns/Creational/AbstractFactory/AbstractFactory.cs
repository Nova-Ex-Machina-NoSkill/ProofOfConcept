namespace ProofOfConcept.DesignPatterns.Creational.AbstractFactory
{
    abstract public class AbstractFactory
    {
        abstract public IShape GetShape(ShapeEnum shape);
        abstract public IColor GetColor(ColorEnum color);
    }
}