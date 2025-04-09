using Infrastructure.Interface;
using Infrastructure.Interfaces;

namespace Infrastructure.Configuration
{
    public class RepositoryConfiguration
    {
        public IClienteRepository clienteRepository { get; set; }
        public IUsuarioRepository usuarioRepository { get; set; }
        public IPerfilRepository perfilRepository { get; set; }

        public IProdutoRepository produtoRepository { get; set; }

    }

    public class Repository
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IPerfilRepository _perfilRepository;
        private readonly IProdutoRepository _produtoRepository;

        public Repository(RepositoryConfiguration configuration)
        {
            _clienteRepository = configuration.clienteRepository;
            _usuarioRepository = configuration.usuarioRepository;
            _perfilRepository = configuration.perfilRepository;
            _produtoRepository = configuration.produtoRepository;
        }
    }
}