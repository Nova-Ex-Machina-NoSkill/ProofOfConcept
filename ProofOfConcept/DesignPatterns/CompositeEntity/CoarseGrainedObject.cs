namespace ProofOfConcept.DesignPatterns.CompositeEntity
{
    public class CoarseGrainedObject
    {
        DependentObject1 d1 = new DependentObject1();
        DependentObject2 d2 = new DependentObject2();

        public void SetData(string data1, string data2)
        {
            d1.Data = data1;
            d2.Data = data2;
        }

        public string[] GetData()
        {
            return new string[] { d1.Data, d2.Data };
        }
    }
}
