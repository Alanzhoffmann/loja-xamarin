namespace Store.App.DTO
{
    public class ItemCarrinhoDTO
    {
        public int Quantidade { get; set; }

        public ProdutoDTO Produto { get; set; }

        public decimal PorcentagemDesconto { get; set; }

        public decimal ValorUnitario { get; set; }

        public decimal ValorBruto { get; set; }

        public decimal ValorDesconto { get; set; }

        public decimal ValorLiquido { get; set; }
    }
}