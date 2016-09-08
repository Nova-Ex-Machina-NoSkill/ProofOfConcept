namespace ProofOfConcept.DesignPatterns.Behavioral.Strategy
{
    public class OperationMultiply : IStrategy
    {
        public int DoOperation(int x, int y)
        {
            return x * y;
        }
    }
}
