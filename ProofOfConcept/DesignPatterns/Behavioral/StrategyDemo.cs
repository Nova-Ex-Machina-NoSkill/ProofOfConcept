namespace ProofOfConcept.DesignPatterns.Behavioral
{
    using Strategy;

    public class StrategyDemo
    {
        public void TestStrategy()
        {
            var context = new Context(new OperationAdd());
            System.Console.WriteLine("15 + 5: " + context.ExecuteStrategy(15, 5));

            context = new Context(new OperationSubstract());
            System.Console.WriteLine("15 - 5: " + context.ExecuteStrategy(15, 5));

            context = new Context(new OperationMultiply());
            System.Console.WriteLine("15 * 5: " + context.ExecuteStrategy(15, 5));

            context = new Context(new OperationDivide());
            System.Console.WriteLine("15 / 5: " + context.ExecuteStrategy(15, 5));
        }
    }
}