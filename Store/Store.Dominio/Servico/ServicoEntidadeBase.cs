using System.Threading.Tasks;
using Store.Dominio.Entidade;
using Store.Dominio.Interface;

namespace Store.Dominio.Servico
{
    public class ServicoEntidadeBase<T> : ServicoBase<T> where T : EntidadeBase
    {
        private readonly IRepositorioEntidadeBase<T> _repositorio;

        public ServicoEntidadeBase(IRepositorioEntidadeBase<T> repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }

        public virtual async Task<T> RetornarPorId(long id)
        {
            return await _repositorio.RetornarPorId(id);
        }
    }
}