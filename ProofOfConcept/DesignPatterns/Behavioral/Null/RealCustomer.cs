namespace ProofOfConcept.DesignPatterns.Behavioral.Null
{
    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }

        public override bool IsNull()
        {
            return false;
        }
    }
}
