using System;

namespace ProofOfConcept.DesignPatterns.CompositeEntity
{
    public class Client
    {
        private CompositeEntity compositeEntity = new CompositeEntity();

        public void PrintData()
        {
            foreach (string s in compositeEntity.GetData()) Console.WriteLine("Data: " + s);
        }

        public void SetData(string data1, string data2)
        {
            compositeEntity.SetData(data1, data2);
        }
    }
}
