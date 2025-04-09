using Applications.Configuration;
using CpfCnpjLibrary;
using Desktop.ValidadoresComponentes;
using Domain.Entities;
using Infrastructure.Validadores;
using static System.Net.Mime.MediaTypeNames;

namespace Presentation.ModuloCliente
{
    public partial class frmIncluirCliente : Form
    {
        #region Propriedades
        private readonly Email _email;
        private readonly ValidadorTextBox _validadorTextBox;
        private readonly Cliente _cliente;
        private readonly ServiceConfiguration _configuration;
        #endregion

        #region Construtor
        public frmIncluirCliente(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _email = new Email();
            _validadorTextBox = new ValidadorTextBox();
            _cliente = new Cliente();
            _configuration = configuration;
        }
        #endregion

        #region Eventos


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
        private void InicializarTela()
        {
            try
            {
                txtNomeEmpresa.Clear();
                mskCnpj.Clear();
                mskkCep.Clear();
                txtEndereco.Clear();
                txtNumero.Clear();
                txtComplemento.Clear();
                txtEmail.Clear();
                txtContato.Clear();
                txtAgrotoxico.Clear();
                txtAdubo.Clear();
                txtNomeEmpresa.Focus();
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
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtNomeEmpresa.Parent))
                {
                    _cliente.NomeEmpresa = txtNomeEmpresa.Text;
                }
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(mskCnpj.Parent))
                {

                    if (Cnpj.Validar(mskCnpj.Text))
                    {
                        _cliente.Cnpj = mskCnpj.Text;
                    }

                    else
                    {
                        MessageBox.Show("CNPJ inválido"); // Mensagem atualizada
                        return false;
                    }


                    if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtEmail.Parent))
                    {
                        if (_email.ValidarEmail(txtEmail.Text))
                        {
                            _cliente.Email = txtEmail.Text;
                        }
                        else
                        {
                            MessageBox.Show("Email inválido");
                            return false;
                        }


                        if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtContato.Parent))
                        {
                            _cliente.Contato = txtContato.Text;
                        }
                        else
                        {
                            MessageBox.Show("Numero inválido");
                            return false;
                        }

                        if (_validadorTextBox.ValidarTextBoxesPreenchidos(mskkCep.Parent))
                        {
                            _cliente.Cep = mskkCep.Text;
                        }
                        else
                        {
                            MessageBox.Show("Endereco inválido");
                            return false;
                        }


                        if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtEndereco.Parent))
                        {
                            _cliente.Endereco = txtEndereco.Text;
                        }
                        else
                        {
                            MessageBox.Show("Endereco inválido");
                            return false;
                        }


                        if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtNumero.Parent))
                        {
                            _cliente.Numero = txtNumero.Text;
                        }
                        else
                        {
                            MessageBox.Show("Nº inválido");
                            return false;
                        }

                        if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtComplemento.Parent))
                        {
                            _cliente.Complemento = txtComplemento.Text;
                        }
                        else
                        {
                            MessageBox.Show("Complemento inválido");
                            return false;
                        }

                        if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtAgrotoxico.Parent))
                        {
                            _cliente.Agrotoxico = txtAgrotoxico.Text;
                        }
                        else
                        {
                            MessageBox.Show("Endereco inválido");
                            return false;
                        }




                        if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtAdubo.Parent))
                        {
                            _cliente.Adubo = txtAdubo.Text;
                        }
                        else
                        {
                            MessageBox.Show("Adubo inválido");
                            return false;
                        }



                    }
                }
            }




            catch
            {
                throw;
            }
            return retornoValidarPreenchimentodeCampos;
        }
        #endregion

        private void frmIncluirCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnIncluirCliente_Click_1(object sender, EventArgs e)
        {
            bool retornoIncluirCliente = false;
            try
            {
                bool retornoValidarPreenchimentodeCampos = ValidarPreenchimentodeCampos();

                if (retornoValidarPreenchimentodeCampos)
                {
                    // Tenta incluir o cliente e exibe mensagem dependendo do resultado
                    retornoIncluirCliente = _configuration.clienteService.IncluirCliente(_cliente);
                    if (retornoIncluirCliente)
                    {
                        MessageBox.Show("Fornecedor cadastrado com sucesso");
                        InicializarTela();
                    }
                    else
                    {
                        MessageBox.Show("Falha ao cadastrar");
                    }



                }
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

        private void mskCnpj_TextChanged(object sender, EventArgs e)
        {
            mskCnpj.MaxLength = 14;
        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeEmpresa_TextChanged(object sender, EventArgs e)
        {
            txtNomeEmpresa.MaxLength = 30;
        }

        private void mskkCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            mskkCep.MaxLength = 8;
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

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtEmail.MaxLength = 25;
        }

        private void txtContato_TextChanged(object sender, EventArgs e)
        {
            txtContato.MaxLength = 12;
        }

        private void txtAgrotoxico_TextChanged(object sender, EventArgs e)
        {
            txtAgrotoxico.MaxLength = 10;
        }

        private void txtAdubo_TextChanged(object sender, EventArgs e)
        {
            txtAdubo.MaxLength = 10;
        }
    }


}
