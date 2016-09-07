namespace ProofOfConcept.DesignPatterns.Behavioral
{
    using TemplateMethod;

    public class TemplateMethodDemo
    {
        public static void TestTemplateMetchod()
        {
            Game game = new Cricket();
            game.Play();
            System.Console.WriteLine();
            game = new Football();
            game.Play();
        }
    }
}