namespace ProofOfConcept.DesignPatterns.Behavioral.Strategy
{
    public class OperationAdd : IStrategy
    {
        public int DoOperation(int x, int y)
        {
            return x + y;
        }
    }
}
