namespace ProofOfConcept.DesignPatterns.Behavioral.State
{
    public class Context
    {
        private IState state;

        public IState State { get { return state; } set { state = value; } }

        public Context()
        {
            state = null;
        }
    }
}
