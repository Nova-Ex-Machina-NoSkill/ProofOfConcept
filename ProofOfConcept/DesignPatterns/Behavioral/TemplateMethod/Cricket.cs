using System;

namespace ProofOfConcept.DesignPatterns.Behavioral.TemplateMethod
{
    public class Cricket : Game
    {
        protected override void endPlay()
        {
            Console.WriteLine("Cricket Game Finished!");
        }

        protected override void initialize()
        {
            Console.WriteLine("Cricket Game Initialized!");
        }

        protected override void startPlay()
        {
            Console.WriteLine("Cricket Game Started");
        }
    }
}
