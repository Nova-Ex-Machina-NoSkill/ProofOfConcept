using System;

namespace ProofOfConcept.DesignPatterns.Behavioral.Observer
{
    public class StateObserver : Observer
    {
        public StateObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("Binary String: " + subject.State);
        }
    }
}
