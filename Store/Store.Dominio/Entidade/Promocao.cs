using Newtonsoft.Json;

namespace Store.Dominio.Entidade
{
    public class Promocao
    {
        private int _categoriaId;

        [JsonProperty("name")]
        public string Nome { get; set; }

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

        [JsonProperty("policies")]
        public AplicacaoPromocao[] AplicacoesPromocao { get; set; }
    }
}