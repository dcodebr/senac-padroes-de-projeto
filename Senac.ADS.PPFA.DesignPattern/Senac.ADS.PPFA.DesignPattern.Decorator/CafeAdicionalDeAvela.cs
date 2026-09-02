using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Decorator
{
    public class CafeAdicionalDeAvela : CafeDecorator
    {
        public CafeAdicionalDeAvela(ICafe cafe) : base(cafe)
        {
        }

        public override string Descricao 
            => base.Descricao + " com avelã";

        public override double Custo 
            => base.Custo + 5.00;
    }
}
