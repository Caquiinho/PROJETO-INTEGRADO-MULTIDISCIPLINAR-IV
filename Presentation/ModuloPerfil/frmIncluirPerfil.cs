using Applications.Configuration;
using Desktop.ValidadoresComponentes;
using Domain.Entities;

namespace Presentation.ModuloPerfil
{
    public partial class frmIncluirPerfil : Form
    {
        #region Propriedades        
        private readonly ValidadorTextBox _validadorTextBox;
        private readonly Perfil _Perfil;
        private readonly ServiceConfiguration _configuration;
        private Dictionary<int, string> itens = new Dictionary<int, string>();
        #endregion

        #region Construtor
        public frmIncluirPerfil(ServiceConfiguration configuration)
        {
            InitializeComponent();
            _validadorTextBox = new ValidadorTextBox();
            _Perfil = new Perfil();
            _configuration = configuration;
        }
        #endregion

        #region Eventos
        private void btnIncluirPerfil_Click(object sender, EventArgs e)
        {
            bool retornoIncluirPerfil = false;
            try
            {
                bool retornoValidarPreenchimentodeCampos = ValidarPreenchimentodeCampos();
                if (retornoValidarPreenchimentodeCampos)
                {
                    retornoIncluirPerfil = _configuration.perfilService.IncluirPerfil(_Perfil);
                    if (retornoIncluirPerfil)
                    {
                        MessageBox.Show("Perfil cadastrado com sucesso");
                        InicializarTela();
                    }
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
        private void InicializarTela()
        {
            try
            {
                txtNomePerfil.Clear();
                txtNomePerfil.Focus();
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
                if (_validadorTextBox.ValidarTextBoxesPreenchidos(txtNomePerfil.Parent))
                {
                    _Perfil.NomePerfil = txtNomePerfil.Text;
                }
            }
            catch
            {
                throw;
            }
            return retornoValidarPreenchimentodeCampos;
        }
        #endregion

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

            for (decimal i = 10.00m; i <= 100.00m; i += 10.00m)
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


        private void frmIncluirPerfil_Load(object sender, EventArgs e)
        {

        }
    }
}