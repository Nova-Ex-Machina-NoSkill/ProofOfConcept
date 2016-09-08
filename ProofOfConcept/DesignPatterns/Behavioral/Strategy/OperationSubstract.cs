namespace ProofOfConcept.DesignPatterns.Behavioral.Strategy
{
    public class OperationSubstract : IStrategy
    {
        public int DoOperation(int x, int y)
        {
            return x - y;
        }
    }
}
