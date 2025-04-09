using System;
using System.Configuration;
using System.Windows.Forms;
using Applications.Configuration;
using Domain.Entities;

namespace Presentation.ModuloProduto
{
    public partial class frmGerenciarProduto : Form
    {
        #region Propriedades
        private readonly Produto _Produto;
        private readonly ServiceConfiguration _configuration;
        #endregion

        #region Construtor
        public frmGerenciarProduto(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _Produto = new Produto();
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration), "Configuration não pode ser nulo.");

           
        }
        #endregion

        #region Eventos
        private void dgProduto_SelectionChanged(object sender, EventArgs e)
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
                MessageBox.Show("Erro ao selecionar dados do produto: " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

        #region Métodos
        private void LimparTela()
        {
            dgProduto.DataSource = null;
            txtFiltro.Clear();
            txtNomeProduto.Clear();
            txtFiltro.Focus();
        }
        #endregion

        private void frmGerenciarProduto_Load(object sender, EventArgs e)
        {
        }

        private void dgProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnPesquisarProduto_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_configuration == null || _configuration.produtoService == null)
                {
                    MessageBox.Show("Configuração ou serviço de produto não foi inicializado.");
                    return;
                }

                if (!String.IsNullOrEmpty(txtFiltro.Text))
                {
                    dgProduto.DataSource = _configuration.produtoService.ConsultarProduto(txtFiltro.Text);
                    if (dgProduto.RowCount == 0)
                    {
                        MessageBox.Show("Nenhum produto encontrado com o filtro informado.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha o campo de filtro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar produto: " + ex.Message);
            }
        }


        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            bool produtoExcluido = false;
            try
            {
                if (dgProduto.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgProduto.SelectedRows[0];
                    produtoExcluido = _configuration.produtoService.ExcluirProduto(Convert.ToInt32(selectedRow.Cells["Id"].Value));
                    if (produtoExcluido)
                    {
                        MessageBox.Show("Produto excluído com sucesso.");
                        LimparTela();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto para excluir.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o produto: " + ex.Message);
            }
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgProduto.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgProduto.SelectedRows[0];

                    if (!String.IsNullOrEmpty(txtNomeProduto.Text))
                    {
                        _Produto.NomeProduto = txtNomeProduto.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencha o campo NomeProduto.");
                        return;
                    }

                    if (!String.IsNullOrEmpty(cbQuantidade.Text) && int.TryParse(cbQuantidade.Text, out int quantidade))
                    {
                        _Produto.Quantidade = quantidade;
                    }
                    else
                    {
                        MessageBox.Show("Preencha o campo Quantidade com um número válido.");
                        return;
                    }

                    if (!String.IsNullOrEmpty(cbValor.Text) && decimal.TryParse(cbValor.Text, out decimal valor))
                    {
                        _Produto.Valor = valor;
                    }
                    else
                    {
                        MessageBox.Show("Preencha o campo Valor com um número válido.");
                        return;
                    }

                    // Chamar método de atualização
                    bool produtoAtualizado = _configuration.produtoService.AlterarProduto(_Produto);
                    if (produtoAtualizado)
                    {
                        MessageBox.Show("Produto atualizado com sucesso.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um produto para alterar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao alterar dados do produto: " + ex.Message);
            }
        }
    }
}
