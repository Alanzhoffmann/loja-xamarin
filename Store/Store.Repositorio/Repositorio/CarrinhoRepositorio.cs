using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Dominio.Entidade;
using Store.Dominio.Interface.Repositorio;

namespace Store.Repositorio.Repositorio
{
    public class CarrinhoRepositorio : RepositorioBase<Carrinho>, ICarrinhoRepositorio
    {
        private readonly List<Carrinho> carrinhos = new List<Carrinho>();

        public override async Task<IList<Carrinho>> RetornarTodos(Predicate<Carrinho> filtro = null)
        {
            return await Task.FromResult((IList<Carrinho>)carrinhos.Find(filtro));
        }

        public async Task<Carrinho> RetornarAtual()
        {
            if (carrinhos.Count > 0)
            {
                carrinhos.Add(new Carrinho());
            }
            return await Task.FromResult(carrinhos[0]);
        }

        internal override string RetornarUrlConsulta()
        {
            throw new System.NotImplementedException();
        }
    }
}