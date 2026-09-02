using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Decorator
{
    public class CafeAdicionalDeLeite : CafeDecorator
    {
        public CafeAdicionalDeLeite(ICafe cafe) : base(cafe)
        {
        }

        public override string Descricao 
            => base.Descricao + " com Leite";

        public override double Custo 
            => base.Custo + 2.50;
    }
}
