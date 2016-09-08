namespace ProofOfConcept.DesignPatterns.Creational
{
    using Builder;

    public class BuilderDemo
    {
        public static Builder.Builder builder;

        static BuilderDemo()
        {
            builder = new Builder.Builder();
        }

        public Meal TestVegMeal()
        {
            var meal = builder.PrepareVegMeal();
            System.Console.WriteLine("Veg Meal");
            meal.ShowItems();
            System.Console.WriteLine("Total: " + meal.GetChecked());
            return meal;
        }

        public Meal TestNonVegMeal()
        {
            var meal = builder.PrepareNonVegMeal();
            System.Console.WriteLine("Non-Veg Meal");
            meal.ShowItems();
            System.Console.WriteLine("Total: " + meal.GetChecked());
            return meal;
        }
    }
}