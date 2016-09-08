namespace ProofOfConcept.DesignPatterns.CompositeEntity
{
    public class CompositeEntity
    {
        private CoarseGrainedObject cgo = new CoarseGrainedObject();

        public void SetData(string data1, string data2)
        {
            cgo.SetData(data1, data2);
        }

        public string[] GetData()
        {
            return cgo.GetData();
        }
    }
}
