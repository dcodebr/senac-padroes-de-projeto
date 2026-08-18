using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Factory
{
    public class TransporteFerroviario : ITransporte
    {
        public string Entregar()
        {
            return "Transportando pela estrada de ferro!";
        }
    }
}
