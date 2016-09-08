namespace ProofOfConcept.DesignPatterns
{
    using Business;

    public class BusinessDemo
    {
        public static void TestBusiness()
        {
            var businessDelegate = new BusinessDelegate();
            businessDelegate.SetServiceType(ServiceTypeEnum.EJB);

            var client = new Client(businessDelegate);
            client.DoTask();

            businessDelegate.SetServiceType(ServiceTypeEnum.JMS);
            client.DoTask();
        }
    }
}