namespace Presentation.ModuloPerfil
{
    partial class frmIncluirPerfil
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
            lblNomePerfil = new Label();
            gbIncluirCliente = new GroupBox();
            txtNomePerfil = new TextBox();
            btnIncluirPerfil = new Button();
            btnSair = new Button();
            cbQuantidade = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            cbValor = new ComboBox();
            gbIncluirCliente.SuspendLayout();
            SuspendLayout();
            // 
            // lblNomePerfil
            // 
            lblNomePerfil.AutoSize = true;
            lblNomePerfil.Location = new Point(15, 41);
            lblNomePerfil.Name = "lblNomePerfil";
            lblNomePerfil.Size = new Size(114, 20);
            lblNomePerfil.TabIndex = 0;
            lblNomePerfil.Text = "Nome Produto: ";
            // 
            // gbIncluirCliente
            // 
            gbIncluirCliente.Controls.Add(txtNomePerfil);
            gbIncluirCliente.Controls.Add(lblNomePerfil);
            gbIncluirCliente.Location = new Point(29, 16);
            gbIncluirCliente.Margin = new Padding(3, 4, 3, 4);
            gbIncluirCliente.Name = "gbIncluirCliente";
            gbIncluirCliente.Padding = new Padding(3, 4, 3, 4);
            gbIncluirCliente.Size = new Size(721, 99);
            gbIncluirCliente.TabIndex = 1;
            gbIncluirCliente.TabStop = false;
            // 
            // txtNomePerfil
            // 
            txtNomePerfil.Location = new Point(135, 34);
            txtNomePerfil.Margin = new Padding(3, 4, 3, 4);
            txtNomePerfil.MaxLength = 100;
            txtNomePerfil.Name = "txtNomePerfil";
            txtNomePerfil.Size = new Size(372, 27);
            txtNomePerfil.TabIndex = 1;
            // 
            // btnIncluirPerfil
            // 
            btnIncluirPerfil.Location = new Point(44, 261);
            btnIncluirPerfil.Margin = new Padding(3, 4, 3, 4);
            btnIncluirPerfil.Name = "btnIncluirPerfil";
            btnIncluirPerfil.Size = new Size(127, 31);
            btnIncluirPerfil.TabIndex = 5;
            btnIncluirPerfil.Text = "Incluir Perfil";
            btnIncluirPerfil.UseVisualStyleBackColor = true;
            btnIncluirPerfil.Click += btnIncluirPerfil_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(623, 261);
            btnSair.Margin = new Padding(3, 4, 3, 4);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(127, 31);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // cbQuantidade
            // 
            cbQuantidade.DisplayMember = "1";
            cbQuantidade.FormattingEnabled = true;
            cbQuantidade.Location = new Point(164, 107);
            cbQuantidade.Name = "cbQuantidade";
            cbQuantidade.Size = new Size(125, 28);
            cbQuantidade.TabIndex = 54;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label3.Location = new Point(44, 115);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 55;
            label3.Text = "Quantidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label4.Location = new Point(53, 166);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 56;
            label4.Text = "Valor";
            // 
            // cbValor
            // 
            cbValor.DisplayMember = "1";
            cbValor.FormattingEnabled = true;
            cbValor.Location = new Point(164, 166);
            cbValor.Name = "cbValor";
            cbValor.Size = new Size(125, 28);
            cbValor.TabIndex = 57;
            // 
            // frmIncluirPerfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 308);
            ControlBox = false;
            Controls.Add(cbValor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbQuantidade);
            Controls.Add(btnSair);
            Controls.Add(btnIncluirPerfil);
            Controls.Add(gbIncluirCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmIncluirPerfil";
            Text = "frmIncluirPerfil";
            Load += frmIncluirPerfil_Load;
            gbIncluirCliente.ResumeLayout(false);
            gbIncluirCliente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomePerfil;
        private GroupBox gbIncluirCliente;
        private Button btnIncluirPerfil;
        private Button btnSair;
        private TextBox txtNomePerfil;
        private ComboBox cbQuantidade;
        private Label label3;
        private Label label4;
        private ComboBox cbValor;
    }
}
