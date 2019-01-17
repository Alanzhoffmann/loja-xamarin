using Store.Dominio.Entidade;
using Store.Dominio.Interface;

namespace Store.Dominio.Servico
{
    public class PromocaoServico : ServicoBase<Promocao>
    {
        private readonly IPromocaoRepositorio _repositorio;

        public PromocaoServico(IPromocaoRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}