namespace Presentation.ModuloUsuario
{
    partial class frmGerenciarUsuario
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
            btnExcluirUsuario = new Button();
            btnAlterarUsuario = new Button();
            txtNome = new TextBox();
            dgUsuario = new DataGridView();
            btnPesquisarUsuario = new Button();
            txtFiltro = new TextBox();
            lblFiltro = new Label();
            pictureBox1 = new PictureBox();
            lblPerfil = new Label();
            cbxPerfil = new ComboBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            lblEmail = new Label();
            mskCep = new MaskedTextBox();
            lblCep = new Label();
            txtUF = new TextBox();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            lblUf = new Label();
            ((System.ComponentModel.ISupportInitialize)dgUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExcluirUsuario
            // 
            btnExcluirUsuario.BackColor = Color.Red;
            btnExcluirUsuario.Cursor = Cursors.Hand;
            btnExcluirUsuario.FlatStyle = FlatStyle.Popup;
            btnExcluirUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic);
            btnExcluirUsuario.Location = new Point(993, 496);
            btnExcluirUsuario.Margin = new Padding(3, 4, 3, 4);
            btnExcluirUsuario.Name = "btnExcluirUsuario";
            btnExcluirUsuario.Size = new Size(169, 74);
            btnExcluirUsuario.TabIndex = 7;
            btnExcluirUsuario.Text = "Excluir Usuario";
            btnExcluirUsuario.UseVisualStyleBackColor = false;
            btnExcluirUsuario.Click += btnExcluirUsuario_Click;
            // 
            // btnAlterarUsuario
            // 
            btnAlterarUsuario.BackColor = Color.Yellow;
            btnAlterarUsuario.Cursor = Cursors.Hand;
            btnAlterarUsuario.FlatStyle = FlatStyle.Popup;
            btnAlterarUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAlterarUsuario.Location = new Point(482, 496);
            btnAlterarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnAlterarUsuario.Name = "btnAlterarUsuario";
            btnAlterarUsuario.Size = new Size(166, 74);
            btnAlterarUsuario.TabIndex = 6;
            btnAlterarUsuario.Text = "Alterar Usuario";
            btnAlterarUsuario.UseVisualStyleBackColor = false;
            btnAlterarUsuario.Click += btnAlterarUsuario_Click;
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.LawnGreen;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(158, 96);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(251, 27);
            txtNome.TabIndex = 3;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // dgUsuario
            // 
            dgUsuario.BackgroundColor = Color.ForestGreen;
            dgUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgUsuario.Location = new Point(430, 96);
            dgUsuario.Margin = new Padding(3, 4, 3, 4);
            dgUsuario.Name = "dgUsuario";
            dgUsuario.RowHeadersWidth = 51;
            dgUsuario.Size = new Size(757, 392);
            dgUsuario.TabIndex = 3;
            dgUsuario.CellContentClick += dgUsuario_CellContentClick_1;
            dgUsuario.RowHeaderMouseClick += dgUsuario_RowHeaderMouseClick;
            dgUsuario.SelectionChanged += dgUsuario_SelectionChanged;
            // 
            // btnPesquisarUsuario
            // 
            btnPesquisarUsuario.BackColor = Color.Lime;
            btnPesquisarUsuario.BackgroundImageLayout = ImageLayout.None;
            btnPesquisarUsuario.Cursor = Cursors.Hand;
            btnPesquisarUsuario.FlatStyle = FlatStyle.Popup;
            btnPesquisarUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic);
            btnPesquisarUsuario.Location = new Point(654, 5);
            btnPesquisarUsuario.Margin = new Padding(3, 4, 3, 4);
            btnPesquisarUsuario.Name = "btnPesquisarUsuario";
            btnPesquisarUsuario.Size = new Size(327, 75);
            btnPesquisarUsuario.TabIndex = 2;
            btnPesquisarUsuario.Text = "Pesquisar Usuario";
            btnPesquisarUsuario.UseVisualStyleBackColor = false;
            btnPesquisarUsuario.Click += btnPesquisarUsuario_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = Color.LawnGreen;
            txtFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtFiltro.Location = new Point(99, 28);
            txtFiltro.Margin = new Padding(3, 4, 3, 4);
            txtFiltro.MaxLength = 50;
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(437, 27);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltro.Location = new Point(24, 31);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(59, 20);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "Filtro:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.fechar1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(1124, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 50);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerfil.Location = new Point(23, 468);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(54, 20);
            lblPerfil.TabIndex = 38;
            lblPerfil.Text = "Perfil";
            // 
            // cbxPerfil
            // 
            cbxPerfil.BackColor = Color.FromArgb(128, 255, 128);
            cbxPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerfil.FlatStyle = FlatStyle.System;
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Location = new Point(158, 460);
            cbxPerfil.Margin = new Padding(3, 4, 3, 4);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(251, 28);
            cbxPerfil.TabIndex = 37;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.LawnGreen;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Location = new Point(158, 418);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.MaxLength = 8;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(251, 27);
            txtSenha.TabIndex = 34;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(23, 425);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(67, 20);
            lblSenha.TabIndex = 36;
            lblSenha.Text = "Senha:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LawnGreen;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(158, 379);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 27);
            txtEmail.TabIndex = 32;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 99);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 29;
            label1.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(23, 386);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 20);
            lblEmail.TabIndex = 35;
            lblEmail.Text = "Email:";
            // 
            // mskCep
            // 
            mskCep.BackColor = Color.LawnGreen;
            mskCep.BorderStyle = BorderStyle.FixedSingle;
            mskCep.Location = new Point(158, 131);
            mskCep.Margin = new Padding(3, 4, 3, 4);
            mskCep.Mask = "00000-000";
            mskCep.Name = "mskCep";
            mskCep.Size = new Size(74, 27);
            mskCep.TabIndex = 23;
            mskCep.MaskInputRejected += mskCep_MaskInputRejected;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCep.Location = new Point(23, 138);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(48, 20);
            lblCep.TabIndex = 20;
            lblCep.Text = "Cep:";
            // 
            // txtUF
            // 
            txtUF.BackColor = Color.LawnGreen;
            txtUF.BorderStyle = BorderStyle.FixedSingle;
            txtUF.Location = new Point(158, 335);
            txtUF.Margin = new Padding(3, 4, 3, 4);
            txtUF.MaxLength = 2;
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(251, 27);
            txtUF.TabIndex = 31;
            txtUF.TextChanged += txtUF_TextChanged;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.LawnGreen;
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Location = new Point(158, 163);
            txtEndereco.Margin = new Padding(3, 4, 3, 4);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(251, 27);
            txtEndereco.TabIndex = 24;
            txtEndereco.TextChanged += txtEndereco_TextChanged;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(23, 170);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(94, 20);
            lblEndereco.TabIndex = 22;
            lblEndereco.Text = "Endereço:";
            // 
            // txtBairro
            // 
            txtBairro.BackColor = Color.LawnGreen;
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.Location = new Point(158, 286);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.MaxLength = 50;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(251, 27);
            txtBairro.TabIndex = 28;
            txtBairro.TextChanged += txtBairro_TextChanged;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBairro.Location = new Point(23, 293);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(67, 20);
            lblBairro.TabIndex = 33;
            lblBairro.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            txtComplemento.BackColor = Color.LawnGreen;
            txtComplemento.BorderStyle = BorderStyle.FixedSingle;
            txtComplemento.Location = new Point(158, 240);
            txtComplemento.Margin = new Padding(3, 4, 3, 4);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(251, 27);
            txtComplemento.TabIndex = 26;
            txtComplemento.TextChanged += txtComplemento_TextChanged;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplemento.Location = new Point(23, 243);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(129, 20);
            lblComplemento.TabIndex = 25;
            lblComplemento.Text = "Complemento:";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.LawnGreen;
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Location = new Point(158, 198);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(251, 27);
            txtNumero.TabIndex = 27;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(23, 205);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(80, 20);
            lblNumero.TabIndex = 30;
            lblNumero.Text = "Número:";
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUf.Location = new Point(22, 342);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(39, 20);
            lblUf.TabIndex = 39;
            lblUf.Text = "UF:";
            // 
            // frmGerenciarUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1190, 600);
            ControlBox = false;
            Controls.Add(lblUf);
            Controls.Add(lblPerfil);
            Controls.Add(cbxPerfil);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Controls.Add(lblEmail);
            Controls.Add(mskCep);
            Controls.Add(lblCep);
            Controls.Add(txtUF);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(pictureBox1);
            Controls.Add(lblFiltro);
            Controls.Add(txtFiltro);
            Controls.Add(btnPesquisarUsuario);
            Controls.Add(dgUsuario);
            Controls.Add(txtNome);
            Controls.Add(btnAlterarUsuario);
            Controls.Add(btnExcluirUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmGerenciarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alterar Usuarios";
            Load += frmGerenciarUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNome;
        private DataGridView dgUsuario;
        private Button btnPesquisarUsuario;
        private TextBox txtFiltro;
        private Label lblFiltro;
        private Button btnExcluirUsuario;
        private Button btnAlterarUsuario;
        private PictureBox pictureBox1;
        private Label lblPerfil;
        private ComboBox cbxPerfil;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtEmail;
        private Label label1;
        private Label lblEmail;
        private MaskedTextBox mskCep;
        private Label lblCep;
        private TextBox txtUF;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private TextBox txtNumero;
        private Label lblNumero;
        private Label lblUf;
    }
}