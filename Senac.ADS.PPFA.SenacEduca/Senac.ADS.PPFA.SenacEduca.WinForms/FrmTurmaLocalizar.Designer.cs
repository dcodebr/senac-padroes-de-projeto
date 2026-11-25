namespace Senac.ADS.PPFA.SenacEduca.WinForms
{
    partial class FrmTurmaLocalizar
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtgAlunos = new ReaLTaiizor.Controls.PoisonDataGridView();
            colId = new DataGridViewTextBoxColumn();
            colDescricao = new DataGridViewTextBoxColumn();
            colPeriodo = new DataGridViewTextBoxColumn();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            txtPeriodo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnFiltrar = new ReaLTaiizor.Controls.MaterialButton();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ((System.ComponentModel.ISupportInitialize)dtgAlunos).BeginInit();
            materialCard1.SuspendLayout();
            SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle1.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgAlunos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgAlunos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlunos.Columns.AddRange(new DataGridViewColumn[] { colId, colDescricao, colPeriodo });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgAlunos.DefaultCellStyle = dataGridViewCellStyle2;
            dtgAlunos.EnableHeadersVisualStyles = false;
            dtgAlunos.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtgAlunos.GridColor = Color.FromArgb(255, 255, 255);
            dtgAlunos.Location = new Point(6, 234);
            dtgAlunos.Name = "dtgAlunos";
            dtgAlunos.ReadOnly = true;
            dtgAlunos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtgAlunos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtgAlunos.RowHeadersVisible = false;
            dtgAlunos.RowHeadersWidth = 51;
            dtgAlunos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgAlunos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgAlunos.Size = new Size(770, 244);
            dtgAlunos.TabIndex = 3;
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
            // colDescricao
            // 
            colDescricao.DataPropertyName = "Descricao";
            colDescricao.HeaderText = "Descrição";
            colDescricao.MinimumWidth = 6;
            colDescricao.Name = "colDescricao";
            colDescricao.ReadOnly = true;
            colDescricao.Width = 500;
            // 
            // colPeriodo
            // 
            colPeriodo.DataPropertyName = "Periodo";
            colPeriodo.HeaderText = "Período";
            colPeriodo.MinimumWidth = 6;
            colPeriodo.Name = "colPeriodo";
            colPeriodo.ReadOnly = true;
            colPeriodo.Width = 125;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(txtPeriodo);
            materialCard1.Controls.Add(btnFiltrar);
            materialCard1.Controls.Add(txtDescricao);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(6, 86);
            materialCard1.Margin = new Padding(17);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(17);
            materialCard1.Size = new Size(770, 143);
            materialCard1.TabIndex = 2;
            // 
            // txtPeriodo
            // 
            txtPeriodo.AnimateReadOnly = false;
            txtPeriodo.AutoCompleteMode = AutoCompleteMode.None;
            txtPeriodo.AutoCompleteSource = AutoCompleteSource.None;
            txtPeriodo.BackgroundImageLayout = ImageLayout.None;
            txtPeriodo.CharacterCasing = CharacterCasing.Normal;
            txtPeriodo.Depth = 0;
            txtPeriodo.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPeriodo.HideSelection = true;
            txtPeriodo.Hint = "Período";
            txtPeriodo.ImeMode = ImeMode.Off;
            txtPeriodo.LeadingIcon = null;
            txtPeriodo.Location = new Point(11, 77);
            txtPeriodo.MaxLength = 32767;
            txtPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPeriodo.Name = "txtPeriodo";
            txtPeriodo.PasswordChar = '\0';
            txtPeriodo.PrefixSuffixText = null;
            txtPeriodo.ReadOnly = false;
            txtPeriodo.RightToLeft = RightToLeft.No;
            txtPeriodo.SelectedText = "";
            txtPeriodo.SelectionLength = 0;
            txtPeriodo.SelectionStart = 0;
            txtPeriodo.ShortcutsEnabled = true;
            txtPeriodo.Size = new Size(360, 60);
            txtPeriodo.TabIndex = 14;
            txtPeriodo.TabStop = false;
            txtPeriodo.TextAlign = HorizontalAlignment.Left;
            txtPeriodo.TrailingIcon = null;
            txtPeriodo.UseSystemPasswordChar = false;
            // 
            // btnFiltrar
            // 
            btnFiltrar.AutoSize = false;
            btnFiltrar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnFiltrar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnFiltrar.Depth = 0;
            btnFiltrar.HighEmphasis = true;
            btnFiltrar.Icon = null;
            btnFiltrar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnFiltrar.Location = new Point(642, 80);
            btnFiltrar.Margin = new Padding(0);
            btnFiltrar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.NoAccentTextColor = Color.Empty;
            btnFiltrar.Size = new Size(117, 50);
            btnFiltrar.TabIndex = 13;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnFiltrar.UseAccentColor = false;
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.AutoCompleteMode = AutoCompleteMode.None;
            txtDescricao.AutoCompleteSource = AutoCompleteSource.None;
            txtDescricao.BackgroundImageLayout = ImageLayout.None;
            txtDescricao.CharacterCasing = CharacterCasing.Normal;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.HideSelection = true;
            txtDescricao.Hint = "Descrição";
            txtDescricao.ImeMode = ImeMode.Off;
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(11, 11);
            txtDescricao.MaxLength = 32767;
            txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.PrefixSuffixText = null;
            txtDescricao.ReadOnly = false;
            txtDescricao.RightToLeft = RightToLeft.No;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.ShortcutsEnabled = true;
            txtDescricao.Size = new Size(748, 60);
            txtDescricao.TabIndex = 2;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // FrmTurmaLocalizar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 496);
            Controls.Add(dtgAlunos);
            Controls.Add(materialCard1);
            Name = "FrmTurmaLocalizar";
            Text = "FrmTurmaLocalizar";
            Load += FrmTurmaLocalizar_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAlunos).EndInit();
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView dtgAlunos;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPeriodo;
        private ReaLTaiizor.Controls.MaterialButton btnFiltrar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colDescricao;
        private DataGridViewTextBoxColumn colPeriodo;
    }
}