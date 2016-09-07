using System;

namespace ProofOfConcept.DesignPatterns.Creational.AbstractFactory
{
    public class ShapeFactory : AbstractFactory
    {
        public override IShape GetShape(ShapeEnum shape)
        {
            if (shape.Equals(ShapeEnum.Circle)) return (IShape)new Circle();
            else if (shape.Equals(ShapeEnum.Rectangle)) return (IShape)new Rectangle();
            else if (shape.Equals(ShapeEnum.Square)) return (IShape)new Square();
            else return null;
        }

        public override IColor GetColor(ColorEnum color)
        {
            return null;
        }
    }
}