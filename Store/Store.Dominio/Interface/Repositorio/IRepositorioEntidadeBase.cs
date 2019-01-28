using System.Threading.Tasks;
using Store.Dominio.Entidade;

namespace Store.Dominio.Interface.Repositorio
{
    public interface IRepositorioEntidadeBase<T> : IRepositorioBase<T> where T : EntidadeBase
    {
        Task<T> RetornarPorId(long id);
    }
}