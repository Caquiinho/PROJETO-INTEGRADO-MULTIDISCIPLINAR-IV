using Applications.Configuration;
using Domain.Enums;
using Presentation.ModuloCliente;
using Presentation.ModuloFornecedor;
using Presentation.ModuloPerfil;
using Presentation.ModuloProduto;
using Presentation.ModuloUsuario;

namespace Presentation.ModuloInicial
{
    public partial class frmMenu : Form
    {
        #region Propriedades
        private readonly ServiceConfiguration _configuration;
        #endregion

        #region Construtor
        public frmMenu(ServiceConfiguration configuration, int fkPerfil)
        {
            InitializeComponent();
            _configuration = configuration;
            VisualizarMenu(fkPerfil);
        }
        #endregion

        #region Eventos
        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmGerenciarCliente frmGerenciarCliente = new frmGerenciarCliente(_configuration);
                frmGerenciarCliente.MdiParent = this;
                frmGerenciarCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmIncluirCliente frmIncluirCliente = new frmIncluirCliente(_configuration);
                frmIncluirCliente.MdiParent = this;
                frmIncluirCliente.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Confirmação",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void incluirToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                frmIncluirUsuario frmIncluirUsuario = new frmIncluirUsuario(_configuration);
                frmIncluirUsuario.MdiParent = this;
                frmIncluirUsuario.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void incluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmIncluirPerfil frmIncluirPerfil = new frmIncluirPerfil(_configuration);
                frmIncluirPerfil.MdiParent = this;
                frmIncluirPerfil.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void gerenciarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmGerenciarPerfil frmGerenciarPerfil = new frmGerenciarPerfil(_configuration);
                frmGerenciarPerfil.MdiParent = this;
                frmGerenciarPerfil.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        #endregion

        #region Métodos
        private void VisualizarMenu(int fkPerfil)
        {
            try
            {
                switch (fkPerfil)
                {
                    case (int)PerfilTipo.Usuario:
                        
                        break;
                }
            }
            catch
            {
                throw;
            }
        }
        #endregion

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_cliente_Click(object sender, EventArgs e)
        {
            frmIncluirCliente frm = new frmIncluirCliente(_configuration);
            frm.Show();
        }

        private void btn_Sair_Click(object sender, EventArgs e)


        {
            {
                try
                {
                    // Exibe a mensagem de confirmação antes de fechar o aplicativo
                    DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Confirmação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        frmLogin frm = new frmLogin(_configuration);
                        frm.Show(); // abre o formulario de login fazendo logout // Fecha o aplicativo se o usuário clicar em "Sim"
                    }
                    // Se o usuário clicar em "Não", nada acontece e o aplicativo continua rodando
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void btn_Alterar_Cliente_Click(object sender, EventArgs e)
        {
            frmGerenciarCliente frm = new frmGerenciarCliente(_configuration);
            frm.Show(); //abre o formulario de alterar ou excluir cliente.
        }

        private void btnUsuarioMenu_Click(object sender, EventArgs e)
        {
            frmIncluirUsuario frm = new frmIncluirUsuario(_configuration);
            frm.Show(); // abre o formulario de inserir usuario
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGerenciarUsuario frm = new frmGerenciarUsuario(_configuration);
            frm.Show(); // abre o formulario de alterar usuario
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            frmAdicionarFornecedor frm = new frmAdicionarFornecedor(_configuration);
            frm.Show();
        }

        private void btn_cadastrar_produto_Click(object sender, EventArgs e)
        {
            frmIncluirProduto frm = new frmIncluirProduto(_configuration);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAlterarProduto frm = new frmAlterarProduto(_configuration);
            frm.Show();
        }
    }
}
    