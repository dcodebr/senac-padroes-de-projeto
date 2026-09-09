using Senac.ADS.PPFA.DesignPattern.Facade;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    public partial class FrmFacade : Form
    {
        List<Pedido> pedidos = new();


        public FrmFacade()
        {
            InitializeComponent();
        }

        private void btnFaturar_Click(object sender, EventArgs e)
        {
            var loja = new LojaFacade();

            var item = cboProduto.Text;
            var valor = Convert.ToDouble(txtPreco.Text);

            var pedido = loja.Faturar(item, valor);

            pedidos.Add(pedido);

            dgPedidos.DataSource = null;
            dgPedidos.DataSource = pedidos;
        }
    }
}
