using System;

namespace ProofOfConcept.DesignPatterns.Business
{
    public class EJBService : IBusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("Processing task by invoking EJB Service");
        }
    }
}
