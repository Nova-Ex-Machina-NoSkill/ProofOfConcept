using System;

namespace ProofOfConcept.DesignPatterns.Behavioral
{
    using Null;

    public class NullDemo
    {
        public static void TestNull()
        {
            var c1 = CustomerFactory.GetCustomers("Thomas");
            var c2 = CustomerFactory.GetCustomers("Aga");
            var c3 = CustomerFactory.GetCustomers("Elizabeth");
            var c4 = CustomerFactory.GetCustomers("Unknow");

            Console.WriteLine("Customers: ");
            Console.WriteLine(c1.Name);
            Console.WriteLine(c2.Name);
            Console.WriteLine(c3.Name);
            Console.WriteLine(c4.Name);
        }
    }
}
