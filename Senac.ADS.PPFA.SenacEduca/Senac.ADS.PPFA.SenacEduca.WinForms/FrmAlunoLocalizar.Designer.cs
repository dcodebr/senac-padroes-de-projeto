namespace Senac.ADS.PPFA.SenacEduca.WinForms
{
    partial class FrmAlunoLocalizar
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            dtgAlunos = new ReaLTaiizor.Controls.PoisonDataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colCPF = new DataGridViewTextBoxColumn();
            colTelefone = new DataGridViewTextBoxColumn();
            colTurma = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgAlunos).BeginInit();
            SuspendLayout();
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(6, 82);
            materialCard1.Margin = new Padding(17);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(17);
            materialCard1.Size = new Size(770, 90);
            materialCard1.TabIndex = 0;
            // 
            // dtgAlunos
            // 
            dtgAlunos.AllowUserToAddRows = false;
            dtgAlunos.AllowUserToDeleteRows = false;
            dtgAlunos.AllowUserToResizeRows = false;
            dtgAlunos.BackgroundColor = Color.FromArgb(255, 255, 255);
            dtgAlunos.BorderStyle = BorderStyle.None;
            dtgAlunos.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dtgAlunos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dtgAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dtgAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlunos.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colCPF, colTelefone, colTurma });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dtgAlunos.DefaultCellStyle = dataGridViewCellStyle5;
            dtgAlunos.EnableHeadersVisualStyles = false;
            dtgAlunos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtgAlunos.GridColor = Color.FromArgb(255, 255, 255);
            dtgAlunos.Location = new Point(6, 176);
            dtgAlunos.Name = "dtgAlunos";
            dtgAlunos.ReadOnly = true;
            dtgAlunos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dtgAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dtgAlunos.RowHeadersWidth = 51;
            dtgAlunos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAlunos.Size = new Size(770, 298);
            dtgAlunos.TabIndex = 1;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Código";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 125;
            // 
            // colNome
            // 
            colNome.DataPropertyName = "Nome";
            colNome.HeaderText = "Nome";
            colNome.MinimumWidth = 6;
            colNome.Name = "colNome";
            colNome.ReadOnly = true;
            colNome.Width = 125;
            // 
            // colCPF
            // 
            colCPF.DataPropertyName = "CPF";
            colCPF.HeaderText = "CPF";
            colCPF.MinimumWidth = 6;
            colCPF.Name = "colCPF";
            colCPF.ReadOnly = true;
            colCPF.Width = 125;
            // 
            // colTelefone
            // 
            colTelefone.DataPropertyName = "Telefone";
            colTelefone.HeaderText = "Telefone";
            colTelefone.MinimumWidth = 6;
            colTelefone.Name = "colTelefone";
            colTelefone.ReadOnly = true;
            colTelefone.Width = 125;
            // 
            // colTurma
            // 
            colTurma.DataPropertyName = "Turma.Descricao";
            colTurma.HeaderText = "Turma";
            colTurma.MinimumWidth = 6;
            colTurma.Name = "colTurma";
            colTurma.ReadOnly = true;
            colTurma.Width = 125;
            // 
            // FrmAlunoLocalizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 480);
            Controls.Add(dtgAlunos);
            Controls.Add(materialCard1);
            Name = "FrmAlunoLocalizar";
            Text = "FrmAlunoLocalizar";
            Load += FrmAlunoLocalizar_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAlunos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.PoisonDataGridView dtgAlunos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCPF;
        private DataGridViewTextBoxColumn colTelefone;
        private DataGridViewTextBoxColumn colTurma;
    }
}