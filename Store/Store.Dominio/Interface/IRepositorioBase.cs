using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Dominio.Interface
{
    public interface IRepositorioBase<T>
    {
        Task<IList<T>> RetornarTodos(Predicate<T> filter = null);
    }
}