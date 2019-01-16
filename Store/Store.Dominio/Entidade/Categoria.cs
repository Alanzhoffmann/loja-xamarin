using Newtonsoft.Json;

namespace Store.Dominio.Entidade
{
    public class Categoria : EntidadeBase
    {
        [JsonProperty("name")]
        public string Nome { get; set; }
    }
}