using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.Behavioral.Command
{
    public class Broker
    {
        private List<IOrder> orders = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (IOrder o in orders) o.Execute();
            orders.Clear();
        }
    }
}
