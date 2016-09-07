namespace ProofOfConcept.DesignPatterns.Creational.AbstractFactory
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            System.Console.WriteLine("Inside Rectangle");
        } 
    }
}