using Newtonsoft.Json;

namespace Store.Dominio.Entidade
{
    public class EntidadeBase
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
