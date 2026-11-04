namespace Senac.ADS.PPFA.SenacEduca.WinForms
{
    partial class FrmAluno
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
            groupBox1 = new GroupBox();
            txtTelefone = new MaskedTextBox();
            label5 = new Label();
            btnTurmaLista = new Button();
            cboTurma = new ComboBox();
            label4 = new Label();
            txtCPF = new MaskedTextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            txtCodigo = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnLocalizar = new Button();
            btnExcluir = new Button();
            btnSalvar = new Button();
            btnNovo = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnTurmaLista);
            groupBox1.Controls.Add(cboTurma);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCPF);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados aluno";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(6, 240);
            txtTelefone.Mask = "(00) 00000-0000";
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(160, 27);
            txtTelefone.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 217);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 9;
            label5.Text = "Telefone";
            // 
            // btnTurmaLista
            // 
            btnTurmaLista.Location = new Point(378, 180);
            btnTurmaLista.Name = "btnTurmaLista";
            btnTurmaLista.Size = new Size(39, 29);
            btnTurmaLista.TabIndex = 8;
            btnTurmaLista.Text = "...";
            btnTurmaLista.UseVisualStyleBackColor = true;
            // 
            // cboTurma
            // 
            cboTurma.DisplayMember = "Descricao";
            cboTurma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurma.FormattingEnabled = true;
            cboTurma.Location = new Point(172, 180);
            cboTurma.Name = "cboTurma";
            cboTurma.Size = new Size(203, 28);
            cboTurma.TabIndex = 7;
            cboTurma.ValueMember = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 158);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 6;
            label4.Text = "Turma";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(6, 180);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(160, 27);
            txtCPF.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 157);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 4;
            label3.Text = "CPF";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(6, 116);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(408, 27);
            txtNome.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Nome";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(6, 56);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(146, 27);
            txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Código";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLocalizar);
            groupBox2.Controls.Add(btnExcluir);
            groupBox2.Controls.Add(btnSalvar);
            groupBox2.Controls.Add(btnNovo);
            groupBox2.Location = new Point(12, 284);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 67);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ações";
            // 
            // btnLocalizar
            // 
            btnLocalizar.Location = new Point(320, 26);
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.Size = new Size(94, 29);
            btnLocalizar.TabIndex = 3;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(206, 26);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(94, 29);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(106, 26);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(6, 26);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(94, 29);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // FrmAluno
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 363);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmAluno";
            Text = "Cadastro de Aluno";
            Load += FrmAluno_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnTurmaLista;
        private ComboBox cboTurma;
        private Label label4;
        private MaskedTextBox txtCPF;
        private Label label3;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtCodigo;
        private Label label1;
        private Button btnLocalizar;
        private Button btnExcluir;
        private Button btnSalvar;
        private Button btnNovo;
        private Label label5;
        private MaskedTextBox txtTelefone;
    }
}
