using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Facade
{
    public class SistemaPagamento
    {
        public string GerarPagamentos(double valor) {
            var parcela = valor / 12;
            var resultado = $"12 x {parcela}";
            return resultado;
        }
    }
}
