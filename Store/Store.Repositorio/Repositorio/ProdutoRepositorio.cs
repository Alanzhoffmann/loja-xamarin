using Store.Dominio.Entidade;
using Store.Dominio.Interface;

namespace Store.Repositorio.Repositorio
{
    public class ProdutoRepositorio : RepositorioEntidadeBase<Produto>, IProdutoRepositorio
    {
        internal override string RetornarUrlConsulta()
        {
            return "https://pastebin.com/raw/eVqp7pfX";
        }
    }
}