using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Factory
{
    public class TransporteMaritimo : ITransporte
    {
        public string Entregar()
        {
            return "Transportando pelo mar!";
        }
    }
}
