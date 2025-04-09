namespace Presentation.ModuloFornecedor
{
    partial class frmAdicionarFornecedor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            txtId = new TextBox();
            txtNomeEmpresa = new TextBox();
            txtCnpj = new TextBox();
            txtAgrotoxico = new TextBox();
            txtAdudo = new TextBox();
            txtMuda = new TextBox();
            lblCep = new Label();
            mskkCep = new MaskedTextBox();
            txtEnderecoFo = new TextBox();
            lblEndereco = new Label();
            txtComplemento = new TextBox();
            lblComplemento = new Label();
            txtNumero = new TextBox();
            lblNumero = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtContato = new TextBox();
            label10 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            txtQuantidadeMuda = new TextBox();
            txtQuantidadeAgrotoxico = new TextBox();
            txtQuantidadeAdubo = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnIncluirFornecedor = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label1.Location = new Point(28, 118);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label2.Location = new Point(28, 155);
            label2.Name = "label2";
            label2.Size = new Size(137, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome Empresa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label3.Location = new Point(28, 203);
            label3.Name = "label3";
            label3.Size = new Size(57, 20);
            label3.TabIndex = 2;
            label3.Text = "CNPJ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label5.Location = new Point(696, 214);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Adubo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label6.Location = new Point(694, 125);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 5;
            label6.Text = "Agrotoxico:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label8.Location = new Point(694, 172);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 7;
            label8.Text = "Muda:";
            // 
            // txtId
            // 
            txtId.Location = new Point(201, 111);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 9;
            // 
            // txtNomeEmpresa
            // 
            txtNomeEmpresa.Location = new Point(201, 148);
            txtNomeEmpresa.Name = "txtNomeEmpresa";
            txtNomeEmpresa.Size = new Size(125, 27);
            txtNomeEmpresa.TabIndex = 10;
            // 
            // txtCnpj
            // 
            txtCnpj.Location = new Point(201, 196);
            txtCnpj.Name = "txtCnpj";
            txtCnpj.Size = new Size(125, 27);
            txtCnpj.TabIndex = 11;
            // 
            // txtAgrotoxico
            // 
            txtAgrotoxico.Location = new Point(901, 118);
            txtAgrotoxico.Name = "txtAgrotoxico";
            txtAgrotoxico.Size = new Size(125, 27);
            txtAgrotoxico.TabIndex = 14;
            // 
            // txtAdudo
            // 
            txtAdudo.Location = new Point(901, 207);
            txtAdudo.Name = "txtAdudo";
            txtAdudo.Size = new Size(125, 27);
            txtAdudo.TabIndex = 13;
            // 
            // txtMuda
            // 
            txtMuda.Location = new Point(901, 165);
            txtMuda.Name = "txtMuda";
            txtMuda.Size = new Size(125, 27);
            txtMuda.TabIndex = 16;
            // 
            // lblCep
            // 
            lblCep.AutoSize = true;
            lblCep.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCep.Location = new Point(28, 247);
            lblCep.Name = "lblCep";
            lblCep.Size = new Size(48, 20);
            lblCep.TabIndex = 18;
            lblCep.Text = "Cep:";
            // 
            // mskkCep
            // 
            mskkCep.Location = new Point(201, 247);
            mskkCep.Margin = new Padding(3, 4, 3, 4);
            mskkCep.Mask = "00000-000";
            mskkCep.Name = "mskkCep";
            mskkCep.Size = new Size(74, 27);
            mskkCep.TabIndex = 20;
            // 
            // txtEnderecoFo
            // 
            txtEnderecoFo.Location = new Point(201, 282);
            txtEnderecoFo.Margin = new Padding(3, 4, 3, 4);
            txtEnderecoFo.Name = "txtEnderecoFo";
            txtEnderecoFo.Size = new Size(273, 27);
            txtEnderecoFo.TabIndex = 22;
            // 
            // lblEndereco
            // 
            lblEndereco.AutoSize = true;
            lblEndereco.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEndereco.Location = new Point(32, 289);
            lblEndereco.Name = "lblEndereco";
            lblEndereco.Size = new Size(94, 20);
            lblEndereco.TabIndex = 21;
            lblEndereco.Text = "Endereço:";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(201, 359);
            txtComplemento.Margin = new Padding(3, 4, 3, 4);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(273, 27);
            txtComplemento.TabIndex = 23;
            // 
            // lblComplemento
            // 
            lblComplemento.AutoSize = true;
            lblComplemento.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplemento.Location = new Point(31, 366);
            lblComplemento.Name = "lblComplemento";
            lblComplemento.Size = new Size(129, 20);
            lblComplemento.TabIndex = 24;
            lblComplemento.Text = "Complemento:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(201, 317);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(273, 27);
            txtNumero.TabIndex = 25;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumero.Location = new Point(32, 317);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(80, 20);
            lblNumero.TabIndex = 26;
            lblNumero.Text = "Número:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(201, 411);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 27);
            txtEmail.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 418);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 28;
            label4.Text = "Emai:";
            // 
            // txtContato
            // 
            txtContato.Location = new Point(201, 465);
            txtContato.Margin = new Padding(3, 4, 3, 4);
            txtContato.Name = "txtContato";
            txtContato.Size = new Size(273, 27);
            txtContato.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(31, 472);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 30;
            label10.Text = "Contato:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1112, 70);
            panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.fechar;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(1031, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(55, 58);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(374, 18);
            label7.Name = "label7";
            label7.Size = new Size(368, 31);
            label7.TabIndex = 8;
            label7.Text = "CADASTRO DE FORNECEDORES";
            // 
            // txtQuantidadeMuda
            // 
            txtQuantidadeMuda.Location = new Point(901, 300);
            txtQuantidadeMuda.Name = "txtQuantidadeMuda";
            txtQuantidadeMuda.Size = new Size(125, 27);
            txtQuantidadeMuda.TabIndex = 37;
            // 
            // txtQuantidadeAgrotoxico
            // 
            txtQuantidadeAgrotoxico.Location = new Point(901, 250);
            txtQuantidadeAgrotoxico.Name = "txtQuantidadeAgrotoxico";
            txtQuantidadeAgrotoxico.Size = new Size(125, 27);
            txtQuantidadeAgrotoxico.TabIndex = 36;
            // 
            // txtQuantidadeAdubo
            // 
            txtQuantidadeAdubo.Location = new Point(901, 333);
            txtQuantidadeAdubo.Name = "txtQuantidadeAdubo";
            txtQuantidadeAdubo.Size = new Size(125, 27);
            txtQuantidadeAdubo.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label11.Location = new Point(696, 307);
            label11.Name = "label11";
            label11.Size = new Size(161, 20);
            label11.TabIndex = 34;
            label11.Text = "Quantidade Muda:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label12.Location = new Point(696, 257);
            label12.Name = "label12";
            label12.Size = new Size(205, 20);
            label12.TabIndex = 33;
            label12.Text = "Quantidade Agrotoxico:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label13.Location = new Point(696, 346);
            label13.Name = "label13";
            label13.Size = new Size(168, 20);
            label13.TabIndex = 32;
            label13.Text = "Quantidade Adubo:";
            // 
            // btnIncluirFornecedor
            // 
            btnIncluirFornecedor.BackColor = Color.Lime;
            btnIncluirFornecedor.BackgroundImageLayout = ImageLayout.None;
            btnIncluirFornecedor.Cursor = Cursors.Hand;
            btnIncluirFornecedor.FlatStyle = FlatStyle.Flat;
            btnIncluirFornecedor.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncluirFornecedor.Location = new Point(477, 527);
            btnIncluirFornecedor.Margin = new Padding(3, 4, 3, 4);
            btnIncluirFornecedor.Name = "btnIncluirFornecedor";
            btnIncluirFornecedor.Size = new Size(162, 52);
            btnIncluirFornecedor.TabIndex = 38;
            btnIncluirFornecedor.Text = "Cadastrar";
            btnIncluirFornecedor.UseVisualStyleBackColor = false;
            // 
            // frmAdicionarFornecedor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 616);
            Controls.Add(btnIncluirFornecedor);
            Controls.Add(txtQuantidadeMuda);
            Controls.Add(txtQuantidadeAgrotoxico);
            Controls.Add(txtQuantidadeAdubo);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(panel1);
            Controls.Add(txtContato);
            Controls.Add(label10);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(mskkCep);
            Controls.Add(txtEnderecoFo);
            Controls.Add(lblEndereco);
            Controls.Add(txtComplemento);
            Controls.Add(lblComplemento);
            Controls.Add(txtNumero);
            Controls.Add(lblNumero);
            Controls.Add(lblCep);
            Controls.Add(txtMuda);
            Controls.Add(txtAgrotoxico);
            Controls.Add(txtAdudo);
            Controls.Add(txtCnpj);
            Controls.Add(txtNomeEmpresa);
            Controls.Add(txtId);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAdicionarFornecedor";
            Text = "frmAdicionarFornecedor";
            Load += frmAdicionarFornecedor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtId;
        private TextBox txtNomeEmpresa;
        private TextBox txtCnpj;
        private TextBox txtAgrotoxico;
        private TextBox txtAdudo;
        private TextBox textBox7;
        private TextBox txtMuda;
        private TextBox txtQuantAgrotoxico;
        private Label lblCep;
        private MaskedTextBox mskkCep;
        private TextBox txtEnderecoFo;
        private Label lblEndereco;
        private TextBox txtComplemento;
        private Label lblComplemento;
        private TextBox txtNumero;
        private Label lblNumero;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtContato;
        private Label label10;
        private Panel panel1;
        private PictureBox pictureBox1;
        private TextBox txtQuantidadeMuda;
        private TextBox txtQuantidadeAgrotoxico;
        private TextBox txtQuantidadeAdubo;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnIncluirFornecedor;
    }
}