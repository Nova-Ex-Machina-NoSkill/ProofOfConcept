using System;

namespace ProofOfConcept.DesignPatterns.Business
{
    public class JMSService : IBusinessService
    {
        public void DoProcessing()
        {
            Console.WriteLine("Processing task by invoking JMS Service");
        }
    }
}
