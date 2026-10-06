using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Observer
{
    public abstract class Publisher<TValue>
    {
        protected List<IObservable<TValue>> observables { get; private set; }
        protected Publisher() => observables= new List<IObservable<TValue>>();

        public void Subscribe(IObservable<TValue> observable) 
            => observables.Add(observable);

        public void Unsubscribe(IObservable<TValue> observable)
            => observables.Remove(observable);

        public void NotifyObservables(TValue value)
            => observables.ForEach(o => o.Update(value));

    }
}
