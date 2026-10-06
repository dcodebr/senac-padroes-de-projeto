namespace Senac.ADS.PPFA.Revisao1Bi.WinForms
{
    public partial class Form1 : Form
    {
        public List<Pessoa> Pessoas = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            var pessoa = new Pessoa();
            pessoa.Nome = txtNome.Text;
            pessoa.Genero = cboGenero.Text;
            pessoa.Nascimento = dtpNascimento.Value;
            pessoa.CPF = txtCPF.Text;
            Pessoas.Add(pessoa);

            dtgPessoas.DataSource = null;
            dtgPessoas.DataSource = Pessoas;

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblResultado.Text = txtNome.Text;
        }

        private void btnProcessar_MouseHover(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
