namespace ProofOfConcept.DesignPatterns.Behavioral
{
    using Command;

    public class CommandDemo
    {
        public void TestCommand()
        {
            var stock = new Stock();
            var buyStockOrder = new BuyStock(stock);
            var sellStockOrder = new SellStock(stock);

            var broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();
        }
    }
}