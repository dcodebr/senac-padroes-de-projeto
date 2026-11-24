using ReaLTaiizor.Forms;
using Senac.ADS.PPFA.SenacEduca.Model;
using Senac.ADS.PPFA.SenacEduca.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Senac.ADS.PPFA.SenacEduca.WinForms
{
    public partial class FrmTurma : MaterialForm
    {
        Turma turma;
        SenacEducaContext Context;

        public FrmTurma(SenacEducaContext context)
        {
            InitializeComponent();
            Context = context;
        }
        private void CarregarDados()
        {
            txtCodigo.Text = turma.Id.ToString();
            txtDescricao.Text = turma.Descricao;
            txtPeriodo.Text = turma.Periodo;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (turma is null)
            {
                turma = new Turma();
                Context.Turmas.Add(turma);
            }

            turma.Descricao = txtDescricao.Text;
            turma.Periodo = txtPeriodo.Text;
            
            Context.SaveChanges();
            CarregarDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
        }
    }
}