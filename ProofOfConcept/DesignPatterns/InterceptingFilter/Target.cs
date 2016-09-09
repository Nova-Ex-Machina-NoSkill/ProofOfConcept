using System;

namespace ProofOfConcept.DesignPatterns.InterceptingFilter
{
    public class Target
    {
        public void Execute(string requst)
        {
            Console.WriteLine("Executing request: " + requst);
        }
    }
}