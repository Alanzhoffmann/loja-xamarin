namespace Store.App.DTO
{
    public class ProdutoDTO
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Imagem { get; set; }

        public decimal Preco { get; set; }

        public CategoriaDTO Categoria { get; set; }
    }
}