using System;

namespace Store.Dominio.Entidade
{
    public class ItemCarrinho
    {
        private Produto _produto;
        private int _quantidade;

        public ItemCarrinho(Produto produto, int quantidade = 1)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public int Quantidade
        {
            get => _quantidade;
            set => _quantidade = value > 0 ? value : throw new InvalidOperationException("A quantidade de itens deve ser positiva");
        }

        public Produto Produto
        {
            get => _produto;
            set => _produto = value ?? throw new InvalidOperationException("É obrigatório informar um produto para o ItemCarrinho");
        }

        public decimal PorcentagemDesconto => ValorDesconto / ValorUnitario * 100;

        public decimal ValorUnitario
        {
            get
            {
                decimal preco = Produto.Preco;
                return preco > 0 ? preco : 0;
            }
        }

        public decimal ValorBruto => ValorUnitario * Quantidade;

        public decimal ValorDesconto { get; set; }

        public decimal ValorLiquido => ValorBruto - ValorDesconto;

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