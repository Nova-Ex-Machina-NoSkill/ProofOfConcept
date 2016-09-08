using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.Structural.Filter
{
    public class CriteriaSingle : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var singlePersons = new List<Person>();
            foreach (Person p in persons) if (p.MaritalStatus.ToUpper() == "SINGLE") singlePersons.Add(p);
            return singlePersons;
        }
    }
}
