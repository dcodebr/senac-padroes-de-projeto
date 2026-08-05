namespace Senac.ADS.PPFA.DesignPattern.WinForms
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
            grbEstrutural = new GroupBox();
            btnFluentBuilder = new Button();
            btnBuilder = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtModelo = new TextBox();
            label2 = new Label();
            cboFabricante = new ComboBox();
            label3 = new Label();
            txtAnoFabricacao = new MaskedTextBox();
            txtAnoModelo = new MaskedTextBox();
            label4 = new Label();
            btnSalvar = new Button();
            grbEstrutural.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbEstrutural
            // 
            grbEstrutural.Controls.Add(btnFluentBuilder);
            grbEstrutural.Controls.Add(btnBuilder);
            grbEstrutural.Location = new Point(14, 16);
            grbEstrutural.Margin = new Padding(3, 4, 3, 4);
            grbEstrutural.Name = "grbEstrutural";
            grbEstrutural.Padding = new Padding(3, 4, 3, 4);
            grbEstrutural.Size = new Size(271, 440);
            grbEstrutural.TabIndex = 0;
            grbEstrutural.TabStop = false;
            grbEstrutural.Text = "Padrões Estruturais";
            // 
            // btnFluentBuilder
            // 
            btnFluentBuilder.Location = new Point(19, 68);
            btnFluentBuilder.Margin = new Padding(3, 4, 3, 4);
            btnFluentBuilder.Name = "btnFluentBuilder";
            btnFluentBuilder.Size = new Size(245, 31);
            btnFluentBuilder.TabIndex = 1;
            btnFluentBuilder.Text = "Fluent Builder Pattern";
            btnFluentBuilder.UseVisualStyleBackColor = true;
            btnFluentBuilder.Click += btnFluentBuilder_Click;
            // 
            // btnBuilder
            // 
            btnBuilder.Location = new Point(19, 29);
            btnBuilder.Margin = new Padding(3, 4, 3, 4);
            btnBuilder.Name = "btnBuilder";
            btnBuilder.Size = new Size(245, 31);
            btnBuilder.TabIndex = 0;
            btnBuilder.Text = "Builder Pattern";
            btnBuilder.UseVisualStyleBackColor = true;
            btnBuilder.Click += btnBuilder_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtAnoModelo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAnoFabricacao);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboFabricante);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(291, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(433, 339);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Carro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 23);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 0;
            label1.Text = "Modelo";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(6, 46);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(260, 27);
            txtModelo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 86);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 2;
            label2.Text = "Fabricante";
            // 
            // cboFabricante
            // 
            cboFabricante.FormattingEnabled = true;
            cboFabricante.Items.AddRange(new object[] { "Chevrolet", "Renaut", "Fiat", "Toyota", "Peugeot" });
            cboFabricante.Location = new Point(6, 109);
            cboFabricante.Name = "cboFabricante";
            cboFabricante.Size = new Size(260, 28);
            cboFabricante.TabIndex = 3;
            cboFabricante.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 155);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 4;
            label3.Text = "Ano Fabricação";
            // 
            // txtAnoFabricacao
            // 
            txtAnoFabricacao.Location = new Point(6, 178);
            txtAnoFabricacao.Mask = "/####";
            txtAnoFabricacao.Name = "txtAnoFabricacao";
            txtAnoFabricacao.Size = new Size(125, 27);
            txtAnoFabricacao.TabIndex = 5;
            // 
            // txtAnoModelo
            // 
            txtAnoModelo.Location = new Point(6, 254);
            txtAnoModelo.Mask = "/####";
            txtAnoModelo.Name = "txtAnoModelo";
            txtAnoModelo.Size = new Size(125, 27);
            txtAnoModelo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 231);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 6;
            label4.Text = "Ano Modelo";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(333, 304);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox1);
            Controls.Add(grbEstrutural);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            grbEstrutural.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbEstrutural;
        private Button btnBuilder;
        private Button btnFluentBuilder;
        private GroupBox groupBox1;
        private TextBox txtModelo;
        private Label label1;
        private MaskedTextBox txtAnoModelo;
        private Label label4;
        private MaskedTextBox txtAnoFabricacao;
        private Label label3;
        private ComboBox cboFabricante;
        private Label label2;
        private Button btnSalvar;
    }
}
