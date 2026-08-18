using System.ComponentModel;

namespace Senac.ADS.PPFA.DesignPattern.Factory
{
    public enum TransporteEnum
    {
        [Description("Modal Marítimo")] 
        MARITIMO = 1,

        [Description("Modal Ferroviário")] 
        FERROVIARIO,
        
        [Description("Modal Rodoviario")] 
        RODOVIÁRIO
    }
}