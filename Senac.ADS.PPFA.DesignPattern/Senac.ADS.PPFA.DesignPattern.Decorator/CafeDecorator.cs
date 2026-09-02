using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Decorator
{
    public abstract class CafeDecorator : ICafe
    {
        protected ICafe? cafe;
        public virtual string Descricao => cafe!.Descricao;

        public virtual double Custo => cafe!.Custo;

        protected CafeDecorator(ICafe cafe)
        {
            this.cafe = cafe;
        }
    }
}
