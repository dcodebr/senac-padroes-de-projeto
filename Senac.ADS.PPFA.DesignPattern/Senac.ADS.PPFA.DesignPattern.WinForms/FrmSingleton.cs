using Senac.ADS.PPFA.DesignPattern.Singleton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    public partial class FrmSingleton : Form
    {
        ContadorSingleton contador = ContadorSingleton.getInstance();

        public FrmSingleton()
        {
            InitializeComponent();
        }

        private void CarregarContador()
        {
            var text = $"Contador: {contador.Valor}";
            lblContador.Text = text;
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            contador.Incrementar();
            CarregarContador();
        }

        private void FrmSingleton_Activated(object sender, EventArgs e)
        {
            CarregarContador();
        }
    }
}
