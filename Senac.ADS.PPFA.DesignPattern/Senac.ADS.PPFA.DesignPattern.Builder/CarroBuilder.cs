using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Builder
{
    public abstract class CarroBuilder
    {
        protected Carro carro;

        public void CriarCarro() { carro = new Carro(); }

        public Carro GetCarro() { return carro; }

        public abstract void InformarDados();
    }
}
