namespace Senac.ADS.PPFA.DesignPattern.WinForms
{
    partial class FrmPatterns
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
            btnSingleton = new Button();
            btnFactory = new Button();
            btnBuilder = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            grbEstrutural.SuspendLayout();
            SuspendLayout();
            // 
            // grbEstrutural
            // 
            grbEstrutural.Controls.Add(btnSingleton);
            grbEstrutural.Controls.Add(btnFactory);
            grbEstrutural.Controls.Add(btnBuilder);
            grbEstrutural.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            grbEstrutural.Location = new Point(12, 7);
            grbEstrutural.Name = "grbEstrutural";
            grbEstrutural.Size = new Size(300, 330);
            grbEstrutural.TabIndex = 0;
            grbEstrutural.TabStop = false;
            grbEstrutural.Text = "Padrões Estruturais";
            // 
            // btnSingleton
            // 
            btnSingleton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnSingleton.Location = new Point(6, 130);
            btnSingleton.Name = "btnSingleton";
            btnSingleton.Size = new Size(288, 40);
            btnSingleton.TabIndex = 2;
            btnSingleton.Text = "Singleton Pattern";
            btnSingleton.UseVisualStyleBackColor = true;
            btnSingleton.Click += btnSingleton_Click;
            // 
            // btnFactory
            // 
            btnFactory.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnFactory.Location = new Point(6, 84);
            btnFactory.Name = "btnFactory";
            btnFactory.Size = new Size(288, 40);
            btnFactory.TabIndex = 1;
            btnFactory.Text = "Factory Pattern";
            btnFactory.UseVisualStyleBackColor = true;
            btnFactory.Click += btnFactory_Click;
            // 
            // btnBuilder
            // 
            btnBuilder.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnBuilder.Location = new Point(6, 38);
            btnBuilder.Name = "btnBuilder";
            btnBuilder.Size = new Size(288, 40);
            btnBuilder.TabIndex = 0;
            btnBuilder.Text = "Builder Pattern";
            btnBuilder.UseVisualStyleBackColor = true;
            btnBuilder.Click += btnBuilder_Click;
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            groupBox1.Location = new Point(318, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(300, 330);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Padrões Comportamentais";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            groupBox2.Location = new Point(624, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 330);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Padrões Criacionais";
            // 
            // FrmPatterns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 342);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grbEstrutural);
            Name = "FrmPatterns";
            Text = "Form1";
            grbEstrutural.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbEstrutural;
        private Button btnBuilder;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnFactory;
        private Button btnSingleton;
    }
}
