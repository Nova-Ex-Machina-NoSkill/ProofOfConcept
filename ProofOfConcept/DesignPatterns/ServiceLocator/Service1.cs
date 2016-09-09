using System;

namespace ProofOfConcept.DesignPatterns.ServiceLocator
{
    public class Service1 : IService
    {
        public void Execute()
        {
            Console.WriteLine("Executing Service1");
        }

        public string GetName()
        {
            return "Service1";
        }
    }
}
