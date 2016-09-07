namespace ProofOfConcept.DesignPatterns.Behavioral.Iterator
{
    public class NameRepository : IContainer
    {
        private string[] names = { "Thomas", "Robert", "Aga", "Julia" };

        public IIterator GetIterator()
        {
            return new NameIterator(names);
        }

        private class NameIterator : IIterator
        {
            private int index;
            private string[] names;

            public NameIterator(string[] names)
            {
                this.names = names;
            }

            public bool HasNext()
            {
                if (index < names.Length) return true;
                else return false;
            }

            public object Next()
            {
                if (HasNext()) return names[index++];
                else return null;
            }
        }
    }
}
