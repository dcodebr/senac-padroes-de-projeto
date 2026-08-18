namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    partial class FrmSingleton
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
            grbContador = new GroupBox();
            lblContador = new Label();
            btnIncrementar = new Button();
            grbContador.SuspendLayout();
            SuspendLayout();
            // 
            // grbContador
            // 
            grbContador.Controls.Add(lblContador);
            grbContador.Controls.Add(btnIncrementar);
            grbContador.Location = new Point(12, 12);
            grbContador.Name = "grbContador";
            grbContador.Size = new Size(290, 190);
            grbContador.TabIndex = 0;
            grbContador.TabStop = false;
            grbContador.Text = "Contador";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContador.Location = new Point(6, 53);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(214, 47);
            lblContador.TabIndex = 1;
            lblContador.Text = "Contador: 0";
            // 
            // btnIncrementar
            // 
            btnIncrementar.Location = new Point(6, 22);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(111, 28);
            btnIncrementar.TabIndex = 0;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // FrmSingleton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 206);
            Controls.Add(grbContador);
            Name = "FrmSingleton";
            Text = "FrmSingleton";
            Activated += FrmSingleton_Activated;
            grbContador.ResumeLayout(false);
            grbContador.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbContador;
        private Label lblContador;
        private Button btnIncrementar;
    }
}