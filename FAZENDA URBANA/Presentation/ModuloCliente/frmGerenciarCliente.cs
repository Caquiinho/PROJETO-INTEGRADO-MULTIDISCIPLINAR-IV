using Applications.Configuration;
using Domain.Entities;

namespace Presentation.ModuloCliente
{
    public partial class frmGerenciarCliente : Form
    {
        #region Propriedades
        private readonly Cliente _cliente;
        private readonly ServiceConfiguration _configuration;
        #endregion

        #region Construtor
        public frmGerenciarCliente(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _cliente = new Cliente();
            _configuration = configuration;
        }
        #endregion

        #region Eventos
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtFiltro.Text))
                {
                    dgCliente.DataSource = _configuration.clienteService.ConsultarCliente(txtFiltro.Text);
                    if (dgCliente.RowCount == 0)
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

        private void dgCliente_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgCliente.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgCliente.SelectedRows[0];
                    txtNomeEmpresa.Text = selectedRow.Cells["NomeEmpresa"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar dados do cliente: " + ex.Message);
            }
        }

        private void btnAlterarCliente_Click(object sender, EventArgs e)
        {
            bool clienteAtualizado = false;
            try
            {
                if (dgCliente.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgCliente.SelectedRows[0];

                    if (!String.IsNullOrEmpty(txtNomeEmpresa.Text))
                    {
                        _cliente.NomeEmpresa = txtNomeEmpresa.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo NomeEmpresa.");
                    }

                    if (!String.IsNullOrEmpty(mskCnpj.Text))
                    {
                        _cliente.Cnpj = mskCnpj.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo CNPJ.");
                    }

                    if (!String.IsNullOrEmpty(txtEmail.Text))
                    {
                        _cliente.Email = txtEmail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Email.");
                    }

                    if (!String.IsNullOrEmpty(txtContato.Text))
                    {
                        _cliente.Contato = txtContato.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Contato.");
                    }

                    if (!String.IsNullOrEmpty(mskCep.Text))
                    {
                        _cliente.Cep = mskCep.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Cep.");
                    }

                    if (!String.IsNullOrEmpty(txtEndereco.Text))
                    {
                        _cliente.Endereco = txtEndereco.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Endereço.");
                    }

                    if (!String.IsNullOrEmpty(txtNumero.Text))
                    {
                        _cliente.Numero = txtNumero.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Número.");
                    }

                    if (!String.IsNullOrEmpty(txtComplemento.Text))
                    {
                        _cliente.Complemento = txtComplemento.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Complemento.");
                    }

                    if (!String.IsNullOrEmpty(txtAdubo.Text))
                    {
                        _cliente.Adubo = txtAdubo.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Adubo.");
                    }

                    if (!String.IsNullOrEmpty(txtAgrotoxico.Text))
                    {
                        _cliente.Agrotoxico = txtAgrotoxico.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Agrotoxico.");
                        return;
                    }

                    // Função para atualizar o cliente no banco de dados
                    clienteAtualizado = _configuration.clienteService.AlterarCliente(_cliente);

                    if (clienteAtualizado)
                    {
                        MessageBox.Show("Fornecedor atualizado com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar o Fornecedor.");
                    }
                }
                else
                {
                    MessageBox.Show("Selecione uma linha no DataGrid.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do cliente: " + ex.Message);
            }
        }

        private void btnExcluirCliente_Click(object sender, EventArgs e)
        {
            bool clienteExcluido = false;
            try
            {
                if (dgCliente.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgCliente.SelectedRows[0];
                    clienteExcluido = _configuration.clienteService.ExcluirCliente(Convert.ToInt16(selectedRow.Cells["Id"].Value));
                    if (clienteExcluido)
                    {
                        MessageBox.Show("Dados do cliente excluído com sucesso.");
                        LimparTela();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir dados do cliente: " + ex.Message);
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
            dgCliente.DataSource = null;
            txtFiltro.Clear();
            txtNomeEmpresa.Clear();
            txtFiltro.Focus();
        }
        #endregion

        private void gbGerenciarCliente_Enter(object sender, EventArgs e)
        {
        }

        private void dgCliente_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtNomeEmpresa.Text = dgCliente.Rows[rowIndex].Cells[1].Value.ToString();
            mskCnpj.Text = dgCliente.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgCliente.Rows[rowIndex].Cells[3].Value.ToString();
            txtContato.Text = dgCliente.Rows[rowIndex].Cells[4].Value.ToString();
            mskCep.Text = dgCliente.Rows[rowIndex].Cells[5].Value.ToString();
            txtEndereco.Text = dgCliente.Rows[rowIndex].Cells[6].Value.ToString();
            txtNumero.Text = dgCliente.Rows[rowIndex].Cells[7].Value.ToString();
            txtComplemento.Text = dgCliente.Rows[rowIndex].Cells[8].Value.ToString();
            txtAdubo.Text = dgCliente.Rows[rowIndex].Cells[9].Value.ToString();
            txtAgrotoxico.Text = dgCliente.Rows[rowIndex].Cells[10].Value.ToString();
        }

        private void frmGerenciarCliente_Load(object sender, EventArgs e)
        {
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblFiltro_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdubo_TextChanged(object sender, EventArgs e)
        {
            txtAdubo.MaxLength = 10;
        }

        private void txtAgrotoxico_TextChanged(object sender, EventArgs e)
        {
            txtAgrotoxico.MaxLength = 10;
        }

        private void txtContato_TextChanged(object sender, EventArgs e)
        {
            txtContato.MaxLength = 12;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.MaxLength = 25;
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            txtComplemento.MaxLength = 14;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.MaxLength = 6;
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            txtEndereco.MaxLength = 30;
        }

        private void mskCep_TextChanged(object sender, EventArgs e)
        {
            mskCep.MaxLength = 8;
        }

        private void txtNomeEmpresa_TextChanged(object sender, EventArgs e)
        {
            txtNomeEmpresa.MaxLength = 30;
        }

        private void mskCnpj_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCnpj.MaxLength = 14;
        }
    }
}
