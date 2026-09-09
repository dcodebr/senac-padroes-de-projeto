using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Facade
{
    public class Pedido
    {
        public int? Id { get; set; }
        public string? Item { get; set; }
        public string? Pagamento { get; set; }
        public string? StatusEnvio { get; set; }
    }
}
