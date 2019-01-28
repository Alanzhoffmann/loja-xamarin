using System.Threading.Tasks;
using Store.Dominio.Entidade;

namespace Store.Dominio.Interface.Servico
{
    public interface ICarrinhoServico : IServicoBase<Carrinho>
    {
        Task<Carrinho> RetornarAtual();

        Task<Carrinho> AdicionarItem(Produto produto, int quantidade = 1);
    }
}