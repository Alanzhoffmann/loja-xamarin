using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Dominio.Entidade;
using Store.Dominio.Interface.Repositorio;

namespace Store.Repositorio.Repositorio
{
    public class PromocaoRepositorio : RepositorioBase<Promocao>, IPromocaoRepositorio
    {
        public async Task<IList<Promocao>> RetornarPorCategoria(int categoriaId)
        {
            return await RetornarTodos(p => p.CategoriaId == categoriaId);
        }

        internal override string RetornarUrlConsulta()
        {
            return "https://pastebin.com/raw/R9cJFBtG";
        }
    }
}