using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.StrategyPattern
{
    public class PagamentoCartaoDeCredito : IPagamento
    {
        public string Pagar(double valor)
        {
            var valorRecebido = valor * 0.8;
            var result = $"Valor pago {valor}, valor recebido {valorRecebido}";
            return result;
        }
    }
}
