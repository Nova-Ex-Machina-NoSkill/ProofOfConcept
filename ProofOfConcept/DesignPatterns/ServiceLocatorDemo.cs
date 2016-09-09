namespace ProofOfConcept.DesignPatterns
{
    using ServiceLocator;

    public class ServiceLocatorDemo
    {
        public static void TestServiceLocator()
        {
            var service = ServiceLocator.ServiceLocator.GetService("Service1");
            service.Execute();
            service = ServiceLocator.ServiceLocator.GetService("Service2");
            service.Execute();
            service = ServiceLocator.ServiceLocator.GetService("Service1");
            service.Execute();
            service = ServiceLocator.ServiceLocator.GetService("Service2");
            service.Execute();
        }
    }
}
