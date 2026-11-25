namespace Senac.ADS.PPFA.SenacEduca.WinForms
{
    partial class FrmTurma
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
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCodigo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialCard1 = new ReaLTaiizor.Controls.MaterialCard();
            btnLocalizar = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            txtPeriodo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            materialCard1.SuspendLayout();
            SuspendLayout();
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
            txtDescricao.Location = new Point(15, 159);
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
            txtDescricao.Size = new Size(576, 60);
            txtDescricao.TabIndex = 3;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            txtCodigo.AnimateReadOnly = false;
            txtCodigo.AutoCompleteMode = AutoCompleteMode.None;
            txtCodigo.AutoCompleteSource = AutoCompleteSource.None;
            txtCodigo.BackgroundImageLayout = ImageLayout.None;
            txtCodigo.CharacterCasing = CharacterCasing.Normal;
            txtCodigo.Depth = 0;
            txtCodigo.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCodigo.HideSelection = true;
            txtCodigo.Hint = "Código";
            txtCodigo.LeadingIcon = null;
            txtCodigo.Location = new Point(15, 93);
            txtCodigo.MaxLength = 32767;
            txtCodigo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCodigo.Name = "txtCodigo";
            txtCodigo.PasswordChar = '\0';
            txtCodigo.PrefixSuffixText = null;
            txtCodigo.ReadOnly = true;
            txtCodigo.RightToLeft = RightToLeft.No;
            txtCodigo.SelectedText = "";
            txtCodigo.SelectionLength = 0;
            txtCodigo.SelectionStart = 0;
            txtCodigo.ShortcutsEnabled = true;
            txtCodigo.Size = new Size(231, 60);
            txtCodigo.TabIndex = 2;
            txtCodigo.TabStop = false;
            txtCodigo.Text = "0";
            txtCodigo.TextAlign = HorizontalAlignment.Left;
            txtCodigo.TrailingIcon = null;
            txtCodigo.UseSystemPasswordChar = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(btnLocalizar);
            materialCard1.Controls.Add(btnExcluir);
            materialCard1.Controls.Add(btnSalvar);
            materialCard1.Controls.Add(btnNovo);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(15, 339);
            materialCard1.Margin = new Padding(17);
            materialCard1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(17);
            materialCard1.Size = new Size(575, 64);
            materialCard1.TabIndex = 7;
            // 
            // btnLocalizar
            // 
            btnLocalizar.AutoSize = false;
            btnLocalizar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLocalizar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLocalizar.Depth = 0;
            btnLocalizar.HighEmphasis = true;
            btnLocalizar.Icon = null;
            btnLocalizar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnLocalizar.Location = new Point(450, 8);
            btnLocalizar.Margin = new Padding(0);
            btnLocalizar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnLocalizar.Name = "btnLocalizar";
            btnLocalizar.NoAccentTextColor = Color.Empty;
            btnLocalizar.Size = new Size(117, 50);
            btnLocalizar.TabIndex = 12;
            btnLocalizar.Text = "Localizar";
            btnLocalizar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLocalizar.UseAccentColor = false;
            btnLocalizar.UseVisualStyleBackColor = true;
            btnLocalizar.Click += btnLocalizar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSize = false;
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(267, 8);
            btnExcluir.Margin = new Padding(0);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(117, 50);
            btnExcluir.TabIndex = 11;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = false;
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(136, 8);
            btnSalvar.Margin = new Padding(0);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(117, 50);
            btnSalvar.TabIndex = 10;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnNovo
            // 
            btnNovo.AutoSize = false;
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(8, 8);
            btnNovo.Margin = new Padding(0);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(117, 50);
            btnNovo.TabIndex = 7;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
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
            txtPeriodo.Location = new Point(16, 225);
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
            txtPeriodo.Size = new Size(230, 60);
            txtPeriodo.TabIndex = 8;
            txtPeriodo.TabStop = false;
            txtPeriodo.TextAlign = HorizontalAlignment.Left;
            txtPeriodo.TrailingIcon = null;
            txtPeriodo.UseSystemPasswordChar = false;
            // 
            // FrmTurma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 408);
            Controls.Add(txtPeriodo);
            Controls.Add(materialCard1);
            Controls.Add(txtDescricao);
            Controls.Add(txtCodigo);
            Name = "FrmTurma";
            Text = "FrmTurma";
            materialCard1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtCodigo;
        private ReaLTaiizor.Controls.MaterialCard materialCard1;
        private ReaLTaiizor.Controls.MaterialButton btnLocalizar;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPeriodo;
    }
}