namespace ProofOfConcept.DesignPatterns.Behavioral
{
    using Interpreter;

    public class InterpreterDemo
    {
        public static void TestInterpreter()
        {
            var isMale = getMaleExpression();
            var isMarriedWoman = getMarriedWomanExpression();

            System.Console.WriteLine("Thomas is male? " + isMale.Interpret("Thomas"));
            System.Console.WriteLine("Aga is married women? " + isMarriedWoman.Interpret("Married Aga"));
        }

        private static IExpression getMaleExpression()
        {
            var thomas = new TerminalExpression("Thomas");
            var robert = new TerminalExpression("Robert");
            return new OrExpression(thomas, robert);
        }

        private static IExpression getMarriedWomanExpression()
        {
            var aga = new TerminalExpression("Aga");
            var married = new TerminalExpression("Married");
            return new AndExpression(aga, married);
        }
    }
}