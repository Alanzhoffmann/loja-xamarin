using Store.Dominio.Entidade;
using Store.Dominio.Interface;

namespace Store.Dominio.Servico
{
    public class CategoriaServico : ServicoEntidadeBase<Categoria>
    {
        private readonly ICategoriaRepositorio _repositorio;

        public CategoriaServico(ICategoriaRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}