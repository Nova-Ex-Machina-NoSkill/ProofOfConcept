namespace ProofOfConcept.DesignPatterns.Creational.AbstractFactory
{
    public class Red : IColor
    {
        public void Fill()
        {
            System.Console.WriteLine("Inside Red");
        }
    }
}