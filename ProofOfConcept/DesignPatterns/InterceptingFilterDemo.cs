namespace ProofOfConcept.DesignPatterns
{
    using InterceptingFilter;

    public class InterceptingFilterDemo
    {
        public static void TestInterceptingFilter()
        {
            var filterManager = new FilterManager(new Target());
            filterManager.SetFilter(new AuthenticationFilter());
            filterManager.SetFilter(new DebugFilter());

            var client = new Client();
            client.SetFilterManager(filterManager);
            client.SendRequest("HOME");
        }
    }
}
