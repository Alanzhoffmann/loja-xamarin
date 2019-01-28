namespace Store.App.DTO
{
    public class PromocaoDTO
    {
        public string Nome { get; set; }

        public CategoriaDTO Categoria { get; set; }

        public DescontoDTO[] Descontos { get; set; }
    }
}