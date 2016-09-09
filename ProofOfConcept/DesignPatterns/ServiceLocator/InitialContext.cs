using System;

namespace ProofOfConcept.DesignPatterns.ServiceLocator
{
    public class InitialContext
    {
        public object Lookup(string jndiName)
        {
            if(jndiName.ToUpper() == "SERVICE1")
            {
                Console.WriteLine("Looking up and creating a new Serice1 object");
                return new Service1();
            } else if (jndiName.ToUpper() == "SERVICE2")
            {
                Console.WriteLine("Looking up and creating a new Service2 object");
                return new Service2();
            }
            return null;
        }
    }
}
