

namespace Presentation.ModuloProduto
{
    partial class frmAlterarProduto
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
            txtNomeProduto = new TextBox();
            label2 = new Label();
            cbQuantidade = new ComboBox();
            label3 = new Label();
            cbPreco = new ComboBox();
            dgProduto = new DataGridView();
            label4 = new Label();
            txtFiltro = new TextBox();
            btnAtualizar = new Button();
            btnPesquisar = new Button();
            btnDeletar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgProduto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 107);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 30;
            label1.Text = "Nome produto";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BackColor = Color.LawnGreen;
            txtNomeProduto.BorderStyle = BorderStyle.FixedSingle;
            txtNomeProduto.Location = new Point(196, 100);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(125, 27);
            txtNomeProduto.TabIndex = 31;
            txtNomeProduto.TextChanged += txtNomeProduto_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 161);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 32;
            label2.Text = "Quantidade";
            // 
            // cbQuantidade
            // 
            cbQuantidade.BackColor = Color.LawnGreen;
            cbQuantidade.FormattingEnabled = true;
            cbQuantidade.Location = new Point(196, 153);
            cbQuantidade.Name = "cbQuantidade";
            cbQuantidade.Size = new Size(151, 28);
            cbQuantidade.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(47, 212);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 34;
            label3.Text = "Preco Unidade";
            // 
            // cbPreco
            // 
            cbPreco.BackColor = Color.LawnGreen;
            cbPreco.FormattingEnabled = true;
            cbPreco.Location = new Point(196, 204);
            cbPreco.Name = "cbPreco";
            cbPreco.Size = new Size(151, 28);
            cbPreco.TabIndex = 35;
            // 
            // dgProduto
            // 
            dgProduto.BackgroundColor = Color.ForestGreen;
            dgProduto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgProduto.Location = new Point(375, 100);
            dgProduto.Name = "dgProduto";
            dgProduto.RowHeadersWidth = 51;
            dgProduto.Size = new Size(811, 368);
            dgProduto.TabIndex = 36;
            dgProduto.RowHeaderMouseClick += dgProduto_RowHeaderMouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(43, 34);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 37;
            label4.Text = "Filtro";
            // 
            // txtFiltro
            // 
            txtFiltro.BackColor = Color.LawnGreen;
            txtFiltro.BorderStyle = BorderStyle.FixedSingle;
            txtFiltro.Location = new Point(122, 27);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(438, 27);
            txtFiltro.TabIndex = 38;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // btnAtualizar
            // 
            btnAtualizar.BackColor = Color.Yellow;
            btnAtualizar.Cursor = Cursors.Hand;
            btnAtualizar.FlatStyle = FlatStyle.Popup;
            btnAtualizar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic);
            btnAtualizar.Location = new Point(12, 323);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(166, 74);
            btnAtualizar.TabIndex = 39;
            btnAtualizar.Text = "Alterar Produto";
            btnAtualizar.UseVisualStyleBackColor = false;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnPesquisar
            // 
            btnPesquisar.BackColor = Color.Lime;
            btnPesquisar.Cursor = Cursors.Hand;
            btnPesquisar.FlatStyle = FlatStyle.Popup;
            btnPesquisar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic);
            btnPesquisar.Location = new Point(701, 12);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(327, 75);
            btnPesquisar.TabIndex = 40;
            btnPesquisar.Text = "Pesquisar Produto";
            btnPesquisar.UseVisualStyleBackColor = false;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.BackColor = Color.Red;
            btnDeletar.Cursor = Cursors.Hand;
            btnDeletar.FlatStyle = FlatStyle.Popup;
            btnDeletar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic);
            btnDeletar.Location = new Point(203, 323);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(166, 74);
            btnDeletar.TabIndex = 41;
            btnDeletar.Text = "Excluir Produto";
            btnDeletar.UseCompatibleTextRendering = true;
            btnDeletar.UseVisualStyleBackColor = false;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.fechar1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(1124, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 50);
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // frmAlterarProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 600);
            Controls.Add(pictureBox1);
            Controls.Add(btnDeletar);
            Controls.Add(btnPesquisar);
            Controls.Add(btnAtualizar);
            Controls.Add(txtFiltro);
            Controls.Add(label4);
            Controls.Add(dgProduto);
            Controls.Add(cbPreco);
            Controls.Add(label3);
            Controls.Add(cbQuantidade);
            Controls.Add(label2);
            Controls.Add(txtNomeProduto);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAlterarProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmAlterarProduto";
            Load += frmAlterarProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dgProduto).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }




        #endregion

        private Label label1;
        private TextBox txtNomeProduto;
        private Label label2;
        private ComboBox cbQuantidade;
        private Label label3;
        private ComboBox cbPreco;
        private DataGridView dgProduto;
        private Label label4;
        private TextBox txtFiltro;
        private Button btnAtualizar;
        private Button btnPesquisar;
        private Button btnDeletar;
        private PictureBox pictureBox1;
    }
}