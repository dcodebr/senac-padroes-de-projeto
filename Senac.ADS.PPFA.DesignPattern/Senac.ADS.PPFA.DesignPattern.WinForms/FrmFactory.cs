using Senac.ADS.PPFA.DesignPattern.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    public partial class FrmFactory : Form
    {
        public FrmFactory()
        {
            InitializeComponent();
        }

        private void FrmFactory_Load(object sender, EventArgs e)
        {

            var dataSource = new List<object>();

            foreach (var tipo in Enum.GetValues<TransporteEnum>())
            {
                var field = tipo.GetType().GetField(tipo.ToString());
                var descricao = field?.GetCustomAttribute<DescriptionAttribute>()?.Description;

                dataSource.Add(
                    new
                    {
                        Value = tipo,
                        Description = descricao
                    }
                );
            }

            cboModal.DataSource = dataSource;
            cboModal.ValueMember = "Value";
            cboModal.DisplayMember = "Description";
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            var tipo = (TransporteEnum?) cboModal.SelectedValue;

            if (tipo is not null) {
                var transporte = TransporteFactory.CreateTransporte(tipo.Value);
                var resultado = transporte.Entregar();

                txtResultado.Text = resultado.ToString();
            }
        }
    }
}
