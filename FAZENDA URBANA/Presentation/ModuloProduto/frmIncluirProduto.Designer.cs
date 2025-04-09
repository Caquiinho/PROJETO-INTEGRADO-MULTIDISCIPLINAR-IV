namespace Presentation.ModuloProduto
{
    partial class frmIncluirProduto
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
            txtNomeProduto = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbQuantidade = new ComboBox();
            label4 = new Label();
            cbValor = new ComboBox();
            btnIncluirProduto = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.BackColor = Color.LawnGreen;
            txtNomeProduto.BorderStyle = BorderStyle.FixedSingle;
            txtNomeProduto.Location = new Point(312, 134);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(408, 27);
            txtNomeProduto.TabIndex = 50;
            txtNomeProduto.TextChanged += txtNomeProduto_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label2.Location = new Point(161, 134);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 51;
            label2.Text = "Nome Produto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label3.Location = new Point(161, 205);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 52;
            label3.Text = "Quantidade";
            // 
            // cbQuantidade
            // 
            cbQuantidade.BackColor = Color.LawnGreen;
            cbQuantidade.DisplayMember = "1";
            cbQuantidade.FormattingEnabled = true;
            cbQuantidade.Location = new Point(312, 197);
            cbQuantidade.Name = "cbQuantidade";
            cbQuantidade.Size = new Size(408, 28);
            cbQuantidade.TabIndex = 53;
            cbQuantidade.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            label4.Location = new Point(161, 259);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 54;
            label4.Text = "Valor Unidade";
            // 
            // cbValor
            // 
            cbValor.BackColor = Color.LawnGreen;
            cbValor.DisplayMember = "1";
            cbValor.FormattingEnabled = true;
            cbValor.Location = new Point(312, 251);
            cbValor.Name = "cbValor";
            cbValor.Size = new Size(408, 28);
            cbValor.TabIndex = 55;
            // 
            // btnIncluirProduto
            // 
            btnIncluirProduto.BackColor = Color.Lime;
            btnIncluirProduto.BackgroundImageLayout = ImageLayout.None;
            btnIncluirProduto.Cursor = Cursors.Hand;
            btnIncluirProduto.FlatStyle = FlatStyle.Flat;
            btnIncluirProduto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncluirProduto.Location = new Point(398, 328);
            btnIncluirProduto.Margin = new Padding(3, 4, 3, 4);
            btnIncluirProduto.Name = "btnIncluirProduto";
            btnIncluirProduto.Size = new Size(162, 52);
            btnIncluirProduto.TabIndex = 61;
            btnIncluirProduto.Text = "Cadastrar Produto";
            btnIncluirProduto.UseVisualStyleBackColor = false;
            btnIncluirProduto.Click += btnIncluirProduto_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(918, 70);
            panel1.TabIndex = 62;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.fechar;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(840, 9);
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
            label1.Location = new Point(312, 25);
            label1.Name = "label1";
            label1.Size = new Size(315, 31);
            label1.TabIndex = 8;
            label1.Text = "CADASTRO DE PRODUTOS";
            // 
            // frmIncluirProduto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 589);
            Controls.Add(panel1);
            Controls.Add(btnIncluirProduto);
            Controls.Add(cbValor);
            Controls.Add(label4);
            Controls.Add(cbQuantidade);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNomeProduto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmIncluirProduto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmIncluirProduto";
            Load += frmIncluirProduto_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtNomeProduto;
        private Label label2;
        private Label label3;
        private ComboBox cbQuantidade;
        private Label label4;
        private ComboBox cbValor;
        private Button btnIncluirProduto;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}