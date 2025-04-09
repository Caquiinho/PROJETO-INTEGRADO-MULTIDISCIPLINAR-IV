namespace Presentation.ModuloUsuario
{
    partial class frmIncluirUsuario
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
            lblCep = new Label();
            mskCep = new MaskedTextBox();
            lblEndereco = new Label();
            txtEndereco = new TextBox();
            txtNumero = new TextBox();
            lblComplemento = new Label();
            btnIncluirUsuario = new Button();
            lblPerfil = new Label();
            cbxPerfil = new ComboBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtUF = new TextBox();
            lblUf = new Label();
            txtBairro = new TextBox();
            lblBairro = new Label();
            txtComplemento = new TextBox();
            lblNumero = new Label();
            txtNome = new TextBox();
            lblNome = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCep.Location = new Point(88, 148);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(48, 20);
            lblCep.TabIndex = 0;
            lblCep.Text = "Cep:";
            // 
            // mskCep
            // 
            mskCep.BackColor = Color.LawnGreen;
            mskCep.BorderStyle = BorderStyle.FixedSingle;
            mskCep.Location = new Point(224, 141);
            mskCep.Margin = new Padding(3, 4, 3, 4);
            mskCep.Mask = "00000-000";
            mskCep.Name = "mskCep";
            mskCep.Size = new Size(74, 27);
            mskCep.TabIndex = 2;
            mskCep.MaskInputRejected += mskCep_MaskInputRejected;
            mskCep.Leave += mskCep_Leave;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(89, 180);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(94, 20);
            lblEndereco.TabIndex = 2;
            lblEndereco.Text = "Endereço:";
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.LawnGreen;
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Location = new Point(224, 173);
            txtEndereco.Margin = new Padding(3, 4, 3, 4);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(548, 27);
            txtEndereco.TabIndex = 3;
            txtEndereco.TextChanged += txtEndereco_TextChanged;
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.LawnGreen;
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Location = new Point(224, 208);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(548, 27);
            txtNumero.TabIndex = 4;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplemento.Location = new Point(88, 257);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(129, 20);
            lblComplemento.TabIndex = 4;
            lblComplemento.Text = "Complemento:";
            // 
            // btnIncluirUsuario
            // 
            btnIncluirUsuario.BackColor = Color.Lime;
            btnIncluirUsuario.BackgroundImageLayout = ImageLayout.None;
            btnIncluirUsuario.Cursor = Cursors.Hand;
            btnIncluirUsuario.FlatStyle = FlatStyle.Popup;
            btnIncluirUsuario.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncluirUsuario.Location = new Point(407, 531);
            btnIncluirUsuario.Margin = new Padding(3, 4, 3, 4);
            btnIncluirUsuario.Name = "btnIncluirUsuario";
            btnIncluirUsuario.Size = new Size(162, 52);
            btnIncluirUsuario.TabIndex = 16;
            btnIncluirUsuario.Text = "Cadastrar";
            btnIncluirUsuario.UseVisualStyleBackColor = false;
            btnIncluirUsuario.Click += btnIncluirUsuario_Click;
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPerfil.Location = new Point(89, 478);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(54, 20);
            lblPerfil.TabIndex = 19;
            lblPerfil.Text = "Perfil";
            // 
            // cbxPerfil
            // 
            cbxPerfil.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPerfil.FlatStyle = FlatStyle.System;
            cbxPerfil.FormattingEnabled = true;
            cbxPerfil.Location = new Point(224, 470);
            cbxPerfil.Margin = new Padding(3, 4, 3, 4);
            cbxPerfil.Name = "cbxPerfil";
            cbxPerfil.Size = new Size(548, 28);
            cbxPerfil.TabIndex = 18;
            cbxPerfil.SelectedIndexChanged += cbxPerfil_SelectedIndexChanged;
            // 
            // txtSenha
            // 
            txtSenha.BackColor = Color.LawnGreen;
            txtSenha.BorderStyle = BorderStyle.FixedSingle;
            txtSenha.Location = new Point(224, 428);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.MaxLength = 8;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(548, 27);
            txtSenha.TabIndex = 9;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(89, 435);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(67, 20);
            lblSenha.TabIndex = 15;
            lblSenha.Text = "Senha:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LawnGreen;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(224, 389);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(548, 27);
            txtEmail.TabIndex = 8;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(89, 396);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(62, 20);
            lblEmail.TabIndex = 13;
            lblEmail.Text = "Email:";
            // 
            // txtUF
            // 
            txtUF.BackColor = Color.LawnGreen;
            txtUF.BorderStyle = BorderStyle.FixedSingle;
            txtUF.Location = new Point(224, 345);
            txtUF.Margin = new Padding(3, 4, 3, 4);
            txtUF.MaxLength = 2;
            txtUF.Name = "txtUF";
            txtUF.Size = new Size(548, 27);
            txtUF.TabIndex = 7;
            txtUF.TextChanged += txtUF_TextChanged;
            // 
            // lblUf
            // 
            lblUf.AutoSize = true;
            lblUf.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUf.Location = new Point(89, 352);
            lblUf.Name = "lblUf";
            lblUf.Size = new Size(39, 20);
            lblUf.TabIndex = 11;
            lblUf.Text = "UF:";
            // 
            // txtBairro
            // 
            txtBairro.BackColor = Color.LawnGreen;
            txtBairro.BorderStyle = BorderStyle.FixedSingle;
            txtBairro.Location = new Point(224, 296);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.MaxLength = 50;
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(548, 27);
            txtBairro.TabIndex = 6;
            txtBairro.TextChanged += txtBairro_TextChanged;
            // 
            // lblBairro
            // 
            lblBairro.AutoSize = true;
            lblBairro.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBairro.Location = new Point(89, 303);
            lblBairro.Name = "lblBairro";
            lblBairro.Size = new Size(67, 20);
            lblBairro.TabIndex = 9;
            lblBairro.Text = "Bairro:";
            // 
            // txtComplemento
            // 
            txtComplemento.BackColor = Color.LawnGreen;
            txtComplemento.BorderStyle = BorderStyle.FixedSingle;
            txtComplemento.Location = new Point(224, 250);
            txtComplemento.Margin = new Padding(3, 4, 3, 4);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(548, 27);
            txtComplemento.TabIndex = 5;
            txtComplemento.TextChanged += txtComplemento_TextChanged;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(89, 215);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(80, 20);
            lblNumero.TabIndex = 7;
            lblNumero.Text = "Número:";
            // 
            // txtNome
            // 
            txtNome.BackColor = Color.LawnGreen;
            txtNome.BorderStyle = BorderStyle.FixedSingle;
            txtNome.Location = new Point(224, 106);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.MaxLength = 50;
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(548, 27);
            txtNome.TabIndex = 1;
            txtNome.TextChanged += txtNome_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(88, 109);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 20);
            lblNome.TabIndex = 6;
            lblNome.Text = "Nome:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 70);
            panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.fechar;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(878, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 58);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(320, 20);
            label1.Name = "label1";
            label1.Size = new Size(304, 31);
            label1.TabIndex = 8;
            label1.Text = "CADASTRO DE USUARIOS";
            // 
            // frmIncluirUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(936, 636);
            Controls.Add(lblPerfil);
            Controls.Add(btnIncluirUsuario);
            Controls.Add(cbxPerfil);
            Controls.Add(panel1);
            Controls.Add(txtSenha);
            Controls.Add(lblSenha);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(lblNome);
            Controls.Add(lblEmail);
            Controls.Add(mskCep);
            Controls.Add(lblCep);
            Controls.Add(txtUF);
            Controls.Add(lblUf);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(txtBairro);
            Controls.Add(lblBairro);
            Controls.Add(txtNumero);
            Controls.Add(lblComplemento);
            Controls.Add(txtComplemento);
            Controls.Add(lblNumero);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmIncluirUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmIncluirUsuario";
            Load += frmIncluirUsuario_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCep;
        private MaskedTextBox mskCep;
        private Label lblEndereco;
        private TextBox txtEndereco;
        private TextBox txtNumero;
        private Label lblComplemento;
        private TextBox txtNome;
        private Label lblNome;
        private TextBox txtBairro;
        private Label lblBairro;
        private TextBox txtComplemento;
        private Label lblNumero;
        private Button btnIncluirUsuario;
        private TextBox txtSenha;
        private Label lblSenha;
        private TextBox txtEmail;
        private Label lblEmail;
        private TextBox txtUF;
        private Label lblUf;
        private Label lblPerfil;
        private ComboBox cbxPerfil;
        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
    }
}