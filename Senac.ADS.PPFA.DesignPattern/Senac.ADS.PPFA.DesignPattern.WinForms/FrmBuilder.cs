using Senac.ADS.PPFA.DesignPattern.Builder;
using System.Text;

namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    public partial class FrmBuilder : Form
    {
        public FrmBuilder()
        {
            InitializeComponent();
        }

        private void ImprimirCarro(Carro carro)
        {
            var strBuilder = new StringBuilder();
            strBuilder.Append($"Carro - modelo: {carro.Modelo}, ");
            strBuilder.Append($"fabricante: {carro.Fabricante}, ");
            strBuilder.Append($"ano fabricacao: {carro.AnoFabricacao}, ");
            strBuilder.Append($"ano modelo: {carro.AnoModelo}");

            var text = strBuilder.ToString();

            MessageBox.Show(text);
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            var builder = new CarroFluentBuilder();

            var modelo = txtModelo.Text;
            var fabricante = cboFabricante.Text;
            var anoFabricacao = Convert.ToInt32(txtAnoFabricacao.Text.Substring(1));
            var anoModelo = Convert.ToInt32(txtModelo.Text.Substring(1));

            var carro = builder.SetModelo(modelo)
                               .SetFabricante(fabricante)
                               .SetAnoFabricacao(anoFabricacao)
                               .SetAnoModelo(anoModelo)
                               .Build();

            ImprimirCarro(carro);
        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            CarroBuilder carroBuilder = new CarroVolkswagenGol();

            carroBuilder.CriarCarro();
            carroBuilder.InformarDados();
            Carro carro = carroBuilder.GetCarro();

            ImprimirCarro(carro);

            carroBuilder = new CarroFordKa();
            carroBuilder.CriarCarro();
            carroBuilder.InformarDados();

            Carro carro2 = carroBuilder.GetCarro();

            ImprimirCarro(carro2);
        }

        private void btnFluentBuilder_Click(object sender, EventArgs e)
        {
            var fluentBuilder = new CarroFluentBuilder();
            var carro = fluentBuilder.SetAnoFabricacao(2025)
                                     .SetModelo("Tracker")
                                     .SetAnoModelo(2026)
                                     .SetFabricante("Chevrolet")
                                     .Build();

            ImprimirCarro(carro);
        }
    }
}
