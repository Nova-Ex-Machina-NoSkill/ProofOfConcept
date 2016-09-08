namespace ProofOfConcept.DesignPatterns.Behavioral.Strategy
{
    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public int ExecuteStrategy(int x, int y)
        {
            return strategy.DoOperation(x, y);
        }
    }
}
