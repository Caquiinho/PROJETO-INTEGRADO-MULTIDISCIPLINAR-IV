using Applications.Configuration;
using Desktop.ValidadoresComponentes;
using Domain.Entities;
using Infrastructure.Factory;
using Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ModuloProduto
{
    public partial class frmIncluirProduto : Form
    {
        #region Propriedades
        private readonly ValidadorTextBox _validadorTextBox;
        private readonly Produto _produto;
        private readonly ServiceConfiguration _configuration;


        private Dictionary<int, string> itens = new Dictionary<int, string>();

        public frmIncluirProduto(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _validadorTextBox = new ValidadorTextBox();
            _produto = new Produto();
            _configuration = configuration;

            for (int i = 0; i <= 100; i++)
            {
                itens.Add(i, i.ToString());
            }

            CarregarComboBox();
            CarregarValoresComboBox();
        }
        #endregion

        private void InicializarTela()
        {
            try
            {
                txtNomeProduto.Clear();
            }
            catch
            {
                throw;
            }
        }

        private bool ValidarPreenchimentodeCampos()
        {
            bool retornoValidarPreenchimentodeCampos = true;
            try
            {
                // Verifica se o campo de nome do produto está preenchido
                if (string.IsNullOrWhiteSpace(txtNomeProduto.Text))
                {
                    retornoValidarPreenchimentodeCampos = false;
                    MessageBox.Show("Nome do produto não pode estar vazio.");
                }
                else
                {
                    _produto.NomeProduto = txtNomeProduto.Text;
                }

                // Verifica se um item foi selecionado em cbQuantidade
                if (cbQuantidade.SelectedItem == null)
                {
                    retornoValidarPreenchimentodeCampos = false;
                    MessageBox.Show("Selecione uma quantidade válida.");
                }
                else
                {
                    // Define a quantidade selecionada
                    _produto.Quantidade = ((KeyValuePair<int, string>)cbQuantidade.SelectedItem).Key;
                }

                // Verifica se um item foi selecionado em cbValor
                if (cbValor.SelectedItem == null)
                {
                    retornoValidarPreenchimentodeCampos = false;
                    MessageBox.Show("Selecione um valor válido.");
                }
                else
                {
                    // Define o preço selecionado
                    _produto.Preco = Convert.ToDecimal(((KeyValuePair<decimal, string>)cbValor.SelectedItem).Key);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar campos: " + ex.Message);
                retornoValidarPreenchimentodeCampos = false;
            }
            return retornoValidarPreenchimentodeCampos;
        }

        private void CarregarComboBox()
        {
            cbQuantidade.DataSource = new BindingSource(itens, null);
            cbQuantidade.DisplayMember = "Value";
            cbQuantidade.ValueMember = "Key";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CarregarValoresComboBox()
        {
            Dictionary<decimal, string> valores = new Dictionary<decimal, string>();

            for (decimal i = 00.00m; i <= 100.00m; i += 05.00m)
            {
                valores.Add(i, i.ToString("C"));
            }

            cbValor.DataSource = new BindingSource(valores, null);
            cbValor.DisplayMember = "Value";
            cbValor.ValueMember = "Key";
        }

        private void cbValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbValor.SelectedValue is decimal valorSelecionado)
            {
                MessageBox.Show($"Valor selecionado: {valorSelecionado:C}");
            }
        }




        private void frmIncluirProduto_Load_1(object sender, EventArgs e)
        {

        }

        private void btnIncluirProduto_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verifique se os campos estão preenchidos
                if (string.IsNullOrWhiteSpace(txtNomeProduto.Text) ||
                    cbQuantidade.SelectedItem == null || // Verifica se algo foi selecionado
                    cbValor.SelectedItem == null) // Verifica se algo foi selecionado
                {
                    MessageBox.Show("Por favor, preencha todos os campos.");
                    return;
                }

                // Inicialize o objeto Produto
                Produto produto = new Produto
                {
                    NomeProduto = txtNomeProduto.Text,
                    // Acessando a chave do KeyValuePair para Quantidade
                    Quantidade = ((KeyValuePair<int, string>)cbQuantidade.SelectedItem).Key,
                    // Acessando a chave do KeyValuePair para Preço
                    Preco = Convert.ToDecimal(((KeyValuePair<decimal, string>)cbValor.SelectedItem).Key)
                };

                // Verifique se o produto está realmente inicializado
                if (produto == null)
                {
                    MessageBox.Show("Produto não pode ser nulo.");
                    return;
                }

                // Crie a instância do repositório e chame o método
                ProdutoRepository repository = new ProdutoRepository(new SqlFactory());
                bool resultado = repository.IncluirProduto(produto);

                // Mensagem de sucesso ou erro
                if (resultado)
                {
                    MessageBox.Show("Produto incluído com sucesso!");
                }
                else
                {
                    MessageBox.Show("Erro ao incluir produto.");
                }
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Erro ao formatar dados: " + fe.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            txtNomeProduto.MaxLength = 30;
        }
    }
}

