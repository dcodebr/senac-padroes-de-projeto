using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.StrategyPattern
{
    public class Pedido
    {
        public string[] Produtos { get; set; }
        public IPagamento Pagamento { get; set; }
    }
}
