using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Builder
{
    public class CarroFordKa : CarroBuilder
    {
        public override void InformarDados()
        {
            carro.AnoFabricacao = 2026;
            carro.AnoModelo = 2025;
            carro.Modelo = "Ká";
            carro.Fabricante = "Ford";
        }
    }
}
