namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    partial class FrmFactory
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
            label2 = new Label();
            btnProcessar = new Button();
            label1 = new Label();
            cboModal = new ComboBox();
            txtResultado = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnProcessar);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cboModal);
            groupBox1.Controls.Add(txtResultado);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(310, 355);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Modal do Transporte";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label2.Location = new Point(6, 151);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 4;
            label2.Text = "Resultado";
            // 
            // btnProcessar
            // 
            btnProcessar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnProcessar.Location = new Point(193, 95);
            btnProcessar.Name = "btnProcessar";
            btnProcessar.Size = new Size(109, 35);
            btnProcessar.TabIndex = 3;
            btnProcessar.Text = "Processar";
            btnProcessar.UseVisualStyleBackColor = true;
            btnProcessar.Click += btnProcessar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            label1.Location = new Point(0, 28);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 2;
            label1.Text = "Modal";
            // 
            // cboModal
            // 
            cboModal.DropDownStyle = ComboBoxStyle.DropDownList;
            cboModal.Font = new Font("Segoe UI", 14.25F);
            cboModal.FormattingEnabled = true;
            cboModal.Location = new Point(6, 56);
            cboModal.Name = "cboModal";
            cboModal.Size = new Size(296, 33);
            cboModal.TabIndex = 1;
            // 
            // txtResultado
            // 
            txtResultado.Font = new Font("Segoe UI", 14.25F);
            txtResultado.Location = new Point(6, 179);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(296, 170);
            txtResultado.TabIndex = 0;
            // 
            // FrmFactory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 379);
            Controls.Add(groupBox1);
            Name = "FrmFactory";
            Text = "FrmFactory";
            Load += FrmFactory_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnProcessar;
        private Label label1;
        private ComboBox cboModal;
        private TextBox txtResultado;
        private Label label2;
    }
}