namespace ProofOfConcept.DesignPatterns.Behavioral.Observer
{
    public abstract class Observer
    {
        protected Subject subject;
        public abstract void Update();
    }
}
