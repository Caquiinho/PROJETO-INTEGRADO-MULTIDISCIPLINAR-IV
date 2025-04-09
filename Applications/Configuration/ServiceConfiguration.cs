using Applications.Interfaces;

namespace Applications.Configuration
{
    public class ServiceConfiguration
    {
        public IClienteService clienteService { get; set; }
        public IUsuarioService usuarioService { get; set; }
        public IPerfilService perfilService { get; set; }
        public IProdutoService produtoService { get; set; } 
    }

    public class Service
    {
        private readonly IClienteService _clienteService;
        private readonly IUsuarioService _usuarioService;
        private readonly IPerfilService _perfilService;
        private readonly IProdutoService _produtoService;

        public Service(ServiceConfiguration configuration)
        {
            _clienteService = configuration.clienteService;
            _usuarioService = configuration.usuarioService;
            _perfilService = configuration.perfilService;
            _produtoService = configuration.produtoService;
        }
    }
}