namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    partial class FrmDecorator
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
            btnIncluir = new Button();
            btnMaisLeite = new Button();
            label2 = new Label();
            label3 = new Label();
            btnMaisAvela = new Button();
            label4 = new Label();
            btnMaisAcucar = new Button();
            txtPedido = new TextBox();
            btnAnnotation = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 25);
            label1.Name = "label1";
            label1.Size = new Size(62, 32);
            label1.TabIndex = 0;
            label1.Text = "Café";
            // 
            // btnIncluir
            // 
            btnIncluir.Location = new Point(78, 25);
            btnIncluir.Margin = new Padding(3, 4, 3, 4);
            btnIncluir.Name = "btnIncluir";
            btnIncluir.Size = new Size(86, 31);
            btnIncluir.TabIndex = 1;
            btnIncluir.Text = "Incluir";
            btnIncluir.UseVisualStyleBackColor = true;
            btnIncluir.Click += btnIncluir_Click;
            // 
            // btnMaisLeite
            // 
            btnMaisLeite.Location = new Point(130, 89);
            btnMaisLeite.Margin = new Padding(3, 4, 3, 4);
            btnMaisLeite.Name = "btnMaisLeite";
            btnMaisLeite.Size = new Size(86, 31);
            btnMaisLeite.TabIndex = 3;
            btnMaisLeite.Text = "Incluir";
            btnMaisLeite.UseVisualStyleBackColor = true;
            btnMaisLeite.Click += btnMaisLeite_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 84);
            label2.Name = "label2";
            label2.Size = new Size(88, 32);
            label2.TabIndex = 2;
            label2.Text = "+ Leite";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 156);
            label3.Name = "label3";
            label3.Size = new Size(95, 32);
            label3.TabIndex = 4;
            label3.Text = "+ Avelã";
            // 
            // btnMaisAvela
            // 
            btnMaisAvela.Location = new Point(130, 161);
            btnMaisAvela.Margin = new Padding(3, 4, 3, 4);
            btnMaisAvela.Name = "btnMaisAvela";
            btnMaisAvela.Size = new Size(86, 31);
            btnMaisAvela.TabIndex = 5;
            btnMaisAvela.Text = "Incluir";
            btnMaisAvela.UseVisualStyleBackColor = true;
            btnMaisAvela.Click += btnMaisAvela_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(14, 232);
            label4.Name = "label4";
            label4.Size = new Size(108, 32);
            label4.TabIndex = 6;
            label4.Text = "+ Açucar";
            // 
            // btnMaisAcucar
            // 
            btnMaisAcucar.Location = new Point(130, 232);
            btnMaisAcucar.Margin = new Padding(3, 4, 3, 4);
            btnMaisAcucar.Name = "btnMaisAcucar";
            btnMaisAcucar.Size = new Size(86, 31);
            btnMaisAcucar.TabIndex = 7;
            btnMaisAcucar.Text = "Incluir";
            btnMaisAcucar.UseVisualStyleBackColor = true;
            btnMaisAcucar.Click += btnMaisAcucar_Click;
            // 
            // txtPedido
            // 
            txtPedido.Location = new Point(14, 289);
            txtPedido.Margin = new Padding(3, 4, 3, 4);
            txtPedido.Name = "txtPedido";
            txtPedido.Size = new Size(374, 27);
            txtPedido.TabIndex = 8;
            // 
            // btnAnnotation
            // 
            btnAnnotation.Location = new Point(371, 30);
            btnAnnotation.Margin = new Padding(3, 4, 3, 4);
            btnAnnotation.Name = "btnAnnotation";
            btnAnnotation.Size = new Size(112, 31);
            btnAnnotation.TabIndex = 9;
            btnAnnotation.Text = "Annotation";
            btnAnnotation.UseVisualStyleBackColor = true;
            btnAnnotation.Click += btnAnnotation_Click;
            // 
            // FrmDecorator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 548);
            Controls.Add(btnAnnotation);
            Controls.Add(txtPedido);
            Controls.Add(btnMaisAcucar);
            Controls.Add(label4);
            Controls.Add(btnMaisAvela);
            Controls.Add(label3);
            Controls.Add(btnMaisLeite);
            Controls.Add(label2);
            Controls.Add(btnIncluir);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmDecorator";
            Text = "FrmDecorator";
            Load += FrmDecorator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnIncluir;
        private Button btnMaisLeite;
        private Label label2;
        private Label label3;
        private Button btnMaisAvela;
        private Label label4;
        private Button btnMaisAcucar;
        private TextBox txtPedido;
        private Button btnAnnotation;
    }
}