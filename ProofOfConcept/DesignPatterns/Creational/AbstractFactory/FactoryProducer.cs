namespace ProofOfConcept.DesignPatterns.Creational.AbstractFactory
{
    public class FactoryProducer
    {
        public static AbstractFactory GetFactory(FactoryEnum choice)
        {
            if (choice.Equals(FactoryEnum.Color)) return (AbstractFactory)new ColorFactory();
            else if (choice.Equals(FactoryEnum.Shape)) return (AbstractFactory)new ShapeFactory();
            else return null;
        }
    }
}