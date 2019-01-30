using System.Linq;
using Store.Dominio.Entidade;

namespace Store.App.DTO
{
    public class CarrinhoDTO
    {
        public CarrinhoDTO()
        {
        }

        public CarrinhoDTO(Carrinho carrinho)
        {
            Itens = carrinho.Itens.Select(i => new ItemCarrinhoDTO(i)).ToArray();
            ValorTotal = carrinho.ValorTotal;
        }

        public ItemCarrinhoDTO[] Itens { get; set; }

        public decimal ValorTotal { get; set; }
    }
}