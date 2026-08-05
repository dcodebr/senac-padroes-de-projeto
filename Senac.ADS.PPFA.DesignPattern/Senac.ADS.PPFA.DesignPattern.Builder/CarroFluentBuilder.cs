using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Builder;

public class CarroFluentBuilder
{
    public string _fabricante;
    public string _modelo;
    public int _anoFabricacao;
    public int _anoModelo;

    public CarroFluentBuilder SetFabricante(string fabricante)
    {
        _fabricante = fabricante;
        return this;
    }

    public CarroFluentBuilder SetModelo(string modelo)
    {
        _modelo = modelo;
        return this;
    }

    public CarroFluentBuilder SetAnoFabricacao(int anoFabricacao)
    {
        _anoFabricacao = anoFabricacao;
        return this;
    }

    public CarroFluentBuilder SetAnoModelo(int anoModelo)
    {
        _anoModelo = anoModelo;
        return this;
    }

    public Carro Build() {
        var carro = new Carro(_fabricante, 
                              _modelo, 
                              _anoFabricacao, 
                              _anoModelo);
        return carro;
    }
}
