namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    partial class FrmBuilder
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
            btnProcessar = new Button();
            txtAnoModelo = new MaskedTextBox();
            label4 = new Label();
            txtAnoFabricacao = new MaskedTextBox();
            label3 = new Label();
            cboFabricante = new ComboBox();
            label2 = new Label();
            txtModelo = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnFluentBuilder = new Button();
            btnBuilder = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnProcessar);
            groupBox1.Controls.Add(txtAnoModelo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAnoFabricacao);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboFabricante);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtModelo);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(307, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(379, 254);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Carro";
            // 
            // btnProcessar
            // 
            btnProcessar.Location = new Point(291, 228);
            btnProcessar.Margin = new Padding(3, 2, 3, 2);
            btnProcessar.Name = "btnProcessar";
            btnProcessar.Size = new Size(82, 22);
            btnProcessar.TabIndex = 8;
            btnProcessar.Text = "Processar";
            btnProcessar.UseVisualStyleBackColor = true;
            btnProcessar.Click += btnProcessar_Click;
            // 
            // txtAnoModelo
            // 
            txtAnoModelo.Location = new Point(5, 190);
            txtAnoModelo.Margin = new Padding(3, 2, 3, 2);
            txtAnoModelo.Mask = "/####";
            txtAnoModelo.Name = "txtAnoModelo";
            txtAnoModelo.Size = new Size(110, 23);
            txtAnoModelo.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 172);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 6;
            label4.Text = "Ano Modelo";
            // 
            // txtAnoFabricacao
            // 
            txtAnoFabricacao.Location = new Point(5, 134);
            txtAnoFabricacao.Margin = new Padding(3, 2, 3, 2);
            txtAnoFabricacao.Mask = "/####";
            txtAnoFabricacao.Name = "txtAnoFabricacao";
            txtAnoFabricacao.Size = new Size(110, 23);
            txtAnoFabricacao.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 115);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 4;
            label3.Text = "Ano Fabricação";
            // 
            // cboFabricante
            // 
            cboFabricante.FormattingEnabled = true;
            cboFabricante.Items.AddRange(new object[] { "Chevrolet", "Renaut", "Fiat", "Toyota", "Peugeot" });
            cboFabricante.Location = new Point(5, 82);
            cboFabricante.Margin = new Padding(3, 2, 3, 2);
            cboFabricante.Name = "cboFabricante";
            cboFabricante.Size = new Size(228, 23);
            cboFabricante.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 63);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Fabricante";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(5, 34);
            txtModelo.Margin = new Padding(3, 2, 3, 2);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(228, 23);
            txtModelo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 16);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 0;
            label1.Text = "Modelo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnFluentBuilder);
            groupBox2.Controls.Add(btnBuilder);
            groupBox2.Location = new Point(12, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(289, 254);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Pattern";
            // 
            // btnFluentBuilder
            // 
            btnFluentBuilder.Location = new Point(6, 51);
            btnFluentBuilder.Name = "btnFluentBuilder";
            btnFluentBuilder.Size = new Size(277, 23);
            btnFluentBuilder.TabIndex = 1;
            btnFluentBuilder.Text = "Fluent Builder Pattern";
            btnFluentBuilder.UseVisualStyleBackColor = true;
            btnFluentBuilder.Click += btnFluentBuilder_Click;
            // 
            // btnBuilder
            // 
            btnBuilder.Location = new Point(6, 22);
            btnBuilder.Name = "btnBuilder";
            btnBuilder.Size = new Size(277, 23);
            btnBuilder.TabIndex = 0;
            btnBuilder.Text = "Builder Pattern";
            btnBuilder.UseVisualStyleBackColor = true;
            btnBuilder.Click += btnBuilder_Click;
            // 
            // FrmPatternBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 274);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FrmPatternBuilder";
            Text = "FrmBuilder";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnProcessar;
        private MaskedTextBox txtAnoModelo;
        private Label label4;
        private MaskedTextBox txtAnoFabricacao;
        private Label label3;
        private ComboBox cboFabricante;
        private Label label2;
        private TextBox txtModelo;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnFluentBuilder;
        private Button btnBuilder;
    }
}