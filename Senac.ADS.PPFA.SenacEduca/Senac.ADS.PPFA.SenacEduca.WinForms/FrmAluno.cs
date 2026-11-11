using Microsoft.EntityFrameworkCore;
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
    public partial class FrmAluno : MaterialForm
    {
        Aluno aluno;
        SenacEducaContext Context;
        FrmAlunoLocalizar FrmAlunoLoc; //

        public FrmAluno(SenacEducaContext context, FrmAlunoLocalizar frmAlunoLocalizar) //
        {
            InitializeComponent();
            Context = context;
            FrmAlunoLoc = frmAlunoLocalizar; //
        }
        private void CarregarDados()
        {
            txtCodigo.Text = aluno.Id.ToString();
            txtNome.Text = aluno.Nome;
            txtCPF.Text = aluno.CPF;
            txtTelefone.Text = aluno.Telefone;

            if (aluno.Turma is not null)
            {
                cboTurma.SelectedValue = aluno.TurmaId!;
            }
        }


        private void FrmAluno1_Load(object sender, EventArgs e)
        {
            var turmas = Context.Turmas.ToList();
            cboTurma.DataSource = turmas;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (aluno is null)
            {
                aluno = new Aluno();
                Context.Alunos.Add(aluno);
            }

            aluno.Nome = txtNome.Text;
            aluno.Telefone = txtTelefone.Text;
            aluno.CPF = txtCPF.Text;
            aluno.TurmaId = Convert.ToInt32(cboTurma.SelectedValue);

            Context.SaveChanges();

            CarregarDados();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            FrmAlunoLoc.ShowDialog();
        }
    }
}
