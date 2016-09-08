using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.Structural.Filter
{
    public class CriteriaFemale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> persons)
        {
            var femalePersons = new List<Person>();
            foreach (Person p in persons) if (p.Gender.ToUpper() == "FEMALE") femalePersons.Add(p);
            return femalePersons;
        }
    }
}
