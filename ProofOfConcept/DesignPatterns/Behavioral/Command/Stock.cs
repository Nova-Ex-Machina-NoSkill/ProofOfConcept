using System;

namespace ProofOfConcept.DesignPatterns.Behavioral.Command
{
    public class Stock
    {
        private string name = "ABC";
        private int quantity = 10;

        public void Buy()
        {
            Console.WriteLine($"Stock [Name: {name}, Quantity: {quantity}] bought!");
        }

        public void Sell()
        {
            Console.WriteLine($"Stoock [Name: {name}, Quantity: {quantity}] sold!");
        }
    }
}
