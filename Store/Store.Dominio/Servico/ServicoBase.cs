using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Dominio.Interface;

namespace Store.Dominio.Servico
{
    public class ServicoBase<T>
    {
        private readonly IRepositorioBase<T> _repositorio;

        public ServicoBase(IRepositorioBase<T> repositorio)
        {
            _repositorio = repositorio;
        }

        public virtual async Task<IList<T>> RetornarTodos(Predicate<T> filter = null)
        {
            return await _repositorio.RetornarTodos(filter);
        }
    }
}