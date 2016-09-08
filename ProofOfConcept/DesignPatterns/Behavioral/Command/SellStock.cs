namespace ProofOfConcept.DesignPatterns.Behavioral.Command
{
    public class SellStock : IOrder
    {
        private Stock stock;

        public SellStock(Stock stock)
        {
            this.stock = stock;
        }

        public void Execute()
        {
            stock.Sell();
        }
    }
}
