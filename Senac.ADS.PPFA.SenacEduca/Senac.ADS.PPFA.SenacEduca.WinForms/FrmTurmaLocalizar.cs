using Equin.ApplicationFramework;
using ReaLTaiizor.Forms;
using Senac.ADS.PPFA.SenacEduca.Repositories;
using Senac.ADS.PPFA.SenacEduca.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Senac.ADS.PPFA.SenacEduca.WinForms
{
    public partial class FrmTurmaLocalizar : MaterialForm
    {
        private SenacEducaContext Context;
        private BindingListView<TurmaViewModel> datasource;

        public FrmTurmaLocalizar(SenacEducaContext context)
        {
            InitializeComponent();

            Context = context;
        }

        private void FrmTurmaLocalizar_Load(object sender, EventArgs e)
        {
            var turmas = Context.Turmas.Select(turma => new TurmaViewModel
            {
                Id = turma.Id,
                Descricao = turma.Descricao,
                Periodo = turma.Periodo,
            }).ToList();

            datasource = new BindingListView<TurmaViewModel>(turmas);
            dtgAlunos.DataSource = datasource;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            datasource.ApplyFilter(turma => {
                bool filtrar = true;

                filtrar &= turma.Descricao!.Contains(txtDescricao.Text);
                filtrar &= turma.Periodo!.Contains(txtPeriodo.Text);


                return filtrar;
            });

        }
    }
}
