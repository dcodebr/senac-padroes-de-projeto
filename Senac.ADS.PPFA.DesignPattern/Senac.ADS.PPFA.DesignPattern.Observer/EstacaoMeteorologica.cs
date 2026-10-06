using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Observer
{
    public class EstacaoMeteorologica : Publisher<double>
    {
        private double temperatura = 0;

        public double Temperatura
        {
            set
            {
                temperatura = value;
                NotifyObservables(temperatura);
            }
        }
    }
}
