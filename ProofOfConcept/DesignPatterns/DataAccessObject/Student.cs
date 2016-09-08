namespace ProofOfConcept.DesignPatterns.DataAccessObject
{
    public class Student
    {
        private string name;
        private int rollNo;

        public string Name { get { return name; } set { name = value; } }
        public int RollNo { get { return rollNo; } set { rollNo = value; } }

        public Student(string name, int rollNo)
        {
            this.name = name;
            this.rollNo = rollNo;
        }
    }
}
