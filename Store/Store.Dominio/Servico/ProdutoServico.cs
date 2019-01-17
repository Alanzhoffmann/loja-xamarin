using Store.Dominio.Entidade;
using Store.Dominio.Interface;

namespace Store.Dominio.Servico
{
    public class ProdutoServico : ServicoEntidadeBase<Produto>
    {
        private readonly IProdutoRepositorio _repositorio;

        public ProdutoServico(IProdutoRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}