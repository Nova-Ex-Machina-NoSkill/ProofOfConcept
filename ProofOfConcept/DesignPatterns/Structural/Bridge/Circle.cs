namespace ProofOfConcept.DesignPatterns.Structural.Bridge
{
    public class Circle : Shape
    {
        private int x;
        private int y;
        private int radius;

        public Circle(int x, int y, int radius, IDraw API) : base(API)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            API.Draw(radius, x, y);
        }
    }
}