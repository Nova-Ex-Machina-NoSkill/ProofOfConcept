using System;

namespace ProofOfConcept.DesignPatterns.InterceptingFilter
{
    public class DebugFilter : IFilter
    {
        public void Execute(string request)
        {
            Console.WriteLine("Request log: " + request);
        }
    }
}
