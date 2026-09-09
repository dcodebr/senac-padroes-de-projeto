using System;
using System.Collections.Generic;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.Facade
{
    public class LojaFacade
    {
        public readonly SistemaPedido SistemaPedido;
        public readonly SistemaPagamento SistemaPagamento;
        public readonly SistemaEnvio SistemaEnvio;

        public LojaFacade()
        {
            SistemaEnvio = new SistemaEnvio();
            SistemaPagamento = new SistemaPagamento();
            SistemaPedido = new SistemaPedido();
        }

        public Pedido Faturar(string item, double valor) {
            var pedido = new Pedido();

            pedido.Id = SistemaPedido.GerarPedido(item);
            pedido.Item = item;
            pedido.Pagamento = SistemaPagamento.GerarPagamentos(valor);
            pedido.StatusEnvio = SistemaEnvio.EnviarPedido(item);

            return pedido;

        }
    }
}
