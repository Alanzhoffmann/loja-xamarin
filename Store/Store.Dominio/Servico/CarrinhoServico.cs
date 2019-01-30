using System.Collections.Generic;
using System.Threading.Tasks;
using Store.Dominio.Entidade;
using Store.Dominio.Interface.Repositorio;
using Store.Dominio.Interface.Servico;

namespace Store.Dominio.Servico
{
    public class CarrinhoServico : ServicoBase<Carrinho>, ICarrinhoServico
    {
        private readonly ICarrinhoRepositorio _carrinhoRepositorio;
        private readonly IPromocaoRepositorio _promocaoRepositorio;
        private readonly IProdutoRepositorio _produtoRepositorio;

        public CarrinhoServico(ICarrinhoRepositorio carrinhoRepositorio, IPromocaoRepositorio promocaoRepositorio, IProdutoRepositorio produtoRepositorio)
            : base(carrinhoRepositorio)
        {
            _carrinhoRepositorio = carrinhoRepositorio;
            _promocaoRepositorio = promocaoRepositorio;
            _produtoRepositorio = produtoRepositorio;
        }

        public async Task<Carrinho> AdicionarItem(long produtoId, int quantidade = 1)
        {
            Produto produto = await _produtoRepositorio.RetornarPorId(produtoId);
            return await AdicionarItem(produto, quantidade);
        }

        private async Task<Carrinho> AdicionarItem(Produto produto, int quantidade = 1)
        {
            Carrinho carrinhoAtual = await RetornarAtual();
            if (produto != null && quantidade > 0)
            {
                // TODO: Validar promoções (promoções deveriam ser por produto e não por categoria?)
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
    }
}