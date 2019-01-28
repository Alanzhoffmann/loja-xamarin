using Store.Dominio.Entidade;
using Store.Dominio.Interface.Repositorio;
using Store.Dominio.Interface.Servico;

namespace Store.Dominio.Servico
{
    public class CategoriaServico : ServicoEntidadeBase<Categoria>, ICategoriaServico
    {
        private readonly ICategoriaRepositorio _repositorio;

        public CategoriaServico(ICategoriaRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}