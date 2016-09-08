using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.Behavioral.Memento
{
    public class CareTaker
    {
        private List<Memento> mementos = new List<Memento>();

        public void Add(Memento memento)
        {
            mementos.Add(memento);
        }

        public Memento Get(int index)
        {
            return mementos[index];
        }
    }
}
