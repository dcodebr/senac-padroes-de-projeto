using Senac.ADS.PPFA.Revisao.BancoDados;

namespace Senac.ADS.PPFA.Revisao.WinForms
{
    public partial class frmPessoas : Form
    {
        bool edicao = false;
        Pessoa pessoa = new Pessoa();
        List<Pessoa> pessoas = new List<Pessoa>();

        public frmPessoas()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!edicao) {
                pessoa = new Pessoa();
                pessoas.Add(pessoa);
            }
            
            pessoa.Nome = txtNome.Text;
            pessoa.Cpf = txtCpf.Text;
            pessoa.Rg = txtRg.Text;
            pessoa.DataNascimento = dtpDataNascimento.Value;
            
            dgvPessoas.DataSource = null;
            dgvPessoas.DataSource = pessoas;

            LimparCampos();
        }

        private void LimparCampos()
        {
            edicao = false;
            txtNome.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            dtpDataNascimento.Value = DateTime.Now;
        }

        private void CarregarDados()
        {
            edicao = true;
            txtNome.Text = pessoa.Nome;
            txtCpf.Text = pessoa.Cpf;
            txtRg.Text = pessoa.Rg;
            dtpDataNascimento.Value = pessoa.DataNascimento ?? DateTime.Now;
        }

        private void frmPessoas_Load(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void dgvPessoas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha = e.RowIndex;
            pessoa = pessoas.ElementAt(linha);
            CarregarDados();
        }
    }
}
