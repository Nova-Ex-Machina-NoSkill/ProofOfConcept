using System;
using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.Creational.Builder
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public float GetChecked()
        {
            var cost = 0f;
            foreach (IItem item in items) cost += item.Price();
            return cost;
        }

        public void ShowItems()
        {
            foreach(IItem item in items)
            {
                Console.WriteLine("Item: " + item.Name());
                Console.WriteLine("Packing: " + item.Packing());
                Console.WriteLine("Price: " + item.Price() + "\n");
            }
        }
    }
}