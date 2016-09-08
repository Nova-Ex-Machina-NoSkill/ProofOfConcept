namespace ProofOfConcept.DesignPatterns.Behavioral.Null
{
    public class CustomerFactory
    {
        public static readonly string[] names = { "Thomas", "Aga", "Elizabeth" };

        public static AbstractCustomer GetCustomers(string name)
        {
            foreach (string s in names) if (s.Equals(name)) return new RealCustomer(name);
            return new NullCustomer();
        }
    }
}
