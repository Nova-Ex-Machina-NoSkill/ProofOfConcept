namespace ProofOfConcept.DesignPatterns.Business
{
    public class BusinessDelegate
    {
        private BusinessLookUp lookupService = new BusinessLookUp();
        private IBusinessService businessService;
        private ServiceTypeEnum serviceType;

        public void SetServiceType(ServiceTypeEnum serviceType)
        {
            this.serviceType = serviceType;
        }

        public void DoTask()
        {
            businessService = lookupService.GetBusinessService(serviceType);
            businessService.DoProcessing();
        }
    }
}
