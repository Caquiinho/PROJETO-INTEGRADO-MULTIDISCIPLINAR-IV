using Applications.Configuration;
using Desktop.ValidadoresComponentes;
using Domain.DTO;
using Domain.Entities;
using Infrastructure.Encrypt;
using Infrastructure.Validadores;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.ModuloFornecedor
{
    public partial class frmAdicionarFornecedor : Form
    {
        #region Construtor

        #endregion
        private async void mskCep_Leave(object sender, EventArgs e)
        {
            string cep = mskkCep.Text;
            string apiUrl = $"https://viacep.com.br/ws/{cep}/json/";
            string response = await GetApiData(apiUrl);
            var endereco = JsonConvert.DeserializeObject<EnderecoDTO>(response);
            txtEnderecoFo.Text = endereco.Logradouro;
        }

       

        private async Task<string> GetApiData(string apiUrl)
        {
            throw new NotImplementedException();
        }

        public frmAdicionarFornecedor(ServiceConfiguration _configuration)
        {
            InitializeComponent();
        }

        private void frmAdicionarFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
