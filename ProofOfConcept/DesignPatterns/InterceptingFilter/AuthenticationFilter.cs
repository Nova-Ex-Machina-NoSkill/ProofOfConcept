using System;

namespace ProofOfConcept.DesignPatterns.InterceptingFilter
{
    public class AuthenticationFilter : IFilter
    {
        public void Execute(string request)
        {
            Console.WriteLine("Authenticating request: " + request);
        }
    }
}
