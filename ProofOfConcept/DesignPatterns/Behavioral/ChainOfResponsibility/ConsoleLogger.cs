using System;

namespace ProofOfConcept.DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class ConsoleLogger : AbstractLoger
    {
        public ConsoleLogger(int level)
        {
            this.level = level;
        }

        protected override void write(string message)
        {
            Console.WriteLine("Standard Console: " + message);
        }
    }
}
