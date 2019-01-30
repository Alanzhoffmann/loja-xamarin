using System.Threading.Tasks;
using Store.App.DTO;
using Store.Dominio.Interface.Servico;

namespace Store.App.AppService
{
    public class CarrinhoAppService
    {
        private readonly ICarrinhoServico _carrinhoServico;

        public CarrinhoAppService(ICarrinhoServico carrinhoServico)
        {
            _carrinhoServico = carrinhoServico;
        }

        public async Task<CarrinhoDTO> RetornarAtual()
        {
            var carrinho = await _carrinhoServico.RetornarAtual();
            if (carrinho != null)
            {
                return new CarrinhoDTO(carrinho);
            }
            return null;
        }

        public async Task<CarrinhoDTO> AdicionarItem(int produtoId, int quantidade = 1)
        {
            var carrinho = await _carrinhoServico.AdicionarItem(produtoId, quantidade);
            if (carrinho != null)
            {
                return new CarrinhoDTO(carrinho);
            }
            return null;
        }

        //public async Task<CarrinhoDTO> RemoverItem()
        //{

        //}
    }
}
