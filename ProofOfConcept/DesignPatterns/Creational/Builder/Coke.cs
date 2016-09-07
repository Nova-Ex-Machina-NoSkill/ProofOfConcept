namespace ProofOfConcept.DesignPatterns.Creational.Builder
{
    public class Coke : ColdDrink
    {
        public override string Name()
        {
            return "Coke";
        }

        public override float Price()
        {
            return 7.50f;
        }
    }
}