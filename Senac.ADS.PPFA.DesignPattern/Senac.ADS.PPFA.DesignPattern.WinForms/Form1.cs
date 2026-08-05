using Senac.ADS.PPFA.DesignPattern.Builder;

namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void ImprimirCarro(Carro carro)
        {
            MessageBox.Show($"Carro - modelo: {carro.Modelo}, " +
        $"fabricante: {carro.Fabricante}, " +
        $"ano fabricacao: {carro.AnoFabricacao}, " +
        $"ano modelo: {carro.AnoModelo}");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var builder = new CarroFluentBuilder();

            var carro = builder.SetModelo(txtModelo.Text)
                               .SetFabricante(cboFabricante.Text)
                               .SetAnoFabricacao(Convert.ToInt32(txtAnoFabricacao.Text.Substring(1)))
                               .SetAnoModelo(Convert.ToInt32(txtAnoModelo.Text.Substring(1)))
                               .Build();

            ImprimirCarro(carro);
        }
    }
}
