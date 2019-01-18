using System;

namespace Store.Dominio.Entidade
{
    public class ItemCarrinho
    {
        public ItemCarrinho(Produto produto, int quantidade = 1)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public int Quantidade { get; set; }

        public Produto Produto { get; set; }

        public decimal PorcentagemDesconto => ValorDesconto / Valor * 100;

        public decimal Valor => Produto?.Preco ?? 0;

        public decimal ValorDesconto { get; set; }

        public decimal ValorFinal => Valor - ValorDesconto;

        public void AplicarPromocao(Promocao promocao)
        {
            if (promocao == null)
            {
                throw new ArgumentNullException(nameof(promocao));
            }

            if (promocao.CategoriaId != Produto.CategoriaId)
            {
                throw new InvalidOperationException("Promoção inválida para este produto");
            }

            ValorDesconto = promocao.RetornarValorDescontoPorQuantidade(Quantidade);
        }
    }
}
