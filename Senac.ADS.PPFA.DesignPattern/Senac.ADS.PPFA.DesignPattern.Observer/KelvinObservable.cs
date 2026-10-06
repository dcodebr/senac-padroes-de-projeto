using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Observer
{
    public class KelvinObservable : IObservable<double>
    {
        public Action<double> Callback { get; set; }

        public KelvinObservable(Action<double> callback)
        {
            Callback = callback;
        }

        public void Update(double value)
        {
            var kelvin = value + 273.15;
            Callback(kelvin);
        }
    }
}
