namespace ProofOfConcept.DesignPatterns.Behavioral
{
    using State;

    public class StateDemo
    {
        public void TestState()
        {
            var context = new Context();

            var startState = new StartState();
            var stopState = new StopState();

            startState.DoAction(context);
            System.Console.WriteLine(context.State + " " + context.ToString());

            stopState.DoAction(context);
            System.Console.WriteLine(context.State + " " + context.ToString());
        }
    }
}