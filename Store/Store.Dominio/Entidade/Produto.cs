using Newtonsoft.Json;

namespace Store.Dominio.Entidade
{
    public class Produto : EntidadeBase
    {
        private int _categoriaId;

        [JsonProperty("name")]
        public string Nome { get; set; }
        [JsonProperty("description")]
        public string Descricao { get; set; }
        [JsonProperty("photo")]
        public string Imagem { get; set; }
        [JsonProperty("price")]
        public decimal Preco { get; set; }
        public Categoria Categoria { get; set; }
        [JsonProperty("category_id")]
        public int CategoriaId
        {
            get => _categoriaId;
            set
            {
                _categoriaId = value;
                Categoria = new Categoria()
                {
                    Id = value
                };
            }
        }
    }
}
