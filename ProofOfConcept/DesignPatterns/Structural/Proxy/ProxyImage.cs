namespace ProofOfConcept.DesignPatterns.Structural.Proxy
{
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private string fileName;

        public ProxyImage(string fileName)
        {
            this.fileName = fileName;
        }

        public void Display()
        {
            if (realImage != null) realImage.Display();
            else realImage = new RealImage(fileName);
        }
    }
}