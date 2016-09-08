namespace ProofOfConcept.DesignPatterns.Behavioral
{
    using Memento;

    public class MementoDemo
    {
        public static void TestMemento()
        {
            var originator = new Originator();
            var careTaker = new CareTaker();

            originator.State = "State #1";
            originator.State = "State #2";
            careTaker.Add(originator.SaveStateToMemento());

            originator.State = "State #3";
            careTaker.Add(originator.SaveStateToMemento());

            originator.State = "State #4";
            System.Console.WriteLine("Current State: " + originator.State);

            originator.GetStateFromMemento(careTaker.Get(0));
            System.Console.WriteLine("First state: " + originator.State);

            originator.GetStateFromMemento(careTaker.Get(1));
            System.Console.WriteLine("Second state: " + originator.State);
        }
    }
}