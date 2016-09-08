using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.Structural.Filter
{
    public class CriteriaMale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var malePersons = new List<Person>();
            foreach (Person p in persons) if (p.Gender.ToUpper() == "MALE") malePersons.Add(p);
            return malePersons;
        }
    }
}
