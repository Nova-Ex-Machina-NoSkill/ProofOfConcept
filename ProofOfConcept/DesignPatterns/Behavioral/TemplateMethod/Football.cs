using System;

namespace ProofOfConcept.DesignPatterns.Behavioral.TemplateMethod
{
    public class Football : Game
    {
        protected override void endPlay()
        {
            Console.WriteLine("Football Game Finished!");
        }

        protected override void initialize()
        {
            Console.WriteLine("Football Game Initialized!");
        }

        protected override void startPlay()
        {
            Console.WriteLine("Football Game Started!");
        }
    }
}
