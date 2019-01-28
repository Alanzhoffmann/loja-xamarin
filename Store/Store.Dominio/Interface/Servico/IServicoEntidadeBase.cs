using System.Threading.Tasks;
using Store.Dominio.Entidade;

namespace Store.Dominio.Interface.Servico
{
    public interface IServicoEntidadeBase<T> : IServicoBase<T> where T : EntidadeBase
    {
        Task<T> RetornarPorId(long id);
    }
}