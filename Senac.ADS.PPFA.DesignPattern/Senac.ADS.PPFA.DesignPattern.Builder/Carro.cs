using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Builder
{
    public class Carro
    {
        public Carro() { }

        public Carro(string fabricante, string modelo, int anoFabricacao, int anoModelo)
        {
            Fabricante = fabricante;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
            AnoModelo = anoModelo;
        }

        public string Fabricante { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
    }
}
