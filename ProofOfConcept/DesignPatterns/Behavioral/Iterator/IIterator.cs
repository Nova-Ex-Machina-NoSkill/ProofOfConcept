using System;

namespace ProofOfConcept.DesignPatterns.Behavioral.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        Object Next();
    }
}
