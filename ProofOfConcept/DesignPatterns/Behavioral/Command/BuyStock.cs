namespace ProofOfConcept.DesignPatterns.Behavioral.Command
{
    public class BuyStock : IOrder
    {
        private Stock stock;

        public BuyStock(Stock stock)
        {
            this.stock = stock;
        }

        public void Execute()
        {
            stock.Buy();
        }
    }
}
