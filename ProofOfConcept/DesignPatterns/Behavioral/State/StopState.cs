using System;

namespace ProofOfConcept.DesignPatterns.Behavioral.State
{
    public class StopState : IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in stop state");
            context.State = this;
        }

        public override string ToString()
        {
            return "Stop State";
        }
    }
}
