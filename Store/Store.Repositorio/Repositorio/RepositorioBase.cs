using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Dominio.Interface;
using Store.Repositorio.Helper;

namespace Store.Repositorio.Repositorio
{
    public abstract class RepositorioBase<T> : IRepositorioBase<T>
    {
        internal abstract string RetornarUrlConsulta();

        public async Task<IList<T>> RetornarTodos(Predicate<T> filtro = null)
        {
            string url = RetornarUrlConsulta();
            T[] dados = await WebRequest.Instancia.Retornar<T[]>(url);

            if (dados != null)
            {
                var lista = new List<T>(dados);
                return filtro != null ? lista.FindAll(filtro) : lista;
            }
            return null;
        }
    }
}