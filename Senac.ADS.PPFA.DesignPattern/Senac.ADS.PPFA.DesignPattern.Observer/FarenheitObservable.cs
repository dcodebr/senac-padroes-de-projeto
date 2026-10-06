using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Observer
{
    public class FahrenheitObservable : IObservable<double>
    {
        public Action<double> Callback { get; set; }

        public FahrenheitObservable(Action<double> callback)
        {
            Callback = callback;
        }

        public void Update(double value)
        {
            var fahrenheit = value * 9 / 5 + 32;
            Callback(fahrenheit);
        }
    }
}
