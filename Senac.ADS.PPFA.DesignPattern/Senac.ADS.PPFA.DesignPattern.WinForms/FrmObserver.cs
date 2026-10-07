using Senac.ADS.PPFA.DesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    public partial class FrmObserver : Form
    {
        private EstacaoMeteorologica estacao;

        public FrmObserver()
        {
            InitializeComponent();
            estacao = new EstacaoMeteorologica();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            var random = new Random();
            estacao.Temperatura = random.NextInt64(0, 100);
        }

        private void btnCelsiusAdd_Click(object sender, EventArgs e)
        {
            lblCelsius.Visible = true;
            label1.Visible = true;

            var celsiusObserver = new CelsiusObservable(valor =>
            {
                lblCelsius.Text = $"{valor} ºC";
            });

            estacao.Subscribe(celsiusObserver);
        }

        private void btnFahrenheitAdd_Click(object sender, EventArgs e)
        {
            lblFahrenheit.Visible = true;
            label3.Visible = true;

            var fahrenheitObservable = new FahrenheitObservable(valor =>
            {
                lblFahrenheit.Text = $"{valor} ºF";
            });

            estacao.Subscribe(fahrenheitObservable);
        }

        private void btnKelvinAdd_Click(object sender, EventArgs e)
        {
            lblKelvin.Visible = true;
            label5.Visible = true;

            var kelvinObservable = new KelvinObservable(valor => {
                lblKelvin.Text = $"{valor} K";
            });

            estacao.Subscribe(kelvinObservable);
        }
    }
}
