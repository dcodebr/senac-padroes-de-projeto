namespace Senac.ADS.PPFA.Revisao.WinForms
{
    partial class frmPessoas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNome = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtCpf = new TextBox();
            label3 = new Label();
            txtRg = new TextBox();
            dtpDataNascimento = new DateTimePicker();
            label4 = new Label();
            btnSalvar = new Button();
            dgvPessoas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 39);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(404, 23);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 21);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 21);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 3;
            label2.Text = "CPF:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(422, 39);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(177, 23);
            txtCpf.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 71);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 5;
            label3.Text = "RG:";
            // 
            // txtRg
            // 
            txtRg.Location = new Point(12, 89);
            txtRg.Name = "txtRg";
            txtRg.Size = new Size(177, 23);
            txtRg.TabIndex = 4;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Location = new Point(195, 89);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(200, 23);
            dtpDataNascimento.TabIndex = 6;
            dtpDataNascimento.Value = new DateTime(2001, 9, 11, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(195, 71);
            label4.Name = "label4";
            label4.Size = new Size(117, 15);
            label4.TabIndex = 7;
            label4.Text = "Data de Nascimento:";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(401, 88);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // dgvPessoas
            // 
            dgvPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPessoas.Location = new Point(12, 118);
            dgvPessoas.Name = "dgvPessoas";
            dgvPessoas.Size = new Size(587, 329);
            dgvPessoas.TabIndex = 9;
            dgvPessoas.CellDoubleClick += dgvPessoas_CellDoubleClick;
            // 
            // frmPessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 450);
            Controls.Add(dgvPessoas);
            Controls.Add(btnSalvar);
            Controls.Add(label4);
            Controls.Add(dtpDataNascimento);
            Controls.Add(label3);
            Controls.Add(txtRg);
            Controls.Add(label2);
            Controls.Add(txtCpf);
            Controls.Add(label1);
            Controls.Add(txtNome);
            Name = "frmPessoas";
            Text = "Cadastro de Pessoas";
            Load += frmPessoas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private Label label1;
        private Label label2;
        private TextBox txtCpf;
        private Label label3;
        private TextBox txtRg;
        private DateTimePicker dtpDataNascimento;
        private Label label4;
        private Button btnSalvar;
        private DataGridView dgvPessoas;
    }
}
