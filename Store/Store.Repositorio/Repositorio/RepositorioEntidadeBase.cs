using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Dominio.Entidade;
using Store.Dominio.Interface;

namespace Store.Repositorio.Repositorio
{
    public abstract class RepositorioEntidadeBase<T> : RepositorioBase<T>, IRepositorioEntidadeBase<T> where T : EntidadeBase
    {
        public virtual async Task<T> RetornarPorId(long id)
        {
            IList<T> dados = await RetornarTodos(t => t.Id == id);
            return dados.Count > 0 ? dados[0] : default;
        }
    }
}