namespace GamingStore.Models
{
    public class OrderDetail
    {
        //customer reviews their order
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public int GameId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
