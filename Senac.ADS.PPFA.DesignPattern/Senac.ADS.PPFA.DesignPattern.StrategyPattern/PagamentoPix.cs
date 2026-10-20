using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.StrategyPattern
{
    public class PagamentoPix : IPagamento
    {
        public string Pagar(double valor)
        {
            var desconto = valor * .10;
            var valorComDesconto = valor - desconto;

            var result = $"O valor com desconto ficará {valorComDesconto}";
            return result;
        }
    }
}
