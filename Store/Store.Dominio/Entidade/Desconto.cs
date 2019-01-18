using Newtonsoft.Json;

namespace Store.Dominio.Entidade
{
    public class Desconto
    {
        [JsonProperty("min")]
        public int QuantidadeMinima { get; set; }

        [JsonProperty("discount")]
        public decimal ValorDesconto { get; set; }
    }
}