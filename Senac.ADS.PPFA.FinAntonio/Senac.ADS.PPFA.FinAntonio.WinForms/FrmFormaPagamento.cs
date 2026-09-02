using Equin.ApplicationFramework;
using Senac.ADS.PPFA.FinAntonio.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Senac.ADS.PPFA.FinAntonio.WinForms
{
    public partial class FrmFormaPagamento : Form
    {
        FormaPagamento formaPagamento;
        List<FormaPagamento> formasPagamentos;
        BindingListView<FormaPagamento> datasource;

        public FrmFormaPagamento()
        {
            InitializeComponent();

            formasPagamentos = new List<FormaPagamento>();
            datasource = new BindingListView<FormaPagamento>(formasPagamentos);
            dtgFormasPagamento.DataSource = datasource;

        }

        private void FrmFormaPagamento_Load(object sender, EventArgs e)
        {
            mnuNovo_Click(sender, e);
        }

        private void mnuSalvar_Click(object sender, EventArgs e)
        {
            formaPagamento.Descricao = txtDescricao.Text;

            if (formaPagamento.Id == 0)
            {
                formaPagamento.Id = formasPagamentos.Count + 1;
                formasPagamentos.Add(formaPagamento);
            }

            Limpar();
        }

        private void Limpar()
        {
            txtId.Clear();
            txtDescricao.Clear();
            datasource.Refresh();
        }

        private void dtgFormasPagamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            formaPagamento = formasPagamentos.ElementAt(row);
            Carregar();
        }

        private void Carregar()
        {
            if (formaPagamento is not null)
            {
                txtId.Text = formaPagamento.Id.ToString();
                txtDescricao.Text = formaPagamento.Descricao;
            }
        }

        private void mnuNovo_Click(object sender, EventArgs e)
        {
            formaPagamento = new FormaPagamento();
            Limpar();
        }
    }
}
