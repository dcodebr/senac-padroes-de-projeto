using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    public partial class FrmStrategy : Form
    {
        public FrmStrategy()
        {
            InitializeComponent();
        }

        private void cboPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlCartaoCredito.Visible = false;
            pnlCheque.Visible = false;
            pnlPix.Visible = false;

            switch (cboPagamento.SelectedIndex)
            {
                case 0:
                    pnlPix.Visible = true;
                    break;
                case 1:
                    pnlCartaoCredito.Visible = true;
                    break;
                case 2:
                    pnlCheque.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
