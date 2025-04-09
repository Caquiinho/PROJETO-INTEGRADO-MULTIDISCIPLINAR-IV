using Applications.Interfaces;
using Domain.Entities;
using Infrastructure.Configuration;

namespace Applications.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly RepositoryConfiguration _configuration;

        public ProdutoService(RepositoryConfiguration configuration)
        {
            _configuration = configuration;
        }

        public bool AlterarProduto(Produto produto)
        {
            try
            {
                return _configuration.produtoRepository.AlterarProduto(produto);
            }
            catch
            {
                throw;
            }
        }

        

        public List<Produto> ConsultarProduto(string nomeProduto)
        {
            try
            {
                return _configuration.produtoRepository.ConsultarProduto(nomeProduto);
            }
            catch
            {
                throw;
            }
        }

        public bool ExcluirProduto(int id)
        {
            try
            {
                return _configuration.produtoRepository.ExcluirProduto(id);
            }
            catch
            {
                throw;
            }
        }

        public bool IncluirProduto(Produto produto)
        {
            try
            {
                return _configuration.produtoRepository.IncluirProduto(produto);
            }
            catch
            {
                throw;
            }
        }
    }
}