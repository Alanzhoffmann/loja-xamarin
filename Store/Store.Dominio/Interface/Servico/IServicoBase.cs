using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Dominio.Interface.Servico
{
    public interface IServicoBase<T>
    {
        Task<IList<T>> RetornarTodos(Predicate<T> filter = null);
    }
}