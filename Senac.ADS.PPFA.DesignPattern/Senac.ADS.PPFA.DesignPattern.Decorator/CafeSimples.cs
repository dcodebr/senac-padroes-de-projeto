using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Decorator
{
    public class CafeSimples : ICafe
    {
        public string Descricao => "Café Simples";

        public double Custo => 5.00;
    }
}
