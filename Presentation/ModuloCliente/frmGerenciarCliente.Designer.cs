namespace Presentation.ModuloCliente
{
    partial class frmGerenciarCliente
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
            btnExcluirCliente = new Button();
            btnAlterarCliente = new Button();
            txtNomeEmpresa = new TextBox();
            lblNome = new Label();
            dgCliente = new DataGridView();
            btnPesquisarCliente = new Button();
            txtFiltro = new TextBox();
            lblFiltro = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtEndereco = new TextBox();
            label3 = new Label();
            mskCep = new TextBox();
            label4 = new Label();
            txtContato = new TextBox();
            label5 = new Label();
            txtAdubo = new TextBox();
            label6 = new Label();
            txtComplemento = new TextBox();
            label7 = new Label();
            txtNumero = new TextBox();
            label8 = new Label();
            txtAgrotoxico = new TextBox();
            label10 = new Label();
            mskCnpj = new MaskedTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgCliente).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExcluirCliente
            // 
            btnExcluirCliente.BackColor = Color.Red;
            btnExcluirCliente.Cursor = Cursors.Hand;
            btnExcluirCliente.FlatStyle = FlatStyle.Popup;
            btnExcluirCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic);
            btnExcluirCliente.Location = new Point(766, 510);
            btnExcluirCliente.Margin = new Padding(3, 4, 3, 4);
            btnExcluirCliente.Name = "btnExcluirCliente";
            btnExcluirCliente.Size = new Size(162, 72);
            btnExcluirCliente.TabIndex = 7;
            btnExcluirCliente.Text = "Excluir Fornecedor";
            btnExcluirCliente.UseVisualStyleBackColor = false;
            btnExcluirCliente.Click += btnExcluirCliente_Click;
            // 
            // btnAlterarCliente
            // 
            btnAlterarCliente.BackColor = Color.Yellow;
            btnAlterarCliente.Cursor = Cursors.Hand;
            btnAlterarCliente.FlatStyle = FlatStyle.Popup;
            btnAlterarCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAlterarCliente.Location = new Point(540, 510);
            btnAlterarCliente.Margin = new Padding(3, 4, 3, 4);
            btnAlterarCliente.Name = "btnAlterarCliente";
            btnAlterarCliente.Size = new Size(149, 72);
            btnAlterarCliente.TabIndex = 6;
            btnAlterarCliente.Text = "Alterar Fornecedor";
            btnAlterarCliente.UseVisualStyleBackColor = false;
            btnAlterarCliente.Click += btnAlterarCliente_Click;
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.BackColor = Color.LawnGreen;
            txtNomeEmpresa.BorderStyle = BorderStyle.FixedSingle;
            txtNomeEmpresa.Location = new Point(165, 82);
            txtNomeEmpresa.Margin = new Padding(3, 4, 3, 4);
            txtNomeEmpresa.MaxLength = 50;
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.Size = new Size(318, 27);
            txtNomeEmpresa.TabIndex = 3;
            txtNomeEmpresa.TextChanged += txtNomeEmpresa_TextChanged;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblNome.Location = new Point(33, 89);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(63, 20);
            lblNome.TabIndex = 4;
            lblNome.Text = "Nome:";
            // 
            // dgCliente
            // 
            dgCliente.BackgroundColor = Color.ForestGreen;
            dgCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgCliente.Location = new Point(512, 80);
            dgCliente.Margin = new Padding(3, 4, 3, 4);
            dgCliente.Name = "dgCliente";
            dgCliente.RowHeadersWidth = 51;
            dgCliente.Size = new Size(666, 392);
            dgCliente.TabIndex = 3;
            dgCliente.CellContentClick += dgCliente_CellContentClick;
            dgCliente.RowHeaderMouseClick += dgCliente_RowHeaderMouseClick;
            dgCliente.SelectionChanged += dgCliente_SelectionChanged;
            // 
            // btnPesquisarCliente
            // 
            btnPesquisarCliente.BackColor = Color.Lime;
            btnPesquisarCliente.Cursor = Cursors.Hand;
            btnPesquisarCliente.FlatStyle = FlatStyle.Popup;
            btnPesquisarCliente.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnPesquisarCliente.Location = new Point(705, 11);
            btnPesquisarCliente.Margin = new Padding(3, 4, 3, 4);
            btnPesquisarCliente.Name = "btnPesquisarCliente";
            btnPesquisarCliente.Size = new Size(291, 63);
            btnPesquisarCliente.TabIndex = 2;
            btnPesquisarCliente.Text = "Pesquisar Fornecedor";
            btnPesquisarCliente.UseVisualStyleBackColor = false;
            btnPesquisarCliente.Click += btnPesquisarCliente_Click;
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = Color.LawnGreen;
            txtFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtFiltro.Location = new Point(119, 20);
            txtFiltro.Margin = new Padding(3, 4, 3, 4);
            txtFiltro.MaxLength = 50;
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(377, 27);
            txtFiltro.TabIndex = 1;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblFiltro.Location = new Point(31, 23);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(59, 20);
            lblFiltro.TabIndex = 0;
            lblFiltro.Text = "Filtro:";
            lblFiltro.Click += lblFiltro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label1.Location = new Point(31, 136);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 12;
            label1.Text = "CNPJ:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LawnGreen;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(165, 179);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 27);
            txtEmail.TabIndex = 5;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label2.Location = new Point(36, 179);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 14;
            label2.Text = "Email:";
            // 
            // txtEndereco
            // 
            txtEndereco.BackColor = Color.LawnGreen;
            txtEndereco.BorderStyle = BorderStyle.FixedSingle;
            txtEndereco.Location = new Point(165, 320);
            txtEndereco.Margin = new Padding(3, 4, 3, 4);
            txtEndereco.MaxLength = 50;
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(318, 27);
            txtEndereco.TabIndex = 8;
            txtEndereco.TextChanged += txtEndereco_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label3.Location = new Point(36, 323);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 20;
            label3.Text = "Endereço:";
            // 
            // mskCep
            // 
            mskCep.BackColor = Color.LawnGreen;
            mskCep.BorderStyle = BorderStyle.FixedSingle;
            mskCep.Location = new Point(165, 270);
            mskCep.Margin = new Padding(3, 4, 3, 4);
            mskCep.MaxLength = 50;
            mskCep.Name = "mskCep";
            mskCep.Size = new Size(318, 27);
            mskCep.TabIndex = 7;
            mskCep.TextChanged += mskCep_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label4.Location = new Point(36, 270);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 18;
            label4.Text = "Cep:";
            // 
            // txtContato
            // 
            txtContato.BackColor = Color.LawnGreen;
            txtContato.BorderStyle = BorderStyle.FixedSingle;
            txtContato.Location = new Point(165, 219);
            txtContato.Margin = new Padding(3, 4, 3, 4);
            txtContato.MaxLength = 50;
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(318, 27);
            txtContato.TabIndex = 6;
            txtContato.TextChanged += txtContato_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label5.Location = new Point(32, 219);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 16;
            label5.Text = "Contato:";
            // 
            // txtAdubo
            // 
            txtAdubo.BackColor = Color.LawnGreen;
            txtAdubo.BorderStyle = BorderStyle.FixedSingle;
            txtAdubo.Location = new Point(165, 471);
            txtAdubo.Margin = new Padding(3, 4, 3, 4);
            txtAdubo.MaxLength = 50;
            txtAdubo.Name = "txtAdubo";
            txtAdubo.Size = new Size(318, 27);
            txtAdubo.TabIndex = 11;
            txtAdubo.TextChanged += txtAdubo_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label6.Location = new Point(35, 478);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 26;
            label6.Text = "Adubo";
            // 
            // txtComplemento
            // 
            txtComplemento.BackColor = Color.LawnGreen;
            txtComplemento.BorderStyle = BorderStyle.FixedSingle;
            txtComplemento.Location = new Point(165, 423);
            txtComplemento.Margin = new Padding(3, 4, 3, 4);
            txtComplemento.MaxLength = 50;
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(318, 27);
            txtComplemento.TabIndex = 10;
            txtComplemento.TextChanged += txtComplemento_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label7.Location = new Point(36, 426);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 24;
            label7.Text = "Complemento";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.LawnGreen;
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Location = new Point(165, 366);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.MaxLength = 50;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(318, 27);
            txtNumero.TabIndex = 9;
            txtNumero.TextChanged += txtNumero_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label8.Location = new Point(36, 373);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 22;
            label8.Text = "Numero:";
            // 
            // txtAgrotoxico
            // 
            txtAgrotoxico.BackColor = Color.LawnGreen;
            txtAgrotoxico.BorderStyle = BorderStyle.FixedSingle;
            txtAgrotoxico.Location = new Point(165, 510);
            txtAgrotoxico.Margin = new Padding(3, 4, 3, 4);
            txtAgrotoxico.MaxLength = 50;
            txtAgrotoxico.Name = "txtAgrotoxico";
            txtAgrotoxico.Size = new Size(318, 27);
            txtAgrotoxico.TabIndex = 13;
            txtAgrotoxico.TextChanged += txtAgrotoxico_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(31, 517);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 30;
            label10.Text = "Agrotoxico:";
            // 
            // mskCnpj
            // 
            mskCnpj.BackColor = Color.LawnGreen;
            mskCnpj.BorderStyle = BorderStyle.FixedSingle;
            mskCnpj.Location = new Point(165, 129);
            mskCnpj.Name = "mskCnpj";
            mskCnpj.Size = new Size(318, 27);
            mskCnpj.TabIndex = 4;
            mskCnpj.MaskInputRejected += mskCnpj_MaskInputRejected;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.fechar;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(1117, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 62);
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmGerenciarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1190, 600);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(mskCnpj);
            Controls.Add(dgCliente);
            Controls.Add(btnPesquisarCliente);
            Controls.Add(txtNumero);
            Controls.Add(txtAgrotoxico);
            Controls.Add(lblNome);
            Controls.Add(btnExcluirCliente);
            Controls.Add(label10);
            Controls.Add(btnAlterarCliente);
            Controls.Add(txtNomeEmpresa);
            Controls.Add(txtFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(label1);
            Controls.Add(txtAdubo);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(txtComplemento);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(txtContato);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(mskCep);
            Controls.Add(txtEndereco);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmGerenciarCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGerenciarCliente";
            Load += frmGerenciarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dgCliente).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNomeEmpresa;
        private Label lblNome;
        private DataGridView dgCliente;
        private Button btnPesquisarCliente;
        private TextBox txtFiltro;
        private Label lblFiltro;
        private Button btnExcluirCliente;
        private Button btnAlterarCliente;
        private TextBox txtAgrotoxico;
        private Label label10;
        private TextBox txtAdubo;
        private Label label6;
        private TextBox txtComplemento;
        private Label label7;
        private TextBox txtNumero;
        private Label label8;
        private TextBox txtEndereco;
        private Label label3;
        private TextBox mskCep;
        private Label label4;
        private TextBox txtContato;
        private Label label5;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private MaskedTextBox mskCnpj;
        private PictureBox pictureBox1;
    }
}