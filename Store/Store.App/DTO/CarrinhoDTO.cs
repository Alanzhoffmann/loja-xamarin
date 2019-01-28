namespace Store.App.DTO
{
    public class CarrinhoDTO
    {
        public ItemCarrinhoDTO[] Itens { get; set; }

        public decimal ValorTotal { get; set; }
    }
}