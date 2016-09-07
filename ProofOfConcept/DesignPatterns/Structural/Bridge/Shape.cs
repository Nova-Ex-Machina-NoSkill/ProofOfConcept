namespace ProofOfConcept.DesignPatterns.Structural.Bridge
{
    public abstract class Shape
    {
        protected IDraw API;

        protected Shape(IDraw API)
        {
            this.API = API;
        }

        public abstract void Draw();
    }
}
