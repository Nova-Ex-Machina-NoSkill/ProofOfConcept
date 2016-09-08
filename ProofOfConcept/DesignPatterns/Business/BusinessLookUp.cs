namespace ProofOfConcept.DesignPatterns.Business
{
    public class BusinessLookUp
    {
        public IBusinessService GetBusinessService(ServiceTypeEnum serviceType)
        {
            if (serviceType.Equals(ServiceTypeEnum.EJB)) return new EJBService();
            else if (serviceType.Equals(ServiceTypeEnum.JMS)) return new JMSService();
            else return null;
        }
    }
}
