using Applications.Configuration;
using Desktop.ValidadoresComponentes;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Presentation.ModuloProduto
{
    public partial class frmAlterarProduto : Form
    {
        private readonly Produto _produto;
        private readonly ServiceConfiguration _configuration;


        private Dictionary<int, string> itens = new Dictionary<int, string>();


        public frmAlterarProduto(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _produto = new Produto();
            _configuration = configuration;

            for (int i = 0; i <= 100; i++)
            {
                itens.Add(i, i.ToString());
            }

            CarregarComboBox();
            CarregarValoresComboBox();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            bool produtoAtualizado = false;
            try
            {
                if (_configuration == null || _configuration.produtoService == null)
                {
                    MessageBox.Show("Serviço de produto não configurado.");
                    return;
                }

                if (dgProduto.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgProduto.SelectedRows[0];

                    if (!string.IsNullOrEmpty(txtNomeProduto.Text))
                    {
                        _produto.NomeProduto = txtNomeProduto.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Nome.");
                        return;
                    }

                    if (!string.IsNullOrEmpty(cbQuantidade.Text) && int.TryParse(cbQuantidade.Text, out int quantidade))
                    {
                        _produto.Quantidade = quantidade;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Quantidade com um valor válido.");
                        return;
                    }

                    // Alteração aqui para tratar o valor selecionado no ComboBox
                    if (cbPreco.SelectedValue != null && cbPreco.SelectedValue is decimal selectedPreco)
                    {
                        _produto.Preco = selectedPreco;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Preço com um valor válido.");
                        return;
                    }

                    _produto.Id = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    produtoAtualizado = _configuration.produtoService.AlterarProduto(_produto);
                    if (produtoAtualizado)
                    {
                        MessageBox.Show("Dados do produto atualizados com sucesso.");
                        LimparTela();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto para atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do produto: " + ex.Message);
            }
        }

        private void LimparTela()
        {
            dgProduto.DataSource = null;
            txtFiltro.Clear();
            txtNomeProduto.Clear();
            txtFiltro.Focus();
        }

        private void CarregarValoresComboBox()
        {
            Dictionary<decimal, string> valores = new Dictionary<decimal, string>();

            // Alteração para não formatar como moeda, para facilitar a conversão
            for (decimal i = 00.00m; i <= 100.00m; i += 05.00m)
            {
                valores.Add(i, i.ToString());  // Remover formatação de moeda
            }

            cbPreco.DataSource = new BindingSource(valores, null);
            cbPreco.DisplayMember = "Value";
            cbPreco.ValueMember = "Key";
        }

        private void CarregarComboBox()
        {
            cbQuantidade.DataSource = new BindingSource(itens, null);
            cbQuantidade.DisplayMember = "Value";
            cbQuantidade.ValueMember = "Key";
        }

        private void frmAlterarProduto_Load(object sender, EventArgs e)
        {
            // Event handler vazio
        }

        private void dgProduto_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtNomeProduto.Text = dgProduto.Rows[rowIndex].Cells[1].Value.ToString();
            cbQuantidade.Text = dgProduto.Rows[rowIndex].Cells[2].Value.ToString();
            cbPreco.Text = dgProduto.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtFiltro.Text))
                {
                    dgProduto.DataSource = _configuration.produtoService.ConsultarProduto(txtFiltro.Text);
                    if (dgProduto.RowCount == 0)
                    {
                        MessageBox.Show("Não existem registros para o Fornecedor informado.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencher o filtro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar dados Fornecedor: " + ex.Message);
            }
        }

        private void dgUsuario_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgProduto.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgProduto.SelectedRows[0];
                    txtNomeProduto.Text = selectedRow.Cells["NomeProduto"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar dados do Usuario: " + ex.Message);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            bool produtoExcluido = false;
            try
            {
                if (dgProduto.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgProduto.SelectedRows[0];
                    produtoExcluido = _configuration.produtoService.ExcluirProduto(Convert.ToInt16(selectedRow.Cells["Id"].Value));
                    if (produtoExcluido)
                    {
                        MessageBox.Show("Dados do produto excluído com sucesso.");
                        LimparTela();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir dados do produto: " + ex.Message);
            }
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            txtNomeProduto.MaxLength = 30;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            txtFiltro.MaxLength = 30;
        }
    }
}
