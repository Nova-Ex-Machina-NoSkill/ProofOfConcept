namespace ProofOfConcept.DesignPatterns.Behavioral.Memento
{
    public class Originator
    {
        private string state;

        public string State { get { return state; } set { state = value; } }

        public Memento SaveStateToMemento()
        {
            return new Memento(state);
        }

        public void GetStateFromMemento(Memento memento)
        {
            state = memento.State;
        }
    }
}
