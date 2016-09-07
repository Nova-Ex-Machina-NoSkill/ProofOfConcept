using System;

namespace ProofOfConcept.DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class ErrorLogger : AbstractLoger
    {
        public ErrorLogger(int level)
        {
            this.level = level;
        }

        protected override void write(string message)
        {
            Console.WriteLine("Error Console: " + message);
        }
    }
}
