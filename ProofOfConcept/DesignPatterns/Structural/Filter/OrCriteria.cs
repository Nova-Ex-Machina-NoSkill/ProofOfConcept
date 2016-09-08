using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.Structural.Filter
{
    public class OrCriteria : ICriteria
    {
        private ICriteria c1;
        private ICriteria c2;

        public OrCriteria(ICriteria c1, ICriteria c2)
        {
            this.c1 = c1;
            this.c2 = c2;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var firstCriteriaItems = c1.MeetCriteria(persons);
            var secondCriteriaItems = c2.MeetCriteria(persons);
            foreach (Person p in secondCriteriaItems) if (!firstCriteriaItems.Contains(p)) firstCriteriaItems.Add(p);
            return firstCriteriaItems;
        }
    }
}
