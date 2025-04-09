using Domain.Entities;

namespace Applications.Interfaces
{
    public interface IProdutoService
    {
        bool IncluirProduto(Produto produto);
        List<Produto> ConsultarProduto(string nomeProduto);
        bool AlterarProduto(Produto produto);
        bool ExcluirProduto(int id);
     
    }
}