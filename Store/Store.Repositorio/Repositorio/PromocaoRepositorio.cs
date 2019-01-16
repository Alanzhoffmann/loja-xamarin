using Store.Dominio.Entidade;
using Store.Dominio.Interface;

namespace Store.Repositorio.Repositorio
{
    public class PromocaoRepositorio : RepositorioBase<Promocao>, IPromocaoRepositorio
    {
        internal override string RetornarUrlConsulta()
        {
            return "https://pastebin.com/raw/R9cJFBtG";
        }
    }
}