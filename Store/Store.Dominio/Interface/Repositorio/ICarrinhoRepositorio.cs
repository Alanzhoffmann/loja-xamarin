using System.Threading.Tasks;
using Store.Dominio.Entidade;

namespace Store.Dominio.Interface.Repositorio
{
    public interface ICarrinhoRepositorio : IRepositorioBase<Carrinho>
    {
        Task<Carrinho> RetornarAtual();
    }
}
