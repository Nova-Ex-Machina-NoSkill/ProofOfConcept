using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.InterceptingFilter
{
    public class FilterChain
    {
        private List<IFilter> filters = new List<IFilter>();
        private Target target;

        public void AddFilter(IFilter filter)
        {
            filters.Add(filter);
        }

        public void Execute(string request)
        {
            foreach (IFilter f in filters) f.Execute(request);
        }

        public void SetTarget(Target target)
        {
            this.target = target;
        }
    }
}