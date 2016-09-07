using System;

namespace ProofOfConcept.DesignPatterns.Creational.Builder
{
    public class VegBurger : Burger
    {
        public override string Name()
        {
            return "Veg Burger";
        }

        public override float Price()
        {
            return 12.50f;
        }
    }
}