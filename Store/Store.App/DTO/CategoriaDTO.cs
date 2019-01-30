using Store.Dominio.Entidade;

namespace Store.App.DTO
{
    public class CategoriaDTO
    {
        public CategoriaDTO()
        {
        }

        public CategoriaDTO(Categoria categoria)
        {
            Id = categoria.Id;
            Nome = categoria.Nome;
        }

        public long Id { get; set; }

        public string Nome { get; set; }
    }
}