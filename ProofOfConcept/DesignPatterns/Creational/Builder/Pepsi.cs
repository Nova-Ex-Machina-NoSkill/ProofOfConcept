namespace ProofOfConcept.DesignPatterns.Creational.Builder
{
    public class Pepsi : ColdDrink
    {
        public override string Name()
        {
            return "Pepsi";
        }

        public override float Price()
        {
            return 8.50f;
        }
    }
}