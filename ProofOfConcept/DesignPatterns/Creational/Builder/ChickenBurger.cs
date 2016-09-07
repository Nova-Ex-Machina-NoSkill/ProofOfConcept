namespace ProofOfConcept.DesignPatterns.Creational.Builder
{
    public class ChickenBurger : Burger
    {
        public override string Name()
        {
            return "Chicken Burger";
        }

        public override float Price()
        {
            return 17.50f;
        }
    }
}