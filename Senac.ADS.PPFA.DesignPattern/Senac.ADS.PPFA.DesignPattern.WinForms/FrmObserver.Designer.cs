namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    partial class FrmObserver
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
            btnCelsiusAdd = new Button();
            btnCelsiusRemove = new Button();
            btnFahrenheitRemove = new Button();
            btnFahrenheitAdd = new Button();
            btnKelvinRemove = new Button();
            btnKelvinAdd = new Button();
            btnAtualizar = new Button();
            label1 = new Label();
            lblCelsius = new Label();
            lblFahrenheit = new Label();
            label3 = new Label();
            lblKelvin = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnCelsiusAdd
            // 
            btnCelsiusAdd.Location = new Point(195, 12);
            btnCelsiusAdd.Name = "btnCelsiusAdd";
            btnCelsiusAdd.Size = new Size(158, 29);
            btnCelsiusAdd.TabIndex = 0;
            btnCelsiusAdd.Text = "Adicionar Celsius";
            btnCelsiusAdd.UseVisualStyleBackColor = true;
            // 
            // btnCelsiusRemove
            // 
            btnCelsiusRemove.Location = new Point(359, 12);
            btnCelsiusRemove.Name = "btnCelsiusRemove";
            btnCelsiusRemove.Size = new Size(151, 29);
            btnCelsiusRemove.TabIndex = 1;
            btnCelsiusRemove.Text = "Remover Celsius";
            btnCelsiusRemove.UseVisualStyleBackColor = true;
            // 
            // btnFahrenheitRemove
            // 
            btnFahrenheitRemove.Location = new Point(359, 47);
            btnFahrenheitRemove.Name = "btnFahrenheitRemove";
            btnFahrenheitRemove.Size = new Size(151, 29);
            btnFahrenheitRemove.TabIndex = 3;
            btnFahrenheitRemove.Text = "Remover Fahrenheit";
            btnFahrenheitRemove.UseVisualStyleBackColor = true;
            // 
            // btnFahrenheitAdd
            // 
            btnFahrenheitAdd.Location = new Point(195, 47);
            btnFahrenheitAdd.Name = "btnFahrenheitAdd";
            btnFahrenheitAdd.Size = new Size(158, 29);
            btnFahrenheitAdd.TabIndex = 2;
            btnFahrenheitAdd.Text = "Adicionar Fahrenheit";
            btnFahrenheitAdd.UseVisualStyleBackColor = true;
            // 
            // btnKelvinRemove
            // 
            btnKelvinRemove.Location = new Point(359, 82);
            btnKelvinRemove.Name = "btnKelvinRemove";
            btnKelvinRemove.Size = new Size(151, 29);
            btnKelvinRemove.TabIndex = 5;
            btnKelvinRemove.Text = "Remover Kelvin";
            btnKelvinRemove.UseVisualStyleBackColor = true;
            // 
            // btnKelvinAdd
            // 
            btnKelvinAdd.Location = new Point(195, 82);
            btnKelvinAdd.Name = "btnKelvinAdd";
            btnKelvinAdd.Size = new Size(158, 29);
            btnKelvinAdd.TabIndex = 4;
            btnKelvinAdd.Text = "Adicionar Kelvin";
            btnKelvinAdd.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(310, 117);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(103, 29);
            btnAtualizar.TabIndex = 6;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 7;
            label1.Text = "Celsius";
            // 
            // lblCelsius
            // 
            lblCelsius.AutoSize = true;
            lblCelsius.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCelsius.Location = new Point(12, 36);
            lblCelsius.Name = "lblCelsius";
            lblCelsius.Size = new Size(104, 62);
            lblCelsius.TabIndex = 8;
            lblCelsius.Text = "0ºC";
            // 
            // lblFahrenheit
            // 
            lblFahrenheit.AutoSize = true;
            lblFahrenheit.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFahrenheit.Location = new Point(12, 128);
            lblFahrenheit.Name = "lblFahrenheit";
            lblFahrenheit.Size = new Size(99, 62);
            lblFahrenheit.TabIndex = 10;
            lblFahrenheit.Text = "0ºF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 108);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 9;
            label3.Text = "Fahrenheit";
            // 
            // lblKelvin
            // 
            lblKelvin.AutoSize = true;
            lblKelvin.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblKelvin.Location = new Point(12, 226);
            lblKelvin.Name = "lblKelvin";
            lblKelvin.Size = new Size(98, 62);
            lblKelvin.TabIndex = 12;
            lblKelvin.Text = "0 K";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 206);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 11;
            label5.Text = "Kelvin";
            // 
            // FrmObserver
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 311);
            Controls.Add(lblKelvin);
            Controls.Add(label5);
            Controls.Add(lblFahrenheit);
            Controls.Add(label3);
            Controls.Add(lblCelsius);
            Controls.Add(label1);
            Controls.Add(btnAtualizar);
            Controls.Add(btnKelvinRemove);
            Controls.Add(btnKelvinAdd);
            Controls.Add(btnFahrenheitRemove);
            Controls.Add(btnFahrenheitAdd);
            Controls.Add(btnCelsiusRemove);
            Controls.Add(btnCelsiusAdd);
            Name = "FrmObserver";
            Text = "FrmObserver";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCelsiusAdd;
        private Button btnCelsiusRemove;
        private Button btnFahrenheitRemove;
        private Button btnFahrenheitAdd;
        private Button btnKelvinRemove;
        private Button btnKelvinAdd;
        private Button btnAtualizar;
        private Label label1;
        private Label lblCelsius;
        private Label lblFahrenheit;
        private Label label3;
        private Label lblKelvin;
        private Label label5;
    }
}