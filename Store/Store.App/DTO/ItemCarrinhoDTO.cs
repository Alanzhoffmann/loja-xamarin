using Store.Dominio.Entidade;

namespace Store.App.DTO
{
    public class ItemCarrinhoDTO
    {
        public ItemCarrinhoDTO()
        {
        }

        public ItemCarrinhoDTO(ItemCarrinho itemCarrinho)
        {
            Quantidade = itemCarrinho.Quantidade;
            Produto = new ProdutoDTO(itemCarrinho.Produto);
            PorcentagemDesconto = itemCarrinho.PorcentagemDesconto;
            ValorUnitario = itemCarrinho.ValorUnitario;
            ValorBruto = itemCarrinho.ValorBruto;
            ValorDesconto = itemCarrinho.ValorDesconto;
            ValorLiquido = itemCarrinho.ValorLiquido;
        }

        public int Quantidade { get; set; }

        public ProdutoDTO Produto { get; set; }

        public decimal PorcentagemDesconto { get; set; }

        public decimal ValorUnitario { get; set; }

        public decimal ValorBruto { get; set; }

        public decimal ValorDesconto { get; set; }

        public decimal ValorLiquido { get; set; }
    }
}