namespace ProofOfConcept.DesignPatterns.Behavioral
{
    using Iterator;

    public class IteratorDemo
    {
        public static void TestIterator()
        {
            var namesRepository = new NameRepository();

            for(var i = namesRepository.GetIterator(); i.HasNext();)
            {
                var name = (string)i.Next();
                System.Console.WriteLine("Name: " + name);
            }
        }
    }
}