namespace ProofOfConcept.DesignPatterns.Behavioral.Null
{
    public abstract class AbstractCustomer
    {
        protected string name;

        public string Name { get { return name; } }

        public abstract bool IsNull();
        
    }
}
