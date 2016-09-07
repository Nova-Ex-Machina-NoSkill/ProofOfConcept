using System;

namespace ProofOfConcept.DesignPatterns.Structural.Proxy
{
    public class RealImage : IImage
    {
        private string fileName;

        public RealImage(string fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying: " + fileName);
        }

        private void loadFromDisk(string fileName)
        {
            Console.WriteLine("Loading" + fileName);
        }
    }
}
