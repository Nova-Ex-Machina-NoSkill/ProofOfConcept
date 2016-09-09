namespace ProofOfConcept.DesignPatterns.ServiceLocator
{
    public class ServiceLocator
    {
        private static Cache cache;

        static ServiceLocator()
        {
            cache = new Cache();
        }

        public static IService GetService(string jndiName)
        {
            var service = cache.GetService(jndiName);

            if (service != null) return service;

            var context = new InitialContext();
            var newService = (IService)context.Lookup(jndiName);
            cache.AddService(newService);
            return newService;
        }
    }
}
