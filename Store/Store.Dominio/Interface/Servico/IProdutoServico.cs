using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Dominio.Entidade;

namespace Store.Dominio.Interface.Servico
{
    public interface IProdutoServico : IServicoEntidadeBase<Produto>
    {
        Task<IList<Produto>> RetornarPorCategoria(int categoriaId);
    }
}