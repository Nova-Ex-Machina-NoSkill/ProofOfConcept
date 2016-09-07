namespace ProofOfConcept.DesignPatterns.Creational.Builder
{
    abstract public class ColdDrink : IItem
    {
        public abstract string Name();

        public IPacking Packing()
        {
            return new Bottle();
        }

        public abstract float Price();
    }
}