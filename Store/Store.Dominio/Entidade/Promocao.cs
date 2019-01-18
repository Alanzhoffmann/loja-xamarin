using System.Linq;
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
        public Desconto[] Descontos { get; set; }

        public decimal RetornarValorDescontoPorQuantidade(int quantidade)
        {
            if (Descontos != null)
            {
                foreach (Desconto desconto in Descontos.OrderByDescending(d => d.QuantidadeMinima))
                {
                    if (quantidade > desconto.QuantidadeMinima)
                    {
                        return desconto.ValorDesconto;
                    }
                }
            }

            return 0;
        }
    }
}