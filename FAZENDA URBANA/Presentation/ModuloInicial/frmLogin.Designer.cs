namespace Presentation.ModuloInicial
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            gbLogin = new GroupBox();
            label1 = new Label();
            btnSair = new Button();
            btnLogin = new Button();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lblSenha = new Label();
            lblUsuario = new Label();
            label2 = new Label();
            label3 = new Label();
            gbLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gbLogin
            // 
            gbLogin.BackColor = Color.Transparent;
            gbLogin.BackgroundImage = (Image)resources.GetObject("gbLogin.BackgroundImage");
            gbLogin.BackgroundImageLayout = ImageLayout.None;
            gbLogin.Controls.Add(label1);
            gbLogin.Controls.Add(btnSair);
            gbLogin.Controls.Add(btnLogin);
            gbLogin.Controls.Add(txtSenha);
            gbLogin.Controls.Add(txtUsuario);
            gbLogin.Controls.Add(lblSenha);
            gbLogin.Controls.Add(lblUsuario);
            gbLogin.FlatStyle = FlatStyle.Flat;
            gbLogin.Location = new Point(168, 172);
            gbLogin.Margin = new Padding(3, 4, 3, 4);
            gbLogin.Name = "gbLogin";
            gbLogin.Padding = new Padding(3, 4, 3, 4);
            gbLogin.Size = new Size(865, 328);
            gbLogin.TabIndex = 0;
            gbLogin.TabStop = false;
            gbLogin.Enter += gbLogin_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(321, 40);
            label1.Name = "label1";
            label1.Size = new Size(254, 20);
            label1.TabIndex = 6;
            label1.Text = "Insira o seu usuário e senha:";
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.MediumSeaGreen;
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(489, 203);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(86, 44);
            btnSair.TabIndex = 5;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.MediumSeaGreen;
            btnLogin.BackgroundImageLayout = ImageLayout.None;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.Black;
            btnLogin.Location = new Point(339, 203);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 44);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(397, 132);
            txtSenha.Margin = new Padding(3, 4, 3, 4);
            txtSenha.MaxLength = 8;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(178, 27);
            txtSenha.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(397, 88);
            txtUsuario.Margin = new Padding(3, 4, 3, 4);
            txtUsuario.MaxLength = 20;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(178, 27);
            txtUsuario.TabIndex = 2;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.BackColor = Color.Black;
            lblSenha.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSenha.ForeColor = SystemColors.ButtonFace;
            lblSenha.Location = new Point(288, 139);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(67, 20);
            lblSenha.TabIndex = 1;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Black;
            lblUsuario.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.ButtonFace;
            lblUsuario.Location = new Point(288, 95);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(80, 20);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            // 
            // label2
            // 
            label2.BackColor = Color.Green;
            label2.Font = new Font("Microsoft Sans Serif", 20.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(391, 33);
            label2.Name = "label2";
            label2.Size = new Size(456, 135);
            label2.TabIndex = 6;
            label2.Text = "Bem vindo (a) ao sistema!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(23, 643);
            label3.Name = "label3";
            label3.Size = new Size(470, 20);
            label3.TabIndex = 7;
            label3.Text = "AGRO PURO 2024. Todos os direitos reservados. V2.0";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources._1887350_verde_escuro_vermelho_gradiente_desfoque_padrao_vetor1;
            ClientSize = new Size(1199, 672);
            ControlBox = false;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(gbLogin);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmLogin";
            Load += frmLogin_Load;
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbLogin;
        private Button btnSair;
        private Button btnLogin;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label lblSenha;
        private Label lblUsuario;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}