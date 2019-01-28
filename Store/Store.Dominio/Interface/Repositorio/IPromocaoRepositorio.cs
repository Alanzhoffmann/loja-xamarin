using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Dominio.Entidade;

namespace Store.Dominio.Interface.Repositorio
{
    public interface IPromocaoRepositorio : IRepositorioBase<Promocao>
    {
        Task<IList<Promocao>> RetornarPorCategoria(int categoriaId);
    }
}