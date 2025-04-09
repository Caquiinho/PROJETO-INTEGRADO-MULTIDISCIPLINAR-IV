namespace Presentation.ModuloProduto
{
    partial class frmGerenciarProduto
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
            dgProduto = new DataGridView();
            btnPesquisarProduto = new Button();
            txtFiltro = new TextBox();
            lblFiltro = new Label();
            cbValor = new ComboBox();
            label4 = new Label();
            cbQuantidade = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            txtNomeProduto = new TextBox();
            btnExcluirProduto = new Button();
            btnAlterarProduto = new Button();
            ((System.ComponentModel.ISupportInitialize)dgProduto).BeginInit();
            SuspendLayout();
            // 
            // dgProduto
            // 
            dgProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduto.Location = new Point(325, 78);
            dgProduto.Name = "dgProduto";
            dgProduto.RowHeadersWidth = 51;
            dgProduto.Size = new Size(463, 237);
            dgProduto.TabIndex = 0;
            dgProduto.CellContentClick += dgProduto_CellContentClick;
            // 
            // btnPesquisarProduto
            // 
            btnPesquisarProduto.BackColor = Color.Lime;
            btnPesquisarProduto.FlatStyle = FlatStyle.Flat;
            btnPesquisarProduto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnPesquisarProduto.Location = new Point(497, 357);
            btnPesquisarProduto.Margin = new Padding(3, 4, 3, 4);
            btnPesquisarProduto.Name = "btnPesquisarProduto";
            btnPesquisarProduto.Size = new Size(291, 63);
            btnPesquisarProduto.TabIndex = 3;
            btnPesquisarProduto.Text = "Pesquisar Produto";
            btnPesquisarProduto.UseVisualStyleBackColor = false;
            btnPesquisarProduto.Click += btnPesquisarProduto_Click_1;
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = Color.LawnGreen;
            txtFiltro.Location = new Point(111, 39);
            txtFiltro.Margin = new Padding(3, 4, 3, 4);
            txtFiltro.MaxLength = 50;
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(377, 27);
            txtFiltro.TabIndex = 5;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lblFiltro.Location = new Point(23, 42);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(59, 20);
            lblFiltro.TabIndex = 4;
            lblFiltro.Text = "Filtro:";
            // 
            // cbValor
            // 
            cbValor.DisplayMember = "1";
            cbValor.FormattingEnabled = true;
            cbValor.Location = new Point(183, 238);
            cbValor.Name = "cbValor";
            cbValor.Size = new Size(125, 28);
            cbValor.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label4.Location = new Point(29, 238);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 60;
            label4.Text = "Valor";
            // 
            // cbQuantidade
            // 
            cbQuantidade.DisplayMember = "1";
            cbQuantidade.FormattingEnabled = true;
            cbQuantidade.Location = new Point(183, 184);
            cbQuantidade.Name = "cbQuantidade";
            cbQuantidade.Size = new Size(125, 28);
            cbQuantidade.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label3.Location = new Point(29, 184);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 58;
            label3.Text = "Quantidade";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label2.Location = new Point(29, 121);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 57;
            label2.Text = "Nome Produto";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(183, 114);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(125, 27);
            txtNomeProduto.TabIndex = 56;
            // 
            // btnExcluirProduto
            // 
            btnExcluirProduto.BackColor = Color.Red;
            btnExcluirProduto.FlatStyle = FlatStyle.Flat;
            btnExcluirProduto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic);
            btnExcluirProduto.Location = new Point(281, 322);
            btnExcluirProduto.Margin = new Padding(3, 4, 3, 4);
            btnExcluirProduto.Name = "btnExcluirProduto";
            btnExcluirProduto.Size = new Size(162, 72);
            btnExcluirProduto.TabIndex = 63;
            btnExcluirProduto.Text = "Excluir Fornecedor";
            btnExcluirProduto.UseVisualStyleBackColor = false;
            // 
            // btnAlterarProduto
            // 
            btnAlterarProduto.BackColor = Color.Yellow;
            btnAlterarProduto.FlatStyle = FlatStyle.Flat;
            btnAlterarProduto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAlterarProduto.Location = new Point(55, 322);
            btnAlterarProduto.Margin = new Padding(3, 4, 3, 4);
            btnAlterarProduto.Name = "btnAlterarProduto";
            btnAlterarProduto.Size = new Size(149, 72);
            btnAlterarProduto.TabIndex = 62;
            btnAlterarProduto.Text = "Alterar Fornecedor";
            btnAlterarProduto.UseVisualStyleBackColor = false;
            // 
            // frmGerenciarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExcluirProduto);
            Controls.Add(btnAlterarProduto);
            Controls.Add(cbValor);
            Controls.Add(label4);
            Controls.Add(cbQuantidade);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNomeProduto);
            Controls.Add(txtFiltro);
            Controls.Add(lblFiltro);
            Controls.Add(btnPesquisarProduto);
            Controls.Add(dgProduto);
            Name = "frmGerenciarProduto";
            Text = "frmGerenciarProduto";
            Load += frmGerenciarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgProduto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgProduto;
        private Button btnPesquisarProduto;
        private TextBox txtFiltro;
        private Label lblFiltro;
        private ComboBox cbValor;
        private Label label4;
        private ComboBox cbQuantidade;
        private Label label3;
        private Label label2;
        private TextBox txtNomeProduto;
        private Button btnExcluirProduto;
        private Button btnAlterarProduto;
    }
}