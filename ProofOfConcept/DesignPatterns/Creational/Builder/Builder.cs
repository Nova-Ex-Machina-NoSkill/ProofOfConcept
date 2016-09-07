namespace ProofOfConcept.DesignPatterns.Creational.Builder
{
    public class Builder
    {
        public Meal PrepareVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Pepsi());
            return meal;
        }

        public Meal PrepareNonVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new ChickenBurger());
            meal.AddItem(new Coke());
            return meal;
        }
    }
}
