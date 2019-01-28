using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Dominio.Entidade;
using Store.Dominio.Interface.Repositorio;
using Store.Dominio.Interface.Servico;

namespace Store.Dominio.Servico
{
    public class CarrinhoServico : ICarrinhoServico
    {
        private readonly ICarrinhoRepositorio _carrinhoRepositorio;
        private readonly IPromocaoRepositorio _promocaoRepositorio;

        public CarrinhoServico(ICarrinhoRepositorio carrinhoRepositorio, IPromocaoRepositorio promocaoRepositorio)
        {
            _carrinhoRepositorio = carrinhoRepositorio;
            _promocaoRepositorio = promocaoRepositorio;
        }

        public async Task<Carrinho> AdicionarItem(Produto produto, int quantidade = 1)
        {
            Carrinho carrinhoAtual = await RetornarAtual();
            if (produto != null && quantidade > 0)
            {
                // TODO: Validar promoções
                IList<Promocao> promocoes = await _promocaoRepositorio.RetornarPorCategoria(produto.CategoriaId);
                Promocao promocaoAplicada = promocoes[0];

                carrinhoAtual.AdicionarItem(produto, quantidade, promocaoAplicada);

                return carrinhoAtual;
            }

            return null;
        }

        public async Task<Carrinho> RetornarAtual()
        {
            return await _carrinhoRepositorio.RetornarAtual();
        }

        public async Task<IList<Carrinho>> RetornarTodos(Predicate<Carrinho> filter = null)
        {
            return await _carrinhoRepositorio.RetornarTodos(filter);
        }
    }
}