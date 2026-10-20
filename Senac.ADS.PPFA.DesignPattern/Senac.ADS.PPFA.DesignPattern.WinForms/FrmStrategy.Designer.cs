namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    partial class FrmStrategy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnPagar = new Button();
            pnlPix = new Panel();
            label3 = new Label();
            txtPixValor = new TextBox();
            cboPagamento = new ComboBox();
            label2 = new Label();
            btnProdutoAdd = new Button();
            txtProduto = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            colProduto = new DataGridViewTextBoxColumn();
            pnlCartaoCredito = new Panel();
            label6 = new Label();
            txtCartaoNumero = new TextBox();
            label7 = new Label();
            txtCartaoCreditoValor = new TextBox();
            pnlCheque = new Panel();
            label5 = new Label();
            txtChequeNumero = new TextBox();
            label4 = new Label();
            txtChequeValor = new TextBox();
            groupBox1.SuspendLayout();
            pnlPix.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            pnlCartaoCredito.SuspendLayout();
            pnlCheque.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnPagar);
            groupBox1.Controls.Add(pnlPix);
            groupBox1.Controls.Add(cboPagamento);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnProdutoAdd);
            groupBox1.Controls.Add(txtProduto);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 388);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedido";
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(354, 273);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(97, 29);
            btnPagar.TabIndex = 7;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            // 
            // pnlPix
            // 
            pnlPix.Controls.Add(label3);
            pnlPix.Controls.Add(txtPixValor);
            pnlPix.Location = new Point(8, 307);
            pnlPix.Name = "pnlPix";
            pnlPix.Size = new Size(443, 75);
            pnlPix.TabIndex = 6;
            pnlPix.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 5;
            label3.Text = "Valor";
            // 
            // txtPixValor
            // 
            txtPixValor.Location = new Point(3, 35);
            txtPixValor.Name = "txtPixValor";
            txtPixValor.Size = new Size(160, 27);
            txtPixValor.TabIndex = 0;
            // 
            // cboPagamento
            // 
            cboPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPagamento.FormattingEnabled = true;
            cboPagamento.Items.AddRange(new object[] { "Pix", "Cartão de Crédito", "Cheque" });
            cboPagamento.Location = new Point(8, 273);
            cboPagamento.Name = "cboPagamento";
            cboPagamento.Size = new Size(340, 28);
            cboPagamento.TabIndex = 5;
            cboPagamento.SelectedIndexChanged += cboPagamento_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 250);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 4;
            label2.Text = "Pagamento";
            // 
            // btnProdutoAdd
            // 
            btnProdutoAdd.Location = new Point(414, 55);
            btnProdutoAdd.Name = "btnProdutoAdd";
            btnProdutoAdd.Size = new Size(37, 29);
            btnProdutoAdd.TabIndex = 3;
            btnProdutoAdd.Text = "+";
            btnProdutoAdd.UseVisualStyleBackColor = true;
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(8, 57);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(400, 27);
            txtProduto.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 33);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Produto";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colProduto });
            dataGridView1.Location = new Point(6, 90);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(445, 134);
            dataGridView1.TabIndex = 0;
            // 
            // colProduto
            // 
            colProduto.HeaderText = "Produto";
            colProduto.MinimumWidth = 6;
            colProduto.Name = "colProduto";
            colProduto.ReadOnly = true;
            colProduto.Width = 300;
            // 
            // pnlCartaoCredito
            // 
            pnlCartaoCredito.Controls.Add(label6);
            pnlCartaoCredito.Controls.Add(txtCartaoNumero);
            pnlCartaoCredito.Controls.Add(label7);
            pnlCartaoCredito.Controls.Add(txtCartaoCreditoValor);
            pnlCartaoCredito.Location = new Point(19, 319);
            pnlCartaoCredito.Name = "pnlCartaoCredito";
            pnlCartaoCredito.Size = new Size(443, 75);
            pnlCartaoCredito.TabIndex = 9;
            pnlCartaoCredito.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 12);
            label6.Name = "label6";
            label6.Size = new Size(111, 20);
            label6.TabIndex = 7;
            label6.Text = "Número Cartão";
            // 
            // txtCartaoNumero
            // 
            txtCartaoNumero.Location = new Point(169, 35);
            txtCartaoNumero.Name = "txtCartaoNumero";
            txtCartaoNumero.Size = new Size(271, 27);
            txtCartaoNumero.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 12);
            label7.Name = "label7";
            label7.Size = new Size(43, 20);
            label7.TabIndex = 5;
            label7.Text = "Valor";
            // 
            // txtCartaoCreditoValor
            // 
            txtCartaoCreditoValor.Location = new Point(3, 35);
            txtCartaoCreditoValor.Name = "txtCartaoCreditoValor";
            txtCartaoCreditoValor.Size = new Size(160, 27);
            txtCartaoCreditoValor.TabIndex = 0;
            // 
            // pnlCheque
            // 
            pnlCheque.Controls.Add(label5);
            pnlCheque.Controls.Add(txtChequeNumero);
            pnlCheque.Controls.Add(label4);
            pnlCheque.Controls.Add(txtChequeValor);
            pnlCheque.Location = new Point(19, 322);
            pnlCheque.Name = "pnlCheque";
            pnlCheque.Size = new Size(443, 75);
            pnlCheque.TabIndex = 10;
            pnlCheque.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(169, 12);
            label5.Name = "label5";
            label5.Size = new Size(117, 20);
            label5.TabIndex = 7;
            label5.Text = "Numero Cheque";
            // 
            // txtChequeNumero
            // 
            txtChequeNumero.Location = new Point(169, 35);
            txtChequeNumero.Name = "txtChequeNumero";
            txtChequeNumero.Size = new Size(271, 27);
            txtChequeNumero.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 5;
            label4.Text = "Valor";
            // 
            // txtChequeValor
            // 
            txtChequeValor.Location = new Point(3, 35);
            txtChequeValor.Name = "txtChequeValor";
            txtChequeValor.Size = new Size(160, 27);
            txtChequeValor.TabIndex = 0;
            // 
            // FrmStrategy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 412);
            Controls.Add(pnlCheque);
            Controls.Add(pnlCartaoCredito);
            Controls.Add(groupBox1);
            Name = "FrmStrategy";
            Text = "FrmStrategy";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlPix.ResumeLayout(false);
            pnlPix.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            pnlCartaoCredito.ResumeLayout(false);
            pnlCartaoCredito.PerformLayout();
            pnlCheque.ResumeLayout(false);
            pnlCheque.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnProdutoAdd;
        private TextBox txtProduto;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colProduto;
        private Panel pnlPix;
        private Label label3;
        private TextBox txtPixValor;
        private ComboBox cboPagamento;
        private Label label2;
        private Button btnPagar;
        private Panel pnlCartaoCredito;
        private Label label6;
        private TextBox txtCartaoNumero;
        private Label label7;
        private TextBox txtCartaoCreditoValor;
        private Panel pnlCheque;
        private Label label5;
        private TextBox txtChequeNumero;
        private Label label4;
        private TextBox txtChequeValor;
    }
}