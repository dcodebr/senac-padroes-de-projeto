using Senac.ADS.PPFA.SenacEduca.Model;
using Senac.ADS.PPFA.SenacEduca.Repositories;

namespace Senac.ADS.PPFA.SenacEduca.WinForms
{
    public partial class FrmAluno : Form
    {
        Aluno aluno;
        SenacEducaContext Context;

        public FrmAluno(SenacEducaContext context)
        {
            InitializeComponent();
            Context = context;
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

        private void CarregarDados()
        {
            txtCodigo.Text = aluno.Id.ToString();
            txtNome.Text = aluno.Nome;
            txtCPF.Text = aluno.CPF;
            txtTelefone.Text = aluno.Telefone;

            if (aluno.Turma is not null) {
                cboTurma.SelectedValue = aluno.TurmaId!;
            }
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            var turmas = Context.Turmas.ToList();
            cboTurma.DataSource = turmas;
        }
    }
}
