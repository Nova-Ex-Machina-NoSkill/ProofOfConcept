namespace ProofOfConcept.DesignPatterns.InterceptingFilter
{
    public class Client
    {
        FilterManager filterManager;

        public void SetFilterManager(FilterManager filterManager)
        {
            this.filterManager = filterManager;
        }

        public void SendRequest(string request)
        {
            filterManager.FilterRequest(request);
        }
    }
}
