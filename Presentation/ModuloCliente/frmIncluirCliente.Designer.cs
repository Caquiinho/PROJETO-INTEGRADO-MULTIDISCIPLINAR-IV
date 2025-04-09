namespace Presentation.ModuloCliente
{
    partial class frmIncluirCliente
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
            btnIncluirFornecedor = new Button();
            txtContato = new TextBox();
            label10 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            mskkCep = new MaskedTextBox();
            txtEndereco = new TextBox();
            lblEndereco = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            lblCep = new Label();
            mskCnpj = new TextBox();
            txtNomeEmpresa = new TextBox();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtAgrotoxico = new TextBox();
            txtAdubo = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnIncluirFornecedor
            // 
            btnIncluirFornecedor.BackColor = Color.Lime;
            btnIncluirFornecedor.BackgroundImageLayout = ImageLayout.None;
            btnIncluirFornecedor.Cursor = Cursors.Hand;
            btnIncluirFornecedor.FlatStyle = FlatStyle.Flat;
            btnIncluirFornecedor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncluirFornecedor.Location = new Point(395, 395);
            btnIncluirFornecedor.Margin = new Padding(3, 4, 3, 4);
            btnIncluirFornecedor.Name = "btnIncluirFornecedor";
            btnIncluirFornecedor.Size = new Size(170, 66);
            btnIncluirFornecedor.TabIndex = 59;
            btnIncluirFornecedor.Text = "Cadastrar Fornecedor";
            btnIncluirFornecedor.UseVisualStyleBackColor = false;
            btnIncluirFornecedor.Click += btnIncluirCliente_Click_1;
            // 
            // txtContato
            // 
            txtContato.BackColor = Color.LawnGreen;
            txtContato.BorderStyle = BorderStyle.FixedSingle;
            txtContato.Location = new Point(651, 172);
            txtContato.Margin = new Padding(3, 4, 3, 4);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(273, 27);
            txtContato.TabIndex = 52;
            txtContato.TextChanged += txtContato_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(539, 179);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 61;
            label10.Text = "Contato:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LawnGreen;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(651, 120);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 27);
            txtEmail.TabIndex = 51;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(539, 131);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 59;
            label4.Text = "Email:";
            // 
            // mskkCep
            // 
            mskkCep.BackColor = Color.LawnGreen;
            mskkCep.BorderStyle = BorderStyle.FixedSingle;
            mskkCep.Location = new Point(186, 219);
            mskkCep.Margin = new Padding(3, 4, 3, 4);
            mskkCep.Mask = "00000-000";
            mskkCep.Name = "mskkCep";
            mskkCep.Size = new Size(74, 27);
            mskkCep.TabIndex = 47;
            mskkCep.MaskInputRejected += mskkCep_MaskInputRejected;
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.LawnGreen;
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Location = new Point(186, 254);
            txtEndereco.Margin = new Padding(3, 4, 3, 4);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(273, 27);
            txtEndereco.TabIndex = 48;
            txtEndereco.TextChanged += txtEndereco_TextChanged;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(21, 261);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(94, 20);
            lblEndereco.TabIndex = 52;
            lblEndereco.Text = "Endereço:";
            // 
            // txtComplemento
            // 
            txtComplemento.BackColor = Color.LawnGreen;
            txtComplemento.BorderStyle = BorderStyle.FixedSingle;
            txtComplemento.Location = new Point(186, 331);
            txtComplemento.Margin = new Padding(3, 4, 3, 4);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(273, 27);
            txtComplemento.TabIndex = 50;
            txtComplemento.TextChanged += txtComplemento_TextChanged;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplemento.Location = new Point(21, 331);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(129, 20);
            lblComplemento.TabIndex = 55;
            lblComplemento.Text = "Complemento:";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.LawnGreen;
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Location = new Point(186, 289);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(273, 27);
            txtNumero.TabIndex = 49;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(21, 292);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(80, 20);
            lblNumero.TabIndex = 57;
            lblNumero.Text = "Número:";
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCep.Location = new Point(21, 226);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(48, 20);
            lblCep.TabIndex = 50;
            lblCep.Text = "Cep:";
            // 
            // mskCnpj
            // 
            mskCnpj.BackColor = Color.LawnGreen;
            mskCnpj.BorderStyle = BorderStyle.FixedSingle;
            mskCnpj.Location = new Point(186, 168);
            mskCnpj.Name = "mskCnpj";
            mskCnpj.Size = new Size(125, 27);
            mskCnpj.TabIndex = 46;
            mskCnpj.TextChanged += mskCnpj_TextChanged;
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.BackColor = Color.LawnGreen;
            txtNomeEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtNomeEmpresa.Location = new Point(186, 120);
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.Size = new Size(125, 27);
            txtNomeEmpresa.TabIndex = 45;
            txtNomeEmpresa.TextChanged += txtNomeEmpresa_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label3.Location = new Point(22, 175);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 40;
            label3.Text = "CNPJ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label2.Location = new Point(22, 127);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 39;
            label2.Text = "Nome Empresa";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.fechar;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(881, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 59);
            pictureBox1.TabIndex = 69;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(936, 70);
            panel1.TabIndex = 70;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 19);
            label1.Name = "label1";
            label1.Size = new Size(368, 31);
            label1.TabIndex = 8;
            label1.Text = "CADASTRO DE FORNECEDORES";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label5.Location = new Point(539, 291);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 41;
            label5.Text = "Adubo:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label6.Location = new Point(539, 240);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 42;
            label6.Text = "Agrotoxico:";
            // 
            // txtAgrotoxico
            // 
            txtAgrotoxico.BackColor = Color.LawnGreen;
            txtAgrotoxico.BorderStyle = BorderStyle.FixedSingle;
            txtAgrotoxico.Location = new Point(651, 233);
            txtAgrotoxico.Name = "txtAgrotoxico";
            txtAgrotoxico.Size = new Size(125, 27);
            txtAgrotoxico.TabIndex = 53;
            txtAgrotoxico.TextChanged += txtAgrotoxico_TextChanged;
            // 
            // txtAdubo
            // 
            txtAdubo.BackColor = Color.LawnGreen;
            txtAdubo.BorderStyle = BorderStyle.FixedSingle;
            txtAdubo.Location = new Point(651, 284);
            txtAdubo.Name = "txtAdubo";
            txtAdubo.Size = new Size(125, 27);
            txtAdubo.TabIndex = 55;
            txtAdubo.TextChanged += txtAdubo_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Black;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(12, 607);
            label7.Name = "label7";
            label7.Size = new Size(470, 20);
            label7.TabIndex = 70;
            label7.Text = "AGRO PURO 2024. Todos os direitos reservados. V2.0";
            // 
            // frmIncluirCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(936, 636);
            ControlBox = false;
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(btnIncluirFornecedor);
            Controls.Add(txtContato);
            Controls.Add(label10);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(mskkCep);
            Controls.Add(txtEndereco);
            Controls.Add(lblEndereco);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(lblCep);
            Controls.Add(txtAgrotoxico);
            Controls.Add(txtAdubo);
            Controls.Add(mskCnpj);
            Controls.Add(txtNomeEmpresa);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmIncluirCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CADASTRAR FORNECEDOR";
            Load += frmIncluirCliente_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIncluirFornecedor;
        private TextBox txtContato;
        private Label label10;
        private TextBox txtEmail;
        private Label label4;
        private MaskedTextBox mskkCep;
        private TextBox txtEndereco;
        private Label lblEndereco;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private TextBox txtNumero;
        private Label lblNumero;
        private Label lblCep;
        private TextBox mskCnpj;
        private TextBox txtNomeEmpresa;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label6;
        private TextBox txtAgrotoxico;
        private TextBox txtAdubo;
        private Label label7;
    }
}
