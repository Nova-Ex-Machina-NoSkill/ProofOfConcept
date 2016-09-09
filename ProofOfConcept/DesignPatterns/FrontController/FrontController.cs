using System;

namespace ProofOfConcept.DesignPatterns.FrontController
{
    public class FrontController
    {
        private Dispatcher dispatcher;

        public FrontController()
        {
            dispatcher = new Dispatcher();
        }

        private bool isAuthenticUser()
        {
            Console.WriteLine("User is authenticated successfully.");
            return true;
        }

        private void trackRequest(string request)
        {
            Console.WriteLine("Pare request: " + request);
        }

        public void DispatchRequest(string request)
        {
            trackRequest(request);

            if (isAuthenticUser()) dispatcher.Dispatch(request);
        }
    }
}
