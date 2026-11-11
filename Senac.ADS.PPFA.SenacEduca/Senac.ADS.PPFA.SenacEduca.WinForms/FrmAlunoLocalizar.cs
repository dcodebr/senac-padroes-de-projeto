using Equin.ApplicationFramework;
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
    public partial class FrmAlunoLocalizar : MaterialForm
    {
        private SenacEducaContext Context;
        private BindingListView<Aluno> datasource;

        public FrmAlunoLocalizar(SenacEducaContext context)
        {
            InitializeComponent();


            Context = context;
            var alunos = Context.Alunos.ToList();


            datasource = new BindingListView<Aluno>(alunos);
            dtgAlunos.DataSource = datasource;
        }

        private void FrmAlunoLocalizar_Load(object sender, EventArgs e)
        {
        }
    }
}
