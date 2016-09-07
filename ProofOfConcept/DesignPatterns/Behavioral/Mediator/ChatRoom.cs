using System;

namespace ProofOfConcept.DesignPatterns.Behavioral.Mediator
{
    public class ChatRoom
    {
        public static void ShowMessage(User user, string message)
        {
            Console.WriteLine(new DateTime().ToString() + $" [{user.Name}]: {message}");
        }
    }
}