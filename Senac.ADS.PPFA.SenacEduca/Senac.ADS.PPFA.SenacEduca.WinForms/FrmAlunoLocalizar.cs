using Equin.ApplicationFramework;
using ReaLTaiizor.Forms;
using Senac.ADS.PPFA.SenacEduca.Repositories;
using Senac.ADS.PPFA.SenacEduca.ViewModel;

namespace Senac.ADS.PPFA.SenacEduca.WinForms
{
    public partial class FrmAlunoLocalizar : MaterialForm
    {
        private SenacEducaContext Context;
        private BindingListView<AlunoViewModel> datasource;

        public FrmAlunoLocalizar(SenacEducaContext context)
        {
            InitializeComponent();

            Context = context;
        }

        private void FrmAlunoLocalizar_Load(object sender, EventArgs e)
        {
            var alunos = Context.Alunos.Select(aluno => new AlunoViewModel
            {
                Id = aluno.Id,
                CPF = aluno.CPF,
                Nome = aluno.Nome,
                Telefone = aluno.Telefone,
                TurmaDescricao = (aluno.Turma != null) ? aluno.Turma.Descricao : String.Empty,
                TurmaPeriodo = aluno.Turma != null ? aluno.Turma.Periodo : String.Empty,
            }).ToList();

            datasource = new BindingListView<AlunoViewModel>(alunos);
            dtgAlunos.DataSource = datasource;

            var turmas = Context.Turmas.ToList();
            turmas.Add(new Model.Turma
            {
                Descricao = String.Empty
            });


            turmas = turmas.OrderBy(turmas => turmas.Descricao)
                           .ToList();

            cboTurma.DataSource = turmas;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            datasource.ApplyFilter(aluno => aluno.Nome!.Contains(txtNome.Text));

            var cpf = txtCPF.Text;
            cpf = cpf.Replace(".", String.Empty)
                     .Replace("-", String.Empty);

            if (!String.IsNullOrWhiteSpace(cpf))
            {
                datasource.ApplyFilter(aluno => aluno.CPF!.Equals(txtCPF.Text));
            }

            if (cboTurma.Text != String.Empty)
            {
                datasource.ApplyFilter(aluno => aluno.TurmaDescricao!.Equals(cboTurma.Text));
            }
        }
    }
}
