using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.Structural.Filter
{
    public interface ICriteria
    {
        List<Person> MeetCriteria(List<Person> persons);
    }
}
