using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Dominio.Entidade;

namespace Store.Dominio.Interface.Servico
{
    public interface IPromocaoServico : IServicoBase<Promocao>
    {
        Task<IList<Promocao>> RetornarPorCategoria(int categoriaId);
    }
}