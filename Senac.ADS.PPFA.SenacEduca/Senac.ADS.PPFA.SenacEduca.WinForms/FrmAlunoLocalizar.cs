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
        }
    }
}
