namespace ProofOfConcept.DesignPatterns.Behavioral.Visitor
{
    public class Computer : IComputerPart
    {
        private IComputerPart[] parts;

        public Computer()
        {
            parts = new IComputerPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public void Accept(IComputerPartVisitor computerPartVisitor)
        {
            foreach (IComputerPart part in parts) part.Accept(computerPartVisitor);
            computerPartVisitor.Visit(this);
        }
    }
}
