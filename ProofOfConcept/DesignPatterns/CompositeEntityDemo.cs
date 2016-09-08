namespace ProofOfConcept.DesignPatterns
{
    using CompositeEntity;

    public class CompositeEntityDemo
    {
        public static void TestCompositeEntity()
        {
            var c = new Client();
            c.SetData("Thomas", "Frost");
            c.PrintData();
            c.SetData("Tomasz", "Mróz");
            c.PrintData();
        }
    }
}
