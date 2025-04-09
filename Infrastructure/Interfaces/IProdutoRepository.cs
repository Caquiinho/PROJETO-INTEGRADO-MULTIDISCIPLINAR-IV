using Domain.Entities;

namespace Infrastructure.Interfaces
{
    public interface IProdutoRepository
    {
        bool IncluirProduto(Produto Produto);
        List<Produto> ConsultarProduto(string nomeProduto);
        bool AlterarProduto (Produto produto);
        bool ExcluirProduto(int id);

    }

}
