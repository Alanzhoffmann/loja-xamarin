using Store.Dominio.Entidade;
using Store.Dominio.Interface.Repositorio;

namespace Store.Repositorio.Repositorio
{
    public class CategoriaRepositorio : RepositorioEntidadeBase<Categoria>, ICategoriaRepositorio
    {
        internal override string RetornarUrlConsulta()
        {
            return "http://pastebin.com/raw/YNR2rsWe";
        }
    }
}