namespace ProofOfConcept.DesignPatterns.Behavioral
{
    using Visitor;

    public class VisitorDemo
    {
        public static void TestVisitor()
        {
            var computer = new Computer();
            computer.Accept(new ComputerPartDisplayVisitor());
        }
    }
}