using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.Structural.Filter
{
    public class AndCriteria : ICriteria
    {
        private ICriteria c1;
        private ICriteria c2;

        public AndCriteria(ICriteria c1, ICriteria c2)
        {
            this.c1 = c1;
            this.c2 = c2;
        }

        public List<Person> MeetCriteria(List<Person> persons)
        {
            var firstCriteriaPersons = c1.MeetCriteria(persons);
            return c2.MeetCriteria(firstCriteriaPersons);
        }
    }
}
