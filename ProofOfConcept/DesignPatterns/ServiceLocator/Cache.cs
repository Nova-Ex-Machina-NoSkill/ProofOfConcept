using System;
using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.ServiceLocator
{
    public class Cache
    {
        private List<IService> services;

        public Cache()
        {
            services = new List<IService>();
        }

        public IService GetService(string serviceName)
        {
            foreach (IService s in services)
            {
                if (s.GetName() == serviceName)
                {
                    Console.WriteLine("Returning cached " + serviceName + " object");
                    return s;
                }
            }
            return null;
        }

        public void AddService(IService newService)
        {
            var exists = false;
            foreach (IService s in services) if (s.GetName() == newService.GetName()) exists = true;
            if (!exists) services.Add(newService);
        }
    }
}
