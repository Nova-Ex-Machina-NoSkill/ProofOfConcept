using System;

namespace ProofOfConcept.DesignPatterns.Behavioral.ChainOfResponsibility
{
    public class FileLogger : AbstractLoger
    {
        public FileLogger(int level)
        {
            this.level = level;
        }

        protected override void write(string message)
        {
            Console.WriteLine("File: " + message);
        }
    }
}