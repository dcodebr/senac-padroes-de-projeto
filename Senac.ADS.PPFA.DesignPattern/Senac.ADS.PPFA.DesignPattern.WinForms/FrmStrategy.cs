using Senac.ADS.PPFA.DesignPattern.StrategyPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    public partial class FrmStrategy : Form
    {
        Pedido pedido = new Pedido();

        public FrmStrategy()
        {
            InitializeComponent();
        }

        private void cboPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCartaoCredito.Visible = false;
            pnlCheque.Visible = false;
            pnlPix.Visible = false;

            switch (cboPagamento.SelectedIndex)
            {
                case 0:
                    pnlPix.Visible = true;
                    break;
                case 1:
                    pnlCartaoCredito.Visible = true;
                    break;
                case 2:
                    pnlCheque.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            double valor = 0;

            switch (cboPagamento.SelectedIndex)
            {
                case 0:
                    pedido.Pagamento = new PagamentoPix();
                    valor = Convert.ToDouble(txtPixValor.Text);
                    break;
                case 1:
                    pedido.Pagamento = new PagamentoCartaoDeCredito();
                    valor = Convert.ToDouble(txtCartaoCreditoValor.Text);
                    break;
                case 2:
                    pedido.Pagamento = new PagamentoCheque();
                    valor = Convert.ToDouble(txtChequeValor.Text);
                    break;
                default:
                    break;
            }

            var resposta = pedido.Pagamento.Pagar(valor);
            MessageBox.Show(resposta);
        }
    }
}
