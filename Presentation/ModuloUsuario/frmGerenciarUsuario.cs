using Applications.Configuration;
using Domain.Entities;

namespace Presentation.ModuloUsuario
{
    public partial class frmGerenciarUsuario : Form
    {
        #region Propriedades
        private readonly Usuario _Usuario;
        private readonly ServiceConfiguration _configuration;
        #endregion

        #region Construtor
        public frmGerenciarUsuario(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _Usuario = new Usuario();
            _configuration = configuration;
        }
        #endregion

        #region Eventos
        private void btnPesquisarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtFiltro.Text))
                {
                    dgUsuario.DataSource = _configuration.usuarioService.ConsultarUsuario(txtFiltro.Text);
                    if (dgUsuario.RowCount == 0)
                    {
                        MessageBox.Show("Não existem registros para o Usuario informado.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencher o filtro.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar dados do Usuario: " + ex.Message);
            }
        }
        private void dgUsuario_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgUsuario.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgUsuario.SelectedRows[0];
                    txtNome.Text = selectedRow.Cells["Nome"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar dados do Usuario: " + ex.Message);
            }
        }
        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            bool UsuarioAtualizado = false;
            try
            {
                if (dgUsuario.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgUsuario.SelectedRows[0];

                    // Atualiza o Nome
                    if (!String.IsNullOrEmpty(txtNome.Text))
                    {
                        _Usuario.Nome = txtNome.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Nome.");
                        return;
                    }

                    // Atualiza o Cep
                    if (!String.IsNullOrEmpty(mskCep.Text))
                    {
                        _Usuario.Cep = mskCep.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo CEP.");
                        return;
                    }

                    // Atualiza o Endereço
                    if (!String.IsNullOrEmpty(txtEndereco.Text))
                    {
                        _Usuario.Endereco = txtEndereco.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Endereço.");
                        return;
                    }

                    // Atualiza o Complemento
                    if (!String.IsNullOrEmpty(txtComplemento.Text))
                    {
                        _Usuario.Complemento = txtComplemento.Text;
                    }

                    // Atualiza a UF
                    if (!String.IsNullOrEmpty(txtUF.Text))
                    {
                        _Usuario.Uf = txtUF.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo UF.");
                        return;
                    }

                    // Atualiza o Bairro
                    if (!String.IsNullOrEmpty(txtBairro.Text))
                    {
                        _Usuario.Bairro = txtBairro.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Bairro.");
                        return;
                    }

                    // Atualiza o Número
                    if (!String.IsNullOrEmpty(txtNumero.Text))
                    {
                        _Usuario.Numero = txtNumero.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Número.");
                        return;
                    }

                    // Atualiza o Email
                    if (!String.IsNullOrEmpty(txtEmail.Text))
                    {
                        _Usuario.Email = txtEmail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Preencher o campo Email.");
                        return;
                    }

                    // Atualiza o Id do usuário
                    _Usuario.Id = Convert.ToInt16(selectedRow.Cells["Id"].Value);

                    // Chama o serviço para alterar o usuário
                    UsuarioAtualizado = _configuration.usuarioService.AlterarUsuario(_Usuario);
                    if (UsuarioAtualizado)
                    {
                        MessageBox.Show("Dados do Usuario atualizados com sucesso.");
                        LimparTela(); // Limpa a tela após a atualização
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um usuário para atualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do Usuario: " + ex.Message);
            }
        }


        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            bool UsuarioExcluido = false;
            try
            {
                if (dgUsuario.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgUsuario.SelectedRows[0];
                    UsuarioExcluido = _configuration.usuarioService.ExcluirUsuario(Convert.ToInt16(selectedRow.Cells["Id"].Value));
                    if (UsuarioExcluido)
                    {
                        MessageBox.Show("Dados do Usuario excluído com sucesso.");
                        LimparTela();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir dados do Usuario: " + ex.Message);
            }
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Confirmação",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        #endregion

        #region Métodos
        private void LimparTela()
        {
            dgUsuario.DataSource = null;
            txtFiltro.Clear();
            txtNome.Clear();
            mskCep.Clear();
            txtEndereco.Clear();
            txtComplemento.Clear();
            txtUF.Clear();
            txtBairro.Clear();
            txtNumero.Clear();
            txtEmail.Clear();
            txtFiltro.Focus();
        }

        #endregion

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.MaxLength = 30;
        }

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgUsuario_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtNome.Text = dgUsuario.Rows[rowIndex].Cells[3].Value.ToString();
            mskCep.Text = dgUsuario.Rows[rowIndex].Cells[4].Value.ToString();
            txtEndereco.Text = dgUsuario.Rows[rowIndex].Cells[5].Value.ToString();
            txtNumero.Text = dgUsuario.Rows[rowIndex].Cells[6].Value.ToString();
            txtComplemento.Text = dgUsuario.Rows[rowIndex].Cells[7].Value.ToString();
            txtBairro.Text = dgUsuario.Rows[rowIndex].Cells[8].Value.ToString();
            txtUF.Text = dgUsuario.Rows[rowIndex].Cells[9].Value.ToString();
            txtEmail.Text = dgUsuario.Rows[rowIndex].Cells[10].Value.ToString();
            cbxPerfil.Text = dgUsuario.Rows[rowIndex].Cells[12].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGerenciarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void mskCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCep.MaxLength = 8;
        }

        private void dgUsuario_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            txtEndereco.MaxLength = 30;
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {
            txtNumero.MaxLength = 6;
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            txtComplemento.MaxLength = 14;
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            txtBairro.MaxLength = 20;
        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {
            txtUF.MaxLength = 2;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.MaxLength = 40;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}