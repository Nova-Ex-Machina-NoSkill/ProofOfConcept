using System;

namespace ProofOfConcept.DesignPatterns.Behavioral.Visitor
{
    public class ComputerPartDisplayVisitor : IComputerPartVisitor
    {
        public void Visit(Keyboard keyboard)
        {
            Console.WriteLine("Display keyboard");
        }

        public void Visit(Monitor monitor)
        {
            Console.WriteLine("Display monitor");
        }

        public void Visit(Mouse mouse)
        {
            Console.WriteLine("Display mouse");
        }

        public void Visit(Computer computer)
        {
            Console.WriteLine("Display computer");
        }
    }
}
