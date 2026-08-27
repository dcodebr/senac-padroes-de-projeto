namespace Senac.ADS.PPFA.FinAntonio.WinForms
{
    partial class FrmFormaPagamento
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
            txtId = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescricao = new TextBox();
            menuStrip1 = new MenuStrip();
            mnuArquivo = new ToolStripMenuItem();
            mnuNovo = new ToolStripMenuItem();
            mnuSalvar = new ToolStripMenuItem();
            mnuExcluir = new ToolStripMenuItem();
            mnuSair = new ToolStripMenuItem();
            advancedDataGridView1 = new Zuby.ADGV.AdvancedDataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(12, 73);
            txtId.Name = "txtId";
            txtId.Size = new Size(229, 38);
            txtId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(90, 31);
            label1.TabIndex = 1;
            label1.Text = "Código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(116, 31);
            label2.TabIndex = 3;
            label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescricao.Location = new Point(12, 152);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(517, 38);
            txtDescricao.TabIndex = 2;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuArquivo });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(541, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            mnuArquivo.DropDownItems.AddRange(new ToolStripItem[] { mnuNovo, mnuSalvar, mnuExcluir, mnuSair });
            mnuArquivo.Name = "mnuArquivo";
            mnuArquivo.Size = new Size(75, 24);
            mnuArquivo.Text = "&Arquivo";
            // 
            // mnuNovo
            // 
            mnuNovo.Name = "mnuNovo";
            mnuNovo.Size = new Size(135, 26);
            mnuNovo.Text = "&Novo";
            // 
            // mnuSalvar
            // 
            mnuSalvar.Name = "mnuSalvar";
            mnuSalvar.Size = new Size(135, 26);
            mnuSalvar.Text = "&Salvar";
            // 
            // mnuExcluir
            // 
            mnuExcluir.Name = "mnuExcluir";
            mnuExcluir.Size = new Size(135, 26);
            mnuExcluir.Text = "&Excluir";
            // 
            // mnuSair
            // 
            mnuSair.Name = "mnuSair";
            mnuSair.Size = new Size(135, 26);
            mnuSair.Text = "Sair";
            // 
            // advancedDataGridView1
            // 
            advancedDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            advancedDataGridView1.FilterAndSortEnabled = true;
            advancedDataGridView1.FilterStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.Location = new Point(12, 196);
            advancedDataGridView1.MaxFilterButtonImageHeight = 23;
            advancedDataGridView1.Name = "advancedDataGridView1";
            advancedDataGridView1.RightToLeft = RightToLeft.No;
            advancedDataGridView1.RowHeadersWidth = 51;
            advancedDataGridView1.Size = new Size(517, 201);
            advancedDataGridView1.SortStringChangedInvokeBeforeDatasourceUpdate = true;
            advancedDataGridView1.TabIndex = 5;
            // 
            // FrmFormaPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 409);
            Controls.Add(advancedDataGridView1);
            Controls.Add(label2);
            Controls.Add(txtDescricao);
            Controls.Add(label1);
            Controls.Add(txtId);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmFormaPagamento";
            Text = "FrmFormaPagamento";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)advancedDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtId;
        private Label label1;
        private Label label2;
        private TextBox txtDescricao;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuArquivo;
        private ToolStripMenuItem mnuNovo;
        private ToolStripMenuItem mnuSalvar;
        private ToolStripMenuItem mnuExcluir;
        private ToolStripMenuItem mnuSair;
        private Zuby.ADGV.AdvancedDataGridView advancedDataGridView1;
    }
}