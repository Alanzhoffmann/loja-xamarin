using Newtonsoft.Json;

namespace Store.Dominio.Entidade
{
	public class Categoria
	{
		[JsonProperty("id")]
		public long Id { get; set; }
		[JsonProperty("name")]
		public string Nome { get; set; }
	}
}