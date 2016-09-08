namespace ProofOfConcept.DesignPatterns.Behavioral.Null
{
    public class NullCustomer : AbstractCustomer
    {
        public NullCustomer()
        {
            this.name = "Not Available!";
        }

        public override bool IsNull()
        {
            return true;
        }
    }
}