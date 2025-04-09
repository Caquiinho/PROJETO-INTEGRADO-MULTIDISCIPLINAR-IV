using Applications.Configuration;
using Desktop.ValidadoresComponentes;
using Domain.DTO;
using Domain.Entities;
using Infrastructure.Encrypt;
using Infrastructure.Validadores;
using Newtonsoft.Json;

namespace Presentation.ModuloUsuario
{
    public partial class frmIncluirUsuario : Form
    {
        #region Propriedades        
        private readonly Email _email;
        private readonly Perfil _perfil;
        private readonly PasswordHasher _passwordHasher;
        private readonly ValidadorTextBox _validadorTextBox;
        private readonly Usuario _usuario;
        private readonly ServiceConfiguration _configuration;
        #endregion

        #region Construtor
        public frmIncluirUsuario(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _email = new Email();
            _perfil = new Perfil();
            _passwordHasher = new PasswordHasher();
            _validadorTextBox = new ValidadorTextBox();
            _usuario = new Usuario();
            _configuration = configuration;
            CarregarPefil();

        }
        #endregion

        #region Eventos
        private async void mskCep_Leave(object sender, EventArgs e)
        {
            string cep = mskCep.Text;
            string apiUrl = $"https://viacep.com.br/ws/{cep}/json/";
            string response = await GetApiData(apiUrl);
            var endereco = JsonConvert.DeserializeObject<EnderecoDTO>(response);
            txtEndereco.Text = endereco.Logradouro;
            txtBairro.Text = endereco.Bairro;
            txtUF.Text = endereco.Uf;
        }
        private void btnIncluirUsuario_Click(object sender, EventArgs e)
        {
            bool retornoIncluirUsuario = false;
            try
            {
                ValidarPreenchimentodeCampos();
                CapturarPerfilSelecionado();
                retornoIncluirUsuario = _configuration.usuarioService.IncluirUsuario(_usuario);
                if (retornoIncluirUsuario)
                {
                    MessageBox.Show("Usuário cadastrado com sucesso");
                    InicializarTela();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
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
        private async Task<string> GetApiData(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }
        private void InicializarTela()
        {
            try
            {
                txtNome.Clear();
                mskCep.Clear();
                txtEndereco.Clear();
                txtNumero.Clear();
                txtUF.Clear();
                txtBairro.Clear();
                txtComplemento.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
                txtNome.Focus();
            }
            catch
            {
                throw;
            }
        }
        private void ValidarPreenchimentodeCampos()
        {
            try
            {
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtNome.Parent))
                {
                    _usuario.Nome = txtNome.Text;
                }

                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtEmail.Parent))
                {
                    if (_email.ValidarEmail(txtEmail.Text))
                    {
                        _usuario.Email = txtEmail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Email inválido");
                    }


                }




                if (_validadorTextBox.ValidarTextBoxesPreenchidos(mskCep.Parent))
                {
                    _usuario.Cep = mskCep.Text;
                }

                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtEndereco.Parent))
                {
                    _usuario.Endereco = txtEndereco.Text;
                }

                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtNumero.Parent))
                {
                    _usuario.Numero = txtNumero.Text;
                }

                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtComplemento.Parent))
                {
                    _usuario.Complemento = txtComplemento.Text;
                }

                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtBairro.Parent))
                {
                    _usuario.Bairro = txtBairro.Text;
                }

                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtUF.Parent))
                {
                    _usuario.Uf = txtUF.Text;
                }
            

                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtSenha.Parent))
                {
                    _usuario.Senha = _passwordHasher.HashPassword(txtSenha.Text);
                }
            }
            catch
            {
                throw;
            }
        }
        private void CarregarPefil()
        {
            try
            {
                cbxPerfil.DataSource = _configuration.perfilService.ConsultarTodosPerfis();
                cbxPerfil.DisplayMember = "NomePerfil";
                cbxPerfil.ValueMember = "Id";
            }
            catch
            {
                throw;
            }
        }
        private void CapturarPerfilSelecionado()
        {
            try
            {
                var selectedId = cbxPerfil.SelectedValue;
                _usuario.Fk_Perfil = selectedId != null ? (int)selectedId : 0;
            }
            catch
            {
                throw;
            }
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIncluirUsuario_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            txtNome.MaxLength = 30;
        }

        private void cbxPerfil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mskCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskCep.MaxLength = 8;
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
    }


}