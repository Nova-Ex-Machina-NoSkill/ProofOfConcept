namespace ProofOfConcept.DesignPatterns.Behavioral.Visitor
{
    public interface IComputerPart
    {
        void Accept(IComputerPartVisitor computerPartVisitor);
    }
}
