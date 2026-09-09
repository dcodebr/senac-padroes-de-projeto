using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Facade
{
    public class SistemaPedido
    {
        public static int idPedido = 0;

        public int GerarPedido(string item) {
            idPedido++;
            return idPedido;
        }
    }
}
