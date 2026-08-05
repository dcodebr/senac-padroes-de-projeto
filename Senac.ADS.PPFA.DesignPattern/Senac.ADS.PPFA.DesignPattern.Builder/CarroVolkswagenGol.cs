using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Builder
{
    public class CarroVolkswagenGol : CarroBuilder
    {
        public override void InformarDados()
        {
            carro.AnoFabricacao = 2022;
            carro.AnoModelo = 2022;
            carro.Modelo = "Gol";
            carro.Fabricante = "Volkswagen";
        }
    }
}
