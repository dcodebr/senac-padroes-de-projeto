using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Observer
{
    public class CelsiusObservable : IObservable<double>
    {
        public Action<double> Callback { get; set; }

        public CelsiusObservable(Action<double> callback)
        {
            Callback = callback;
        }
        public void Update(double value)
        {
            Callback(value);
        }
    }
}
