using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Decorator
{
    public class CafeAdicionalDeAcucar : CafeDecorator
    {
        public CafeAdicionalDeAcucar(ICafe cafe) : base(cafe)
        {
        }

        public override string Descricao 
            => base.Descricao + " com açucar";

        public override double Custo => base.Custo + 1.50;
    }
}
