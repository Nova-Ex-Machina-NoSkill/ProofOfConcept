using System.Collections.Generic;

namespace ProofOfConcept.DesignPatterns.Behavioral.Observer
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;

        public int State { get { return state; } set { state = value; NotifyAllObservers(); } }

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void NotifyAllObservers()
        {
            foreach (Observer o in observers) o.Update();
        }
    }
}
