using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Factory
{
    public static class TransporteFactory
    {
        public static ITransporte CreateTransporte(TransporteEnum tipoTransporte) {
            return tipoTransporte switch
            {
                TransporteEnum.MARITIMO => new TransporteMaritimo(),
                TransporteEnum.FERROVIARIO => new TransporteFerroviario(),
                TransporteEnum.RODOVIÁRIO => new TransporteRodoviario(),
                _ => throw new NotImplementedException(),
            };
        }
    }
}
