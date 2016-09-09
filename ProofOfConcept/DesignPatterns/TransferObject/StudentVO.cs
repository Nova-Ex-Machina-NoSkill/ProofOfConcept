namespace ProofOfConcept.DesignPatterns.TransferObject
{
    public class StudentVO
    {
        private string name;
        private int rollNo;

        public string Name { get { return name; } set { name = value; } }
        public int RollNo { get { return rollNo; } set { rollNo = value; } }

        public StudentVO(string name, int rollNo)
        {
            this.name = name;
            this.rollNo = rollNo;
        }
    }
}