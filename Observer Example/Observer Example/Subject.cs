using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Example
{
    public class Subject
    {
        private List<IObserver> Observers;

        public Subject()
        {
            this.Observers = new List<IObserver>();
        }

        public void Notify()
        {
            foreach (IObserver observer in Observers)
            {
                observer.Update();
            }
        }

        public void Subscribe(IObserver observer)
        {
            this.Observers.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            this.Observers.Remove(observer);
        }
    }
}
