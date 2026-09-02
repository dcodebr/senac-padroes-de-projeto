using Senac.ADS.PPFA.DesignPattern.Decorator;
using Senac.ADS.PPFA.DesignPattern.Decorator.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    public partial class FrmDecorator : Form
    {
        private ICafe cafe;

        public FrmDecorator()
        {
            InitializeComponent();
        }

        private void FrmDecorator_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            cafe = new CafeSimples();
            txtPedido.Text = cafe.Descricao;
        }

        private void btnMaisLeite_Click(object sender, EventArgs e)
        {
            cafe = new CafeAdicionalDeLeite(cafe);
            txtPedido.Text = cafe.Descricao;
        }

        private void btnMaisAvela_Click(object sender, EventArgs e)
        {
            cafe = new CafeAdicionalDeAvela(cafe);
            txtPedido.Text = cafe.Descricao;
        }

        private void btnMaisAcucar_Click(object sender, EventArgs e)
        {
            cafe = new CafeAdicionalDeAcucar(cafe);
            txtPedido.Text = cafe.Descricao;
        }

        private void btnAnnotation_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            txtPedido.Text = pedido.cafe.Servir();
        }
    }
}
