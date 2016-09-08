namespace ProofOfConcept.DesignPatterns.Behavioral
{
    using Observer;

    public class ObserverDemo
    {
        public void TestObserver()
        {
            var s = new Subject();
            new StateObserver(s);
            System.Console.WriteLine("States: ");
            s.State = 15;
            s.State = 25;
            s.State = 10;
        }
    }
}