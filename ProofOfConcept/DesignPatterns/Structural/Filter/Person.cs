namespace ProofOfConcept.DesignPatterns.Structural.Filter
{
    public class Person
    {
        private string name;
        private string gender;
        private string maritalStatus;

        public string Name { get { return name; } }

        public string Gender { get { return gender; } }

        public string MaritalStatus { get { return maritalStatus; } }

        public Person(string name, string gender, string maritalStatus)
        {
            this.name = name;
            this.gender = gender;
            this.maritalStatus = maritalStatus;
        }
    }
}