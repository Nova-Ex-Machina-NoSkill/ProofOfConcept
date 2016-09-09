using System;

namespace ProofOfConcept.DesignPatterns.ServiceLocator
{
    public class Service2 : IService
    {
        public void Execute()
        {
            Console.WriteLine("Executing Service2");
        }

        public string GetName()
        {
            return "Service2";
        }
    }
}
