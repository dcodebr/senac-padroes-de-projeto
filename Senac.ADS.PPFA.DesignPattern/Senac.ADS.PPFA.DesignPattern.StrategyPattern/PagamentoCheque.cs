using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.StrategyPattern
{
    public class PagamentoCheque : IPagamento
    {
        public string Pagar(double valor)
        {
            var result = $"Pagamento {valor} realizado com sucesso!";
            result = $"{result}\n Cheque registrado.";

            return result;
        }
    }
}
