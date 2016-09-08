namespace ProofOfConcept.DesignPatterns.Business
{
    public class Client
    {
        BusinessDelegate businessService;

        public Client(BusinessDelegate businessService)
        {
            this.businessService = businessService;
        }

        public void DoTask()
        {
            businessService.DoTask();
        }
    }
}
