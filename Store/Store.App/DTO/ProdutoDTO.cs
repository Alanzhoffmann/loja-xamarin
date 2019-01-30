using Store.Dominio.Entidade;

namespace Store.App.DTO
{
    public class ProdutoDTO
    {
        public ProdutoDTO()
        {
        }

        public ProdutoDTO(Produto produto)
        {
            Nome = produto.Nome;
            Descricao = produto.Descricao;
            Imagem = produto.Imagem;
            Preco = produto.Preco;
            Categoria = new CategoriaDTO(produto.Categoria);
        }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Imagem { get; set; }

        public decimal Preco { get; set; }

        public CategoriaDTO Categoria { get; set; }
    }
}