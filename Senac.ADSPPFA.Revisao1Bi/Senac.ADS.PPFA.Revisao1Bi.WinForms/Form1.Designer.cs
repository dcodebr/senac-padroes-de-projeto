namespace Senac.ADS.PPFA.Revisao1Bi.WinForms
{
    partial class Form1
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
            label1 = new Label();
            txtNome = new TextBox();
            btnProcessar = new Button();
            lblResultado = new Label();
            dtgPessoas = new DataGridView();
            cboGenero = new ComboBox();
            dtpNascimento = new DateTimePicker();
            label2 = new Label();
            txtCPF = new MaskedTextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgPessoas).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 32);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(416, 27);
            txtNome.TabIndex = 1;
            txtNome.Text = "Alex Diego Araujo da Rocha";
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // btnProcessar
            // 
            btnProcessar.Location = new Point(334, 258);
            btnProcessar.Name = "btnProcessar";
            btnProcessar.Size = new Size(94, 29);
            btnProcessar.TabIndex = 2;
            btnProcessar.Text = "Processar";
            btnProcessar.UseVisualStyleBackColor = true;
            btnProcessar.Click += btnProcessar_Click;
            btnProcessar.MouseHover += btnProcessar_MouseHover;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 77);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(57, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Gênero";
            // 
            // dtgPessoas
            // 
            dtgPessoas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgPessoas.Location = new Point(12, 293);
            dtgPessoas.Name = "dtgPessoas";
            dtgPessoas.RowHeadersWidth = 51;
            dtgPessoas.Size = new Size(416, 85);
            dtgPessoas.TabIndex = 4;
            // 
            // cboGenero
            // 
            cboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGenero.FormattingEnabled = true;
            cboGenero.Items.AddRange(new object[] { "Masculino", "Feminino", "Outros" });
            cboGenero.Location = new Point(12, 100);
            cboGenero.Name = "cboGenero";
            cboGenero.Size = new Size(284, 28);
            cboGenero.TabIndex = 5;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Format = DateTimePickerFormat.Short;
            dtpNascimento.Location = new Point(12, 176);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(250, 27);
            dtpNascimento.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 153);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 7;
            label2.Text = "Nascimento";
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(12, 245);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(250, 27);
            txtCPF.TabIndex = 8;
            txtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 222);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 9;
            label3.Text = "CPF";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 390);
            Controls.Add(label3);
            Controls.Add(txtCPF);
            Controls.Add(label2);
            Controls.Add(dtpNascimento);
            Controls.Add(cboGenero);
            Controls.Add(dtgPessoas);
            Controls.Add(lblResultado);
            Controls.Add(btnProcessar);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgPessoas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNome;
        private Button btnProcessar;
        private Label lblResultado;
        private DataGridView dtgPessoas;
        private ComboBox cboGenero;
        private DateTimePicker dtpNascimento;
        private Label label2;
        private MaskedTextBox txtCPF;
        private Label label3;
    }
}
