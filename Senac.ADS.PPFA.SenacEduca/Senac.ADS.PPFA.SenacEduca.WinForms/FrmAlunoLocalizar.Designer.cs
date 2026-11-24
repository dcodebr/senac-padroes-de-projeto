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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dtgAlunos = new ReaLTaiizor.Controls.PoisonDataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colCPF = new DataGridViewTextBoxColumn();
            colTelefone = new DataGridViewTextBoxColumn();
            colTurma = new DataGridViewTextBoxColumn();
            colPeriodo = new DataGridViewTextBoxColumn();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            btnFiltrar = new ReaLTaiizor.Controls.MaterialButton();
            cboTurma = new ReaLTaiizor.Controls.MaterialComboBox();
            txtCPF = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            dtgAlunos.Columns.AddRange(new DataGridViewColumn[] { colId, colNome, colCPF, colTelefone, colTurma, colPeriodo });
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
            dtgAlunos.Location = new Point(6, 230);
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
            colTurma.DataPropertyName = "TurmaDescricao";
            colTurma.HeaderText = "Turma";
            colTurma.MinimumWidth = 6;
            colTurma.Name = "colTurma";
            colTurma.ReadOnly = true;
            colTurma.Width = 125;
            // 
            // colPeriodo
            // 
            colPeriodo.DataPropertyName = "TurmaPeriodo";
            colPeriodo.HeaderText = "Período";
            colPeriodo.MinimumWidth = 6;
            colPeriodo.Name = "colPeriodo";
            colPeriodo.ReadOnly = true;
            colPeriodo.Width = 125;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnFiltrar);
            materialCard1.Controls.Add(cboTurma);
            materialCard1.Controls.Add(txtCPF);
            materialCard1.Controls.Add(txtNome);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(6, 82);
            materialCard1.Margin = new Padding(17);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(17);
            materialCard1.Size = new Size(770, 143);
            materialCard1.TabIndex = 0;
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
            // cboTurma
            // 
            cboTurma.AutoResize = false;
            cboTurma.BackColor = Color.FromArgb(255, 255, 255);
            cboTurma.Depth = 0;
            cboTurma.DisplayMember = "Descricao";
            cboTurma.DrawMode = DrawMode.OwnerDrawVariable;
            cboTurma.DropDownHeight = 218;
            cboTurma.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurma.DropDownWidth = 121;
            cboTurma.Font = new Font("Microsoft Sans Serif", 17.5F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTurma.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTurma.FormattingEnabled = true;
            cboTurma.Hint = "Turma";
            cboTurma.IntegralHeight = false;
            cboTurma.ItemHeight = 54;
            cboTurma.Location = new Point(11, 77);
            cboTurma.MaxDropDownItems = 4;
            cboTurma.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTurma.Name = "cboTurma";
            cboTurma.Size = new Size(270, 60);
            cboTurma.StartIndex = 0;
            cboTurma.TabIndex = 5;
            cboTurma.ValueMember = "Id";
            // 
            // txtCPF
            // 
            txtCPF.AllowPromptAsInput = true;
            txtCPF.AnimateReadOnly = false;
            txtCPF.AsciiOnly = false;
            txtCPF.BackgroundImageLayout = ImageLayout.None;
            txtCPF.BeepOnError = false;
            txtCPF.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCPF.Depth = 0;
            txtCPF.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCPF.HidePromptOnLeave = false;
            txtCPF.HideSelection = true;
            txtCPF.Hint = "CPF";
            txtCPF.InsertKeyMode = InsertKeyMode.Default;
            txtCPF.LeadingIcon = null;
            txtCPF.Location = new Point(568, 11);
            txtCPF.Mask = "000,000,000-00";
            txtCPF.MaxLength = 32767;
            txtCPF.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCPF.Name = "txtCPF";
            txtCPF.PasswordChar = '\0';
            txtCPF.PrefixSuffixText = null;
            txtCPF.PromptChar = '_';
            txtCPF.ReadOnly = false;
            txtCPF.RejectInputOnFirstFailure = false;
            txtCPF.ResetOnPrompt = true;
            txtCPF.ResetOnSpace = true;
            txtCPF.RightToLeft = RightToLeft.No;
            txtCPF.SelectedText = "";
            txtCPF.SelectionLength = 0;
            txtCPF.SelectionStart = 0;
            txtCPF.ShortcutsEnabled = true;
            txtCPF.Size = new Size(191, 60);
            txtCPF.SkipLiterals = true;
            txtCPF.TabIndex = 4;
            txtCPF.TabStop = false;
            txtCPF.Text = "   .   .   -";
            txtCPF.TextAlign = HorizontalAlignment.Left;
            txtCPF.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCPF.TrailingIcon = null;
            txtCPF.UseSystemPasswordChar = false;
            txtCPF.ValidatingType = null;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.ImeMode = ImeMode.Off;
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(11, 11);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(551, 60);
            txtNome.TabIndex = 2;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
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
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.PoisonDataGridView dtgAlunos;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colCPF;
        private DataGridViewTextBoxColumn colTelefone;
        private DataGridViewTextBoxColumn colTurma;
        private DataGridViewTextBoxColumn colPeriodo;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialComboBox cboTurma;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCPF;
        private ReaLTaiizor.Controls.MaterialButton btnFiltrar;
    }
}