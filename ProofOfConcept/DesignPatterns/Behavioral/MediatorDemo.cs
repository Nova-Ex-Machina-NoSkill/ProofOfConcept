namespace ProofOfConcept.DesignPatterns.Behavioral
{
    using Mediator;

    public class MediatorDemo
    {
        public static void TestMediator()
        {
            var thomas = new User("Thomas");
            var aga = new User("Aga");

            thomas.SendMessage("Hello Aga!");
            aga.SendMessage("Stop stalking me prick!");
        }
    }
}