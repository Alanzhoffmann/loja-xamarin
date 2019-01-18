using System.Collections.Generic;
using System.Linq;

namespace Store.Dominio.Entidade
{
    public class Carrinho
    {
        private readonly List<ItemCarrinho> _itens;

        public Carrinho()
        {
            _itens = new List<ItemCarrinho>();
        }

        public IReadOnlyList<ItemCarrinho> Itens => _itens;

        public decimal ValorTotal => Itens.Sum(i => i.ValorFinal);

        public ItemCarrinho AdicionarItem(ItemCarrinho item)
        {
            foreach (ItemCarrinho i in _itens)
            {
                if (i.Produto.Id == item.Produto.Id)
                {
                    i.Quantidade = item.Quantidade;
                    return item;
                }
            }

            _itens.Add(item);
            return item;
        }

        public ItemCarrinho AdicionarItem(Produto produto, int quantidade = 1, Promocao promocao = null)
        {
            var itemCarrinho = new ItemCarrinho(produto, quantidade);
            if (promocao != null)
            {
                itemCarrinho.AplicarPromocao(promocao);
            }
            return AdicionarItem(itemCarrinho);
        }

        public void RemoverItem(ItemCarrinho item)
        {
            RemoverItem(produtoId: item.Produto.Id);
        }

        public void RemoverItem(int indice = 0, long produtoId = 0)
        {
            if (indice > 0)
            {
                _itens.RemoveAt(indice);
            }
            else if (produtoId > 0)
            {
                _itens.RemoveAll(i => i.Produto.Id == produtoId);
            }
        }
    }
}