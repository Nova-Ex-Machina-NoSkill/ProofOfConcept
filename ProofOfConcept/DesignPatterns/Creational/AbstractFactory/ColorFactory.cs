namespace ProofOfConcept.DesignPatterns.Creational.AbstractFactory
{
    public class ColorFactory : AbstractFactory
    {
        public override IShape GetShape(ShapeEnum shape)
        {
            return null;
        }

        public override IColor GetColor(ColorEnum color)
        {
            if (color.Equals(ColorEnum.Red)) return (IColor)new Red();
            else if (color.Equals(ColorEnum.Green)) return (IColor)new Green();
            else if (color.Equals(ColorEnum.Blue)) return (IColor)new Blue();
            else return null;
        }
    }
}