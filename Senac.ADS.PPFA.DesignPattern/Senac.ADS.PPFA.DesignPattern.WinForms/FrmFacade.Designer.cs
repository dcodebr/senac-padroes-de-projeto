namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    partial class FrmFacade
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
            label1 = new Label();
            cboProduto = new ComboBox();
            label2 = new Label();
            txtPreco = new TextBox();
            btnFaturar = new Button();
            dgPedidos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgPedidos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Produto";
            // 
            // cboProduto
            // 
            cboProduto.FormattingEnabled = true;
            cboProduto.Items.AddRange(new object[] { "Conjunto de mesa", "Sapato social", "Monitor" });
            cboProduto.Location = new Point(12, 32);
            cboProduto.Name = "cboProduto";
            cboProduto.Size = new Size(327, 28);
            cboProduto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Preço";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(12, 99);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(327, 27);
            txtPreco.TabIndex = 3;
            // 
            // btnFaturar
            // 
            btnFaturar.Location = new Point(245, 132);
            btnFaturar.Name = "btnFaturar";
            btnFaturar.Size = new Size(94, 29);
            btnFaturar.TabIndex = 4;
            btnFaturar.Text = "Faturar";
            btnFaturar.UseVisualStyleBackColor = true;
            btnFaturar.Click += btnFaturar_Click;
            // 
            // dgPedidos
            // 
            dgPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPedidos.Location = new Point(12, 167);
            dgPedidos.Name = "dgPedidos";
            dgPedidos.RowHeadersWidth = 51;
            dgPedidos.Size = new Size(327, 201);
            dgPedidos.TabIndex = 5;
            // 
            // FrmFacade
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 380);
            Controls.Add(dgPedidos);
            Controls.Add(btnFaturar);
            Controls.Add(txtPreco);
            Controls.Add(label2);
            Controls.Add(cboProduto);
            Controls.Add(label1);
            Name = "FrmFacade";
            Text = "FrmFacade";
            ((System.ComponentModel.ISupportInitialize)dgPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboProduto;
        private Label label2;
        private TextBox txtPreco;
        private Button btnFaturar;
        private DataGridView dgPedidos;
    }
}