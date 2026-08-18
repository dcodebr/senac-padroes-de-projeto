namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    public partial class FrmPatterns : Form
    {
        public FrmPatterns()
        {
            InitializeComponent();
        }

        private void btnBuilder_Click(object sender, EventArgs e) { 
            new FrmBuilder().ShowDialog(this);
        }

        private void btnFactory_Click(object sender, EventArgs e) {
            new FrmFactory().ShowDialog();
        }


        private void btnSingleton_Click(object sender, EventArgs e) {
            new FrmSingleton().Show(this);

        }
}
}
