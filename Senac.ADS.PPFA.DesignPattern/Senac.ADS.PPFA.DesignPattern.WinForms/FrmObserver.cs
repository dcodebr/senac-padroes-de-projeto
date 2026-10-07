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
        private CelsiusObservable celsiusObserver;
        private FahrenheitObservable fahrenheitObservable;
        private KelvinObservable kelvinObservable;

        public FrmObserver()
        {
            InitializeComponent();
            estacao = new EstacaoMeteorologica();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            Task.Run(() => {
                while (true) {
                    var random = new Random();
                    estacao.Temperatura = random.NextInt64(0, 250);

                    Thread.Sleep(2000);
                }
            });
        }

        private void btnCelsiusAdd_Click(object sender, EventArgs e)
        {
            lblCelsius.Visible = true;
            label1.Visible = true;

            estacao.Subscribe(celsiusObserver);
        }

        private void btnFahrenheitAdd_Click(object sender, EventArgs e)
        {
            lblFahrenheit.Visible = true;
            label3.Visible = true;

            estacao.Subscribe(fahrenheitObservable);
        }

        private void btnKelvinAdd_Click(object sender, EventArgs e)
        {
            lblKelvin.Visible = true;
            label5.Visible = true;

            estacao.Subscribe(kelvinObservable);
        }

        private void FrmObserver_Load(object sender, EventArgs e)
        {
            celsiusObserver = new CelsiusObservable(valor =>
            {
                this.BeginInvoke((Action)(() => {
                    lblCelsius.Text = $"{valor} ºC";
                }));
            });

            fahrenheitObservable = new FahrenheitObservable(valor =>
            {
                this.BeginInvoke((Action)(() => {
                    lblFahrenheit.Text = $"{valor} ºF";
                }));
            });

            kelvinObservable = new KelvinObservable(valor =>
            {
                this.BeginInvoke((Action)(() => {
                    lblKelvin.Text = $"{valor} K";
                }));
            });


        }

        private void btnCelsiusRemove_Click(object sender, EventArgs e)
        {
            estacao.Unsubscribe(celsiusObserver);
        }

        private void btnFahrenheitRemove_Click(object sender, EventArgs e)
        {
            estacao.Unsubscribe(fahrenheitObservable);
        }

        private void btnKelvinRemove_Click(object sender, EventArgs e)
        {
            estacao.Unsubscribe(kelvinObservable);
        }
    }
}
